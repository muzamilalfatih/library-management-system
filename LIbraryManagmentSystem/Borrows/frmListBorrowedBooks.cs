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

namespace LIbraryManagmentSystem.Borrows
{
    public partial class frmListBorrowedBooks : Form
    {
        private static DataTable _dtAllBorrows;
        private void _RefreshDataGrid()
        {
            _dtAllBorrows = clsBorrow.GetAllBorrows();
            dgvBorrows.DataSource = _dtAllBorrows;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvBorrows.Rows.Count.ToString();
            if (_dtAllBorrows.Rows.Count == 0)
            {
                return;
            }
            dgvBorrows.Columns[0].HeaderText = "Borrow ID";
            dgvBorrows.Columns[0].Width = 80;

            dgvBorrows.Columns[1].HeaderText = "Memmber ID";
            dgvBorrows.Columns[1].Width = 80;

            dgvBorrows.Columns[2].HeaderText = "Member Name";
            dgvBorrows.Columns[2].Width = 250;

            dgvBorrows.Columns[3].HeaderText = "Book Name";
            dgvBorrows.Columns[3].Width = 150;

            dgvBorrows.Columns[4].HeaderText = "Book Copy ID";
            dgvBorrows.Columns[4].Width = 80;
            dgvBorrows.Columns[5].HeaderText = "Is Returned";
            dgvBorrows.Columns[5].Width = 100;
        }
        public frmListBorrowedBooks()
        {
            InitializeComponent();
        }

        private void frmListBorrowedBooks_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Returned")
            {
                txtFilterValue.Visible = false;
                cbIsReturned.Visible = true;
                cbIsReturned.Focus();
                cbIsReturned.SelectedIndex = 0;
            }

            else

            {

                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsReturned.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void cbIsReturned_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReturned";
            string FilterValue = cbIsReturned.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtAllBorrows.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllBorrows.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtAllBorrows.Rows.Count.ToString();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Borrow ID":
                    FilterColumn = "BorrowID";
                    break;
                case "Member ID":
                    FilterColumn = "MemberID";
                    break;

                case "Member Name":
                    FilterColumn = "MemberName";
                    break;


                case "Book Name":
                    FilterColumn = "BookName";
                    break;
                case "Book Copy ID":
                    FilterColumn = "BookCopyID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllBorrows.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvBorrows.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "BorrowID" || FilterColumn == "MemberID" || FilterColumn == "BookCopyID")
                //in this case we deal with numbers not string.
                _dtAllBorrows.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllBorrows.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllBorrows.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmBorrowBook frm = new frmBorrowBook();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowBook frm = new frmBorrowBook();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturnBook frm = new frmReturnBook();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnBook frm = new frmReturnBook((int)dgvBorrows.CurrentRow.Cells[4].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void cmBorrowing_Opening(object sender, CancelEventArgs e)
        {
            returnBookToolStripMenuItem.Enabled = !(bool)dgvBorrows.CurrentRow.Cells[5].Value;
        }
    }
}
