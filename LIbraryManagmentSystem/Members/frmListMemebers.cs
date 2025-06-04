using LIbraryManagmentSystem.Borrows;
using LIbraryManagmentSystem.Memberships;
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

namespace LIbraryManagmentSystem.Members
{
    public partial class frmListMemebers : Form
    {
        private static DataTable _dtAllMembers;
        public frmListMemebers()
        {
            InitializeComponent();
        }
        private void _RefreshDataGrid()
        {
            _dtAllMembers = clsMember.GetAllMembers();
            dgvMembers.DataSource = _dtAllMembers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvMembers.Rows.Count.ToString();
            if (_dtAllMembers.Rows.Count == 0)
            {
                return;
            }
            dgvMembers.Columns[0].HeaderText = "Member ID";
            dgvMembers.Columns[0].Width = 80;

            dgvMembers.Columns[1].HeaderText = "Full Name";
            dgvMembers.Columns[1].Width = 250;

            dgvMembers.Columns[2].HeaderText = "Membership Start Date";
            dgvMembers.Columns[2].Width = 120;

            dgvMembers.Columns[3].HeaderText = "Membership End Date";
            dgvMembers.Columns[3].Width = 120;

            dgvMembers.Columns[4].HeaderText = "Membership Class Name";
            dgvMembers.Columns[4].Width = 150;
            dgvMembers.Columns[5].HeaderText = "Total Borrowed Books";
            dgvMembers.Columns[5].Width = 150;

            dgvMembers.Columns[6].HeaderText = "Is Active";
            dgvMembers.Columns[6].Width = 80;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmListMemebers_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateMember frm = new frmAddNewUpdateMember();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else

            {

                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

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

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Member ID":
                    FilterColumn = "MemberID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Membership Class Name":
                    FilterColumn = "MembershipClassName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllMembers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllMembers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "MemberID" )
                //in this case we deal with numbers not string.
                _dtAllMembers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllMembers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllMembers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text== "Member ID")
            {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateMember frm = new frmAddNewUpdateMember();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateMember frm = new frmAddNewUpdateMember((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)
                 == DialogResult.No)
            {
                return;
            }

           if (clsMember.DeleteMember((int)dgvMembers.CurrentRow.Cells[0].Value))
           {
                MessageBox.Show("Member is  Deleted Successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
                MessageBox.Show("Member is not deleted;Because data linked with him!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberInfo frm = new frmMemberInfo((int)dgvMembers.CurrentRow.Cells[0].Value );
            frm.ShowDialog();
        }

        private void renewMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewMembership frm = new frmRenewMembership((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void BorrowABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowBook frm = new frmBorrowBook((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void btnAddNewMemeber_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateMember frm = new frmAddNewUpdateMember();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void cmMembers_Opening(object sender, CancelEventArgs e)
        {
            bool _IsMemberShipActive = ((DateTime)dgvMembers.CurrentRow.Cells[3].Value > DateTime.Now);
            renewMembershipToolStripMenuItem.Enabled = !_IsMemberShipActive && (bool)dgvMembers.CurrentRow.Cells[6].Value;
            BorrowABookToolStripMenuItem.Enabled = _IsMemberShipActive && (bool)dgvMembers.CurrentRow.Cells[6].Value; ;
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

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
                _dtAllMembers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllMembers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtAllMembers.Rows.Count.ToString();
        }
    }
}
