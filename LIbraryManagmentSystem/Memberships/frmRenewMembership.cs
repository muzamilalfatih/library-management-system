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

namespace LIbraryManagmentSystem.Memberships
{
    public partial class frmRenewMembership : Form
    {

        clsMembership _oldMembership;
        clsMembership _newMembership;
        int _memberID = -1;
        int _newMembershipID = -1;
        private clsMembershipCalss _membershipClassInfo;
        private float _paidFees;

        public frmRenewMembership()
        {
            InitializeComponent();
        }
        public frmRenewMembership(int memberID)
        {
            InitializeComponent();
            _memberID = memberID;   
        }
        void _FillMembershipClassesComboBox()
        {
            DataTable dt = clsMembershipCalss.GetAllMembershipClassess();
            foreach (DataRow dr in dt.Rows)
            {
                cbMembershipClasess.Items.Add(dr[1]);
            }
            cbMembershipClasess.SelectedIndex = 0;
        }
        void _HandleDateTimePickers()
        {
            dtpStartDate.Value = DateTime.Now;
            dtpStartDate.MinDate = DateTime.Now;

            DateTime EXPMinDate = DateTime.Now.AddDays(1).AddHours(1);
            dtpExpirationDate.MinDate = EXPMinDate;
            dtpExpirationDate.Value = EXPMinDate;
        }
        void _ResetDefaultValues()
        {
            _FillMembershipClassesComboBox();
            _HandleDateTimePickers();

            lblMembershipCreatedByUserName.Text = clsGlobal.CurrentUser.UserName;
        }
        private void frmRenewMembership_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_memberID != -1)
            {
                ctrlMembershipInfoWithFilter1.Search(_memberID);
            }
        }

        void _FillNewMembershipWithData()
        {
            _newMembership = new clsMembership();
            _newMembership.MemberID = _memberID;
            _newMembership.MembershipClassID = _membershipClassInfo.ID;
            _newMembership.MembershipStartDate = DateTime.Now;
            _newMembership.MembershipExpirationDate = dtpExpirationDate.Value;
            _newMembership.PaidFees = _paidFees;
            _newMembership.CreatedByUserID = clsGlobal.CurrentUser.UserID;
        }
        private void ctrlMembershipInfoWithFilter1_OnMembershipSelected(int obj)
        {
            _memberID = obj;
            if (_memberID == -1)
            {
                gbMembershipInfo.Enabled = false;
                btnRenew.Enabled = false;
                MessageBox.Show("No membership found!","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _oldMembership = clsMembership.FindByMemberID(_memberID);
            if (_oldMembership == null)
            {
                return;
            }

            if (_oldMembership.MembershipExpirationDate > DateTime.Now)
            {
                MessageBox.Show($"This member has an active membership with classs {_oldMembership.MembershipClassInfo.Name}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _membershipClassInfo = clsMembershipCalss.Find(cbMembershipClasess.Text);
            if (_membershipClassInfo != null)
            {
                _paidFees = _membershipClassInfo.FeesPerDay;
                lblPaidFees.Text = _paidFees.ToString() + "$";
            }
            gbMembershipInfo.Enabled = true;
            btnRenew.Enabled = true;
        }

        private void dtpExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            if (_membershipClassInfo != null)
            {
                _paidFees = _membershipClassInfo.FeesPerDay * (dtpExpirationDate.Value.Subtract(DateTime.Now).Days);
                lblPaidFees.Text = _paidFees.ToString() + "$";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
             _FillNewMembershipWithData();

            if (_newMembership.Save())
            {
                gbMembershipInfo.Enabled = false;
                btnRenew.Enabled = false;
                ctrlMembershipInfoWithFilter1.LoadInfo(_memberID);
                MessageBox.Show("Rewed successfully!", "Successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to renew!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRenewMembership_Activated(object sender, EventArgs e)
        {
            ctrlMembershipInfoWithFilter1.MemberIDFocus();
        }

        private void cbMembershipClasess_SelectedIndexChanged(object sender, EventArgs e)
        {
            _membershipClassInfo = clsMembershipCalss.Find(cbMembershipClasess.Text);
            if (_membershipClassInfo != null)
            {
                _paidFees = _membershipClassInfo.FeesPerDay;
                lblPaidFees.Text = _paidFees.ToString() + "$";
            }
        }
    }
}
