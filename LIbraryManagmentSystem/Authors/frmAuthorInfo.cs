using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.Authors
{
    public partial class frmAuthorInfo : Form
    {
        int _authorID = -1;
        public frmAuthorInfo(int auhtorID)
        {
            InitializeComponent();
            _authorID = auhtorID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAuthorInfo_Load(object sender, EventArgs e)
        {
            ctrlAuthorCard1.LoadInfo(_authorID);
        }

        private void llbUpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewUpdateAuthor frm = new frmAddNewUpdateAuthor(_authorID);
            frm.ShowDialog();
            ctrlAuthorCard1.LoadInfo(_authorID);
        }
    }
}
