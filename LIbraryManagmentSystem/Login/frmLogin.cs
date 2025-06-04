using LIbraryManagmentSystem.Global_Classes;
using LIbraryManagmentSystem.Users;
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

namespace LIbraryManagmentSystem
{
    public partial class frmLogin : Form
    {
        private clsUser _CurrentUser;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username can't be blank");
              
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            };
        }

        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
            {

                errorProvider1.SetError(txtpassword, "password can't be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtpassword, null);
            };
        }
        public void RefreshObject(clsUser user)
        {
            _CurrentUser = user;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields were not valid,put the mouse over the red icon to see the error",
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_CurrentUser == null || _CurrentUser.UserName != txtUsername.Text.Trim())
            {
                _CurrentUser = clsUser.Find(txtUsername.Text.Trim());
            }
            
            if (_CurrentUser == null)
            {
                MessageBox.Show("There is no user with this user name!","Not Found",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            if (_CurrentUser.Password != clsUtility.ComputeHash(txtpassword.Text.Trim()))
            {
                MessageBox.Show("Wrong Password!","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!_CurrentUser.IsActive)
            {
                MessageBox.Show("Your account is Invactive, Contact your admin", "InActive Account!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            if (chkRememberMe.Checked)
            {
                clsUtility.RememberUsernameAndPassword(txtUsername.Text.Trim(), clsUtility.Encrypt(txtpassword.Text.Trim(),clsGlobal.encryptipnKey));
            }
            else
            {
                clsUtility.RememberUsernameAndPassword("", "");
                txtUsername.Text = "";
                txtpassword.Text = "";
                
            }
            clsGlobal.refreshObject = RefreshObject;
            clsGlobal.CurrentUser = _CurrentUser;
            frmMain frm = new frmMain(this);
            frm.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string userName = "", password= "";
            clsUtility.GetStoredCredential(ref userName,ref password);
            txtUsername.Text = userName;
            txtpassword.Text = clsUtility.Decrypt(password,clsGlobal.encryptipnKey);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtpassword.PasswordChar = (char)0;
                chkShowPassword.Text = "Hide";
            }
            else
            {
                txtpassword.PasswordChar = '*';
                chkShowPassword.Text = "Show";
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (txtUsername.Text != "")
            {
                clsGlobal.refreshObject = RefreshObject;
                clsGlobal.CurrentUser = _CurrentUser;
                frmRestPassword frm = new frmRestPassword(txtUsername.Text.Trim(), this);
                frm.ShowDialog();
            }
            else
            {
                frmRestPassword frm = new frmRestPassword(this);
                frm.ShowDialog();
            }
        }

        
    }
}
