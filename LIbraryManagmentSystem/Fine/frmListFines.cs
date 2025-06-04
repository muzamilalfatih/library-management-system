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

namespace LIbraryManagmentSystem.Fine
{
    public partial class frmListFines : Form
    {
        private static DataTable _dtAllBorrows;
        private void _RefreshDataGrid()
        {
            _dtAllBorrows = clsFine.GetAllFines();
            dgvFines.DataSource = _dtAllBorrows;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvFines.Rows.Count.ToString();
            if (_dtAllBorrows.Rows.Count == 0)
            {
                return;
            }
            dgvFines.Columns[0].HeaderText = "Fine ID";
            dgvFines.Columns[0].Width = 100;

            dgvFines.Columns[1].HeaderText = "Memmber ID";
            dgvFines.Columns[1].Width = 100;

            dgvFines.Columns[2].HeaderText = "Borrow ID";
            dgvFines.Columns[2].Width = 100;

            dgvFines.Columns[3].HeaderText = "Fine Amount";
            dgvFines.Columns[3].Width = 150;

            dgvFines.Columns[4].HeaderText = "Paid Amount";
            dgvFines.Columns[4].Width = 150;

            dgvFines.Columns[5].HeaderText = "Fine Date";
            dgvFines.Columns[5].Width = 100;

            dgvFines.Columns[6].HeaderText = "Is Paid";
            dgvFines.Columns[6].Width = 100;

            dgvFines.Columns[7].HeaderText = "Fine Reason";
            dgvFines.Columns[7].Width = 100;
        }
        public frmListFines()
        {
            InitializeComponent();
        }

        private void frmListFines_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Paid")
            {
                txtFilterValue.Visible = false;
                cbIsPaid.Visible = true;
                cbIsPaid.Focus();
                cbIsPaid.SelectedIndex = 0;
            }

            else

            {

                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsPaid.Visible = false;

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

        private void cbIsPaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsPaid";
            string FilterValue = cbIsPaid.Text;

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
                case "Fine ID":
                    FilterColumn = "FineID";
                    break;
                case "Member ID":
                    FilterColumn = "MemberID";
                    break;

                case "Borrow ID":
                    FilterColumn = "BorrowID";
                    break;


                case "Fine Amount":
                    FilterColumn = "FineAmount";
                    break;
                case "Fine Date":
                    FilterColumn = "FineData";
                    break;
                case "Fine Reason":
                    FilterColumn = "FineReason";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllBorrows.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvFines.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "FineID" || FilterColumn == "MemberID" || FilterColumn == "BorrowID")
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

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text != "Fine Reason")
            {
                e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
            }    
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayFine frm = new frmPayFine((int)dgvFines.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void cmFines_Opening(object sender, CancelEventArgs e)
        {
            payToolStripMenuItem.Enabled = !(bool)dgvFines.CurrentRow.Cells[6].Value;
        }
    }
}
