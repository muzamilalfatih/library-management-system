using LIbraryManagmentSystem.Global_Classes;
using LIbraryManagmentSystem.Properties;
using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.Users
{
    public partial class frmAddNewUpdateUser : Form
    {


        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _UserID = -1;
        private clsUser _User;

        public frmAddNewUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddNewUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void _LoadDate()
        {

            ctrlPersonInfo1.FillData(_User.PersonInfo);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            rbAdim.Checked = _User.UserRole == clsUser.enUserRole.Admin;
            rbLibrarain.Checked = !rbAdim.Checked;
            chkIsActive.Checked = _User.IsActive;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren() || !ctrlPersonInfo1.Validate_Children())
            {
                MessageBox.Show("Some fields were not valid!,put the mouse over the red icon to see the error"
                    ,"Validation Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                       
            _User.PersonInfo = ctrlPersonInfo1.PersonInfo;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text != "" ? clsUtility.ComputeHash(txtPassword.Text) : _User.Password;
            _User.UserRole = rbAdim.Checked ? clsUser.enUserRole.Admin : clsUser.enUserRole.Librarian;
            _User.IsActive = chkIsActive.Checked;

            if ( (_User.UserRole == clsUser.enUserRole.Librarian || !_User.IsActive) && !clsUser.IsThereOtherAdmins(_User.UserID))
            {
                MessageBox.Show("At leaste must be One active admin in the system"
                   , "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_User.Save())
            {
                this.Text = "Update User";
                btnAddUpdate.Image = Resources.Update_32;
                ctrlPersonInfo1.PersonID = _User.PersonID;
                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                ctrlPersonInfo1.Mode = (int)_Mode;
                if (clsGlobal.CurrentUser.UserID == _User.UserID)
                {
                    clsGlobal.CurrentUser = _User;
                    clsGlobal.refreshObject?.Invoke(_User);
                }

                rbAdim.Enabled =  !(_Mode == enMode.Update && clsGlobal.CurrentUser.UserRole == clsUser.enUserRole.Librarian);
                rbLibrarain.Enabled = rbAdim.Enabled;
                chkIsActive.Enabled = rbAdim.Enabled;
                MessageBox.Show("Data saved successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data was not saved!", "Faile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void _ResetDefaultValues()
        {
            ctrlPersonInfo1.Mode = (int)_Mode;
            if (_Mode == enMode.Update)
            {
                _User = clsUser.Find(_UserID);
                if (_User == null)
                {
                    MessageBox.Show("User was not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnAddUpdate.Enabled = false;
                    return;
                }
                
                
                _LoadDate();
                rbAdim.Enabled = clsGlobal.CurrentUser.UserRole == clsUser.enUserRole.Admin;
                rbLibrarain.Enabled = rbAdim.Enabled;
                chkIsActive.Enabled = rbAdim.Enabled;
                btnAddUpdate.Text = "Update";
                btnAddUpdate.Image = Resources.Update_32;
                btnAddUpdate.Enabled = true;
            }
            else
            {
                this.Text = "Add New User";
                btnAddUpdate.Image = Resources.Add_32;
                _User = new clsUser();
                btnAddUpdate.Enabled = true;
            }
        }

        private void frmAddNewUpdateUser_Load(object sender, EventArgs e)
            
        {
            _ResetDefaultValues();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                
                errorProvider1.SetError(txtPassword, "Password can't be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                
                errorProvider1.SetError(txtConfirmPassword, "Password can't be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
               
                errorProvider1.SetError(txtConfirmPassword, "The two passowrds don't match!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private void txtUserName_Validating_1(object sender, CancelEventArgs e)
        {           

            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (_Mode == enMode.AddNew && clsUser.IsUserExsit(txtUserName.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "username is used by another user");


            }           
            else if (_Mode == enMode.Update && _User.UserName != txtUserName.Text.Trim() && clsUser.IsUserExsit(txtUserName.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "username is used by another user");
                return;


            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };
        }

        private void frmAddNewUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonInfo1.FirstNameTextBoxFocus();
        }
    }
}
