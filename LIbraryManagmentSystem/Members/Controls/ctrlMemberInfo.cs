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

namespace LIbraryManagmentSystem.Members.Controls
{
    public partial class ctrlMemberInfo : UserControl
    {
        int _memberID = -1;
        clsMember _member;
        public ctrlMemberInfo()
        {
            InitializeComponent();
        }
        bool _LoadInfo()
        {
            _member = clsMember.Find(_memberID);
            ctrlPersonCard1.LoadInfo(_member.PersonID);
            lblMemberID.Text = _memberID.ToString();
            lblCreatedDate.Text = clsFormat.DateToShort(_member.CreatedDate);
            lblCreatedByUser.Text = _member.CreatedByUserInfo.UserName;
            lblNumberOFBorrowedBooks.Text = _member.GetNumberOFBorrowedBooks().ToString();
            lblIsActive.Text = _member.IsActive ? "Yes" : "No";
            ctrlMembershipInfo1.LoadInfo(_member.MemberID);
            llbUpdateInfo.Enabled = true;
            return true;
        }
        public bool LoadInfo(int memberID)
        {
            _memberID = memberID;
            _member = clsMember.Find(_memberID);
            if (_member == null)
            {
                llbUpdateInfo.Enabled=false; 
                return false;
            }
            return _LoadInfo();
        }
        public void ResetValues()
        {
            ctrlPersonCard1.ResetValues();
            lblMemberID.Text = "????";
            lblNumberOFBorrowedBooks.Text = "????";
            lblCreatedDate.Text = "????";
            lblCreatedByUser.Text = "????";
            ctrlMembershipInfo1.ResetValues();
        }
        public clsMember MemberInfo
        {
            get
            {
                return _member;
            }
        }

        private void llbUpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewUpdateMember frm = new frmAddNewUpdateMember(_memberID);
            frm.ShowDialog();
            _LoadInfo();
        }
    }
}
