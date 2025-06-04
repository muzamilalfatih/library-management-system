using LIbraryManagmentSystem.Global_Classes;
using LIbraryManagmentSystem.Memberships.Controls;
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

namespace LIbraryManagmentSystem.Authors.controls
{
    public partial class ctrlAuthorCard : UserControl
    {
        clsAuthor _author;
        public ctrlAuthorCard()
        {
            InitializeComponent();
        }
        public void ResetValues()
        {
            ctrlPersonCard1.ResetValues();
            lblAuthorID.Text = "????";
            lblCreatedDate.Text = "????";
        }
        bool _LoadInfo()
        {
            ctrlPersonCard1.LoadInfo(_author.PersonID);
            lblAuthorID.Text = _author.ID.ToString();
            lblCreatedDate.Text = clsFormat.DateToShort(_author.CreatedDate);
            llbUpdateInfo.Enabled= true;
            return true;
        }
        public bool LoadInfo(int authorID)
        {
            _author = clsAuthor.Find(authorID);
            if (_author == null)
            {
                llbUpdateInfo.Enabled = false;
                return false;
            }
            return _LoadInfo();
        }

        private void llbUpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewUpdateAuthor frm = new frmAddNewUpdateAuthor(_author.ID);
            frm.ShowDialog();
            _LoadInfo();
        }
    }
}
