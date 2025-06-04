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
    public partial class ctrlUserCard : UserControl
    {
        private clsUser _User;
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        public void LoadInfo (int UserID)
        {
            _User = clsUser.Find(UserID);
            if (_User !=  null)
            {
                ctrlPersonCard1.LoadInfo(_User.PersonID);
                lblUserID.Text = _User.UserID.ToString();
                lblUserName.Text = _User.UserName;
                lblIsActive.Text = _User.IsActive ? "Yes" : "False";
                lblRole.Text = _User.UserRoleText();
                llbUpdateInfo.Enabled = true;
            }
            else
            {
                llbUpdateInfo.Enabled = false;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewUpdateUser frm = new frmAddNewUpdateUser(_User.UserID);
            frm.ShowDialog();
            LoadInfo(_User.UserID);
        }
    }
}
