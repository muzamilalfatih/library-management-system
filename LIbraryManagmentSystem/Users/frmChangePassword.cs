using LIbraryManagmentSystem.Global_Classes;
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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword( )
        {
            InitializeComponent();
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };

            if (clsGlobal.CurrentUser.Password != clsUtility.ComputeHash(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };
        }

        private void txtNewPasword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPasword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPasword, "New Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtNewPasword, null);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txtConfirmPassword.Text.Trim() != txtNewPasword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadInfo(clsGlobal.CurrentUser.UserID);

        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! put the cusor over the red icon to see the error", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to change password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (clsGlobal.CurrentUser.ChangePassword(clsUtility.ComputeHash(txtNewPasword.Text.Trim())))
                {
                    MessageBox.Show("Password changed successfuly!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Password was not changed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyUp_Validation(object sender, KeyEventArgs e)
        {
            btnSave.Enabled = txtCurrentPassword.Text != "" && txtNewPasword.Text != "" && txtConfirmPassword.Text != "";
        }

        private void frmChangePassword_Activated(object sender, EventArgs e)
        {
            txtCurrentPassword.Focus();
        }
    }
}
