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

namespace LIbraryManagmentSystem.Members
{
    public partial class frmAddNewUpdateMember : Form
    {
        private int _memberID = -1;
        clsMember _member;
        float _paidFees = 0;
        clsMembershipCalss _membershipClassInfo;
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public frmAddNewUpdateMember()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddNewUpdateMember(int memberID)
        {
            InitializeComponent();
            _memberID = memberID;
            _Mode = enMode.Update;
        }
        private bool _FillMembershipClassesComboBox()
        {
            DataTable dt = clsMembershipCalss.GetAllMembershipClassess();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbMembershipClasess.Items.Add(dr[1]);
                }
                cbMembershipClasess.SelectedIndex = 0;
                return true;
            }
            return false;
            
        }
        private void _LoadData()
        {
            _member = clsMember.Find(_memberID);
            if (_member != null)
            {
                ctrlPersonInfo1.FillData(_member.PersonInfo);
                lblMemberID.Text = _memberID.ToString();
                lblCreatedByUser.Text = _member.CreatedByUserInfo.UserName;
                lblCreatedDate.Text = clsFormat.DateToShort(_member.CreatedDate);
                chkIsActive.Checked = _member.IsActive;
                lblMembershipID.Text = _member.MembershipInfo.MembershipID.ToString();
                lblMembershipCreatedByUserName.Text = _member.MembershipInfo.CreatedByUserInfo.UserName;
                cbMembershipClasess.Text = _member.MembershipInfo.MembershipClassInfo.Name;
                lblPaidFees.Text = _member.MembershipInfo.PaidFees.ToString();
                dtpStartDate.Value = _member.MembershipInfo.MembershipStartDate;
                dtpExpirationDate.Value = _member.MembershipInfo.MembershipExpirationDate;
            }
        }
        private void _HandlDateTimePickers()
        {
            dtpStartDate.Value = DateTime.Now;
            dtpStartDate.MinDate = DateTime.Now;

            DateTime EXPMinDate = DateTime.Now.AddDays(1).AddHours(1);
            dtpExpirationDate.MinDate = EXPMinDate;
            dtpExpirationDate.Value = EXPMinDate;

            
        }
        private bool _ResetDefaultValues()
        {
            
            if (!_FillMembershipClassesComboBox())
            {
                return false;
            }
            
            if (_Mode == enMode.Update)
            {
                _LoadData();
                gbMembershipInfo.Enabled = false;
                btnAddUpdate.Text = "Update";
                this.Text = "Update Member";
                lblTitle.Text = "Update Member";
            }
            else
            {
                _HandlDateTimePickers();
                _member = new clsMember();
                lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
                lblCreatedDate.Text = clsFormat.DateToShort(DateTime.Now);
                lblMembershipCreatedByUserName.Text = clsGlobal.CurrentUser.UserName;
                btnAddUpdate.Text = "Add";
                this.Text = "Add New Member";
                lblTitle.Text = "Add New Member";
            }
            return true;
        }
        private void frmAddNewUpdateMember_Load(object sender, EventArgs e)
        {           
            if (!_ResetDefaultValues())
            {
                this.Close();
                MessageBox.Show("You can't add member without membershipclass", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            _membershipClassInfo = clsMembershipCalss.Find(cbMembershipClasess.Text);

            if (_membershipClassInfo != null)
            {
                _paidFees = _membershipClassInfo.FeesPerDay * (dtpExpirationDate.Value.Subtract(DateTime.Now).Days);
                lblPaidFees.Text = _paidFees.ToString() + "$";
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (!ctrlPersonInfo1.Validate_Children())
            {
                MessageBox.Show("Some Fields are not valid; put the mouse over the read icon(s) to see the error","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _member.PersonInfo = ctrlPersonInfo1.PersonInfo;
            _member.IsActive = chkIsActive.Checked;
            if (_Mode == enMode.AddNew)
            {
                _member.CreatedDate = DateTime.Now;
                _member.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _member.MembershipInfo.MembershipClassID = _membershipClassInfo.ID;
                _member.MembershipInfo.MembershipStartDate = DateTime.Now;
                _member.MembershipInfo.MembershipExpirationDate = dtpExpirationDate.Value;
                _member.MembershipInfo.PaidFees = _paidFees;
                _member.MembershipInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }
            if (!_member.Save())
            {
                MessageBox.Show("Member are not save ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Mode == enMode.AddNew)
            {
                _Mode = enMode.Update;
                ctrlPersonInfo1.PersonID = _member.PersonID;
                ctrlPersonInfo1.Mode = (int)_Mode;
                lblMemberID.Text = _member.MemberID.ToString();
                lblMembershipID.Text = _member.MembershipInfo.MembershipID.ToString();
                this.Text = "Update Member";
                lblTitle.Text = "Update Member";
                btnAddUpdate.Text = "Update";
                gbMembershipInfo.Enabled = false;
                MessageBox.Show("Member is Added Sucessfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Member is Updated Sucessfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void frmAddNewUpdateMember_Activated(object sender, EventArgs e)
        {
            ctrlPersonInfo1.FirstNameTextBoxFocus();
        }

      
    }
}
;