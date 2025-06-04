using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LIbraryManagmentSystem.Books
{
    public partial class frmListBooks : Form
    {
        private static DataTable _dtAllBooks;
        int _publisherID = -1;
        int _auhtorID = -1;
        private void _RefreshDataGrid()
        {
            if (_publisherID != -1)
            {
                _dtAllBooks = clsPublisher.GetAllBooks(_publisherID);
            }
            else if (_auhtorID !=-1)
            {
                _dtAllBooks = clsAuthor.GetAllBooks(_auhtorID);
            }
            else
            {
                _dtAllBooks = clsBook.GetAllBooks();
            }
            
            dgvBooks.DataSource = _dtAllBooks;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvBooks.Rows.Count.ToString();
            if (_dtAllBooks.Rows.Count == 0)
            {
                return;
            }
            dgvBooks.Columns[0].HeaderText = "Book ID";
            dgvBooks.Columns[0].Width = 80;

            //dgvUsers.Columns[1].HeaderText = "Person ID";
            //dgvUsers.Columns[1].Width = 120;

            dgvBooks.Columns[1].HeaderText = "Title";
            dgvBooks.Columns[1].Width = 80;

            dgvBooks.Columns[2].HeaderText = "Author";
            dgvBooks.Columns[2].Width = 200;

            dgvBooks.Columns[3].HeaderText = "ISBN";
            dgvBooks.Columns[3].Width = 80;

            dgvBooks.Columns[4].HeaderText = "Pulisher";
            dgvBooks.Columns[4].Width = 200;

            dgvBooks.Columns[5].HeaderText = "Category Name";
            dgvBooks.Columns[5].Width = 150;

            dgvBooks.Columns[6].HeaderText = "Location";
            dgvBooks.Columns[6].Width = 100;

            dgvBooks.Columns[7].HeaderText = "Borrow Fees";
            dgvBooks.Columns[7].Width = 50;

            dgvBooks.Columns[8].HeaderText = "Total Copies";
            dgvBooks.Columns[8].Width = 60;

            dgvBooks.Columns[9].HeaderText = "Available Copies";
            dgvBooks.Columns[9].Width = 60;

        }
        public frmListBooks()
        {
            InitializeComponent();
        }
        public frmListBooks(int authorID = -1, int publiserID= -1)
        {
            InitializeComponent();
            this._auhtorID = authorID;
            this._publisherID = publiserID;
        }

        private void frmListBooks_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
           
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {



            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();


        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Book ID":
                    FilterColumn = "BookID";
                    break;
                case "Category Name":
                    FilterColumn = "CategoryName";
                    break;
                default:
                    FilterColumn = cbFilterBy.Text;
                    break;
            }
            
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllBooks.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllBooks.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "BookID")
                //in this case we deal with numbers not string.
                _dtAllBooks.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllBooks.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllBooks.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "Book ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void insertCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertCopies frm = new frmInsertCopies((int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void showAllCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCopies frm = new frmListCopies((int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void edToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook((int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this book?","Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsBook.Delete((int)dgvBooks.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Book Deleted successfully","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDataGrid() ;
                }
                else
                {
                    MessageBox.Show("Book was not deleted; because data link with it.", "faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void MakeButtonCircular(Button btn)
        {
            // Create a circular region for the button
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
