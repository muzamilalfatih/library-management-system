using LIbraryManagmentSystem.Books;
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

namespace LIbraryManagmentSystem.Authors
{
    public partial class frmListAuthors : Form
    {
        private static DataTable _dtAllAuthors;
        private void _RefreshDataGrid()
        {
            _dtAllAuthors = clsAuthor.GetAllAuthors();
            dgvAuthors.DataSource = _dtAllAuthors;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvAuthors.Rows.Count.ToString();
            if (_dtAllAuthors.Rows.Count == 0)
            {
                return;
            }
            dgvAuthors.Columns[0].HeaderText = "Author ID";
            dgvAuthors.Columns[0].Width = 80;

            

            dgvAuthors.Columns[1].HeaderText = "Author Name";
            dgvAuthors.Columns[1].Width = 250;

            dgvAuthors.Columns[2].HeaderText = "Email";
            dgvAuthors.Columns[2].Width = 200;

            dgvAuthors.Columns[3].HeaderText = "Phone";
            dgvAuthors.Columns[3].Width = 80;

            dgvAuthors.Columns[4].HeaderText = "Total Books";
            dgvAuthors.Columns[4].Width = 80;

        }
        public frmListAuthors()
        {
            InitializeComponent();
        }

        private void frmListAuthors_Load(object sender, EventArgs e)
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
                case "Author ID":
                    FilterColumn = "AuthorID";
                    break;
                case "Author Name":
                    FilterColumn = "AuthorName";
                    break;
                default:
                    FilterColumn = cbFilterBy.Text;
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllAuthors.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllAuthors.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "AuthorID")
                //in this case we deal with numbers not string.
                _dtAllAuthors.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllAuthors.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllAuthors.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Author ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateAuthor frm = new frmAddNewUpdateAuthor();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorInfo frm = new frmAuthorInfo((int)dgvAuthors.CurrentRow.Cells[0].Value);   
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateAuthor frm = new frmAddNewUpdateAuthor();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateAuthor frm = new frmAddNewUpdateAuthor((int)dgvAuthors.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Author?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                if (clsAuthor.DeleteAuthor((int)dgvAuthors.CurrentRow.Cells[0].Value))
                {
                    _RefreshDataGrid();
                    MessageBox.Show("Author deleted successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Author is not deleted;because data linked wiht it!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBooks frm = new frmListBooks(authorID: (int)dgvAuthors.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
