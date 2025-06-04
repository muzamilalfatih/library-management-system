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
    public partial class frmRestPassword : Form
    {
        clsUser _user;
        string _userName = "";
        frmLogin _frmlogin;
        int _time = 60;
        int _sentCode = 0;
        public frmRestPassword(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmlogin = frmLogin;
        }
        public frmRestPassword(string userName, frmLogin frmLogin)
        {
            InitializeComponent();
            _userName = userName;
            _frmlogin = frmLogin;
        }

        private void frmRestPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmlogin.Show();
            this.Close();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Usernaem Can't be blank!");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int _GetRandomCode()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999);
        }
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            
            if (_user !=null && txtUsername.Text == _user.UserName)
            {
                return;
            }
            _user = clsUser.Find(txtUsername.Text.Trim());
            if  (_user == null )
            {
                timer1.Stop();
                _time = 60;
                lblValideFor.Text = _time.ToString();
                MessageBox.Show("Not user with this user name","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _sentCode = _GetRandomCode();
            _user.PersonInfo.SendEmail($"The reset code is {_sentCode}", "Verivication Code");
            lblRestEmail.Text = $"    {_user.PersonInfo.Email.Substring(0, 3)}*****{_user.PersonInfo.Email.Substring(_user.PersonInfo.Email.Length - 10)}";
            txtTheResetCode.Enabled = true;
            btnResetCode.Enabled = true;
            
            _time = 60;
            lblValideFor.Text = _time.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _time--;
            lblValideFor.Text = _time.ToString();

            if (_time == 0)
            {
            btnResendCode.Enabled = true;
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_time == 0)
            {
                btnResendCode.Enabled = true;
                MessageBox.Show("The code is unvalide","Not Valide",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (_sentCode.ToString() != txtTheResetCode.Text)
            {
                MessageBox.Show("Invalide Code!", "Not Valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnFind.Enabled = false;
            txtUsername.Enabled = false;
            btnResendCode.Enabled = false;
            btnResetCode.Enabled = false;
            txtTheResetCode.Enabled = false;

            timer1.Stop();
            txtNewPasword.Enabled = true;
            txtConfirmPassword.Enabled = true;
            btnReset.Enabled = true;
           
        }

        private void btnResendCode_Click(object sender, EventArgs e)
        {
            _time = 60;
            _sentCode = _GetRandomCode();
            btnResendCode.Enabled = false;
            timer1.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valide;put the mouse over the red icon to see the error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_user.ChangePassword(clsUtility.ComputeHash(txtNewPasword.Text.Trim())))
            {
                MessageBox.Show("Password Reset Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsGlobal.refreshObject?.Invoke(null);
            }
            else
            {
                MessageBox.Show("Failed to rest password!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void frmRestPassword_Load(object sender, EventArgs e)
        {
            if (_userName != "")
            {
                txtUsername.Text = _userName;
                btnFind_Click(null,null);
            }
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            btnFind.Enabled = txtUsername.Text != "";
        }
    }
}
