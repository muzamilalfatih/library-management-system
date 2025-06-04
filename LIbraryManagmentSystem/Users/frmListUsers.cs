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

namespace LIbraryManagmentSystem.Users
{
    public partial class frmListUsers : Form
    {
        private static DataTable _dtAllUsers;
        private void _RefreshDataGrid()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
            if (_dtAllUsers.Rows.Count == 0)
            {
                return;
            }
            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[0].Width = 110;

            //dgvUsers.Columns[1].HeaderText = "Person ID";
            //dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[1].HeaderText = "Full Name";
            dgvUsers.Columns[1].Width = 250;

            dgvUsers.Columns[2].HeaderText = "UserName";
            dgvUsers.Columns[2].Width = 80;

            dgvUsers.Columns[3].HeaderText = "UserRoles";
            dgvUsers.Columns[3].Width = 80;

            dgvUsers.Columns[4].HeaderText = "Is Active";
            dgvUsers.Columns[4].Width = 50;
        }
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
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
            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateUser frm = new frmAddNewUpdateUser();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateUser frm = new frmAddNewUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if ( MessageBox.Show("Are you sure you want to delete this user?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                 == DialogResult.Yes)
            {
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("User was not deleted because data linked with it", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implemented yet!", "Not Implemented", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            return;
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implemented yet!", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
