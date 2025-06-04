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
    public partial class frmUserInfo : Form
    {
        int _userID;
        public frmUserInfo()
        {
            InitializeComponent();
        }
        public frmUserInfo(int userID)
        {
            InitializeComponent();
            this._userID = userID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadInfo(_userID);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewUpdateUser frm = new frmAddNewUpdateUser(_userID);
            frm.ShowDialog();
            ctrlUserCard1.LoadInfo(_userID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
