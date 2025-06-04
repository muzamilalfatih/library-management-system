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
    public partial class frmMemberInfo : Form
    {
        int _memberID;
        public frmMemberInfo()
        {
            InitializeComponent();
        }
        public frmMemberInfo(int memberID)
        {
            InitializeComponent();
            _memberID = memberID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberInfo_Load(object sender, EventArgs e)
        {
            if (!ctrlMemberInfo1.LoadInfo(_memberID))
            {

                MessageBox.Show("Member was not found","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void llbUpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewUpdateMember frm = new frmAddNewUpdateMember(_memberID);
            frm.ShowDialog();
            ctrlMemberInfo1.LoadInfo(_memberID);
        }
    }
}
