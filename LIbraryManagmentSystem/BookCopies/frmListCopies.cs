using LIbraryManagmentSystem.BookCopies;
using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.Books
{
    public partial class frmListCopies : Form
    {
        private static DataTable _dtAllUsers;
        private int _BookID;
        private void _RefreshDataGrid()
        {
            _dtAllUsers = clsBookCopy.GetAllCopies(_BookID);
            dgvBookCopies.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvBookCopies.Rows.Count.ToString();
            if (_dtAllUsers.Rows.Count == 0)
            {
                return;
            }
            dgvBookCopies.Columns[0].HeaderText = "BookCopyID";
            dgvBookCopies.Columns[0].Width = 110;

            //dgvUsers.Columns[1].HeaderText = "Person ID";
            //dgvUsers.Columns[1].Width = 120;

            dgvBookCopies.Columns[1].HeaderText = "BookID";
            dgvBookCopies.Columns[1].Width = 80;

            dgvBookCopies.Columns[2].HeaderText = "ReservedForMemberID";
            dgvBookCopies.Columns[2].Width = 250;

            dgvBookCopies.Columns[3].HeaderText = "IsAvailable";
            dgvBookCopies.Columns[3].Width = 80;
            dgvBookCopies.Columns[4].HeaderText = "Is Damaged";
            dgvBookCopies.Columns[4].Width = 80;


        }
        public frmListCopies(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        private void frmListCopies_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Damaged")
            {
                txtFilterValue.Visible = false;
                cbIsAvailable.Visible = false;
                cbIsDamaged.Visible = true;
                cbIsDamaged.Focus();
                cbIsDamaged.SelectedIndex = 0;
            }
            else if (cbFilterBy.Text == "Is Available")
            {
                txtFilterValue.Visible = false;
                cbIsAvailable.Visible = true;
                cbIsDamaged.Visible = false;
                cbIsAvailable.Focus();
                cbIsAvailable.SelectedIndex = 0;
            }            
            else

            {

                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsAvailable.Visible = false;
                cbIsDamaged.Visible = false;
                //if (cbFilterBy.Text == "None")
                //{
                //    txtFilterValue.Enabled = false;
                //}
                //else
                //    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
        private void cbIsAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsAvailable";
            string FilterValue = cbIsAvailable.Text;

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
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            if (cbFilterBy.Text == "Copy ID")
            {
                FilterColumn = "BookCopyID";
            }
            else
            {
                FilterColumn = "ReservedForMemberID";
            }
            

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvBookCopies.Rows.Count.ToString();
                return;
            }


            
            _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            
            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void btnAddCopies_Click(object sender, EventArgs e)
        {
            frmInsertCopies frm = new frmInsertCopies(_BookID);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void cbIsDamaged_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsDamaged";
            string FilterValue = cbIsDamaged.Text;

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
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }
        
        private void btnAddCopies_Click_1(object sender, EventArgs e)
        {
            frmInsertCopies frm = new frmInsertCopies(_BookID);
            frm.ShowDialog();
            _RefreshDataGrid();

        }

        private void repairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepairBookCopy frm = new frmRepairBookCopy((int)dgvBookCopies.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void btnRepairCopy_Click(object sender, EventArgs e)
        {
            frmRepairBookCopy frm = new frmRepairBookCopy();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void cmBookCopies_Opening(object sender, CancelEventArgs e)
        {
            repairToolStripMenuItem.Enabled = (bool)dgvBookCopies.CurrentRow.Cells[4].Value;
        }
    }
}
