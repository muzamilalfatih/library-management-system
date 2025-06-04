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

namespace LIbraryManagmentSystem.Memberships.Controls
{
    public partial class ctrlMembershipInfo : UserControl
    {
        clsMembership _membership;
        public ctrlMembershipInfo()
        {
            InitializeComponent();
        }
        bool _LoadInfo()
        {
            lblMembershipID.Text = _membership.MembershipID.ToString();
            lblMembershipclass.Text = _membership.MembershipClassInfo.Name;
            lblPaidFees.Text = _membership.PaidFees.ToString();
            lblStartDate.Text = clsFormat.DateToShort(_membership.MembershipStartDate);
            lblExpirationDate.Text = clsFormat.DateToShort(_membership.MembershipExpirationDate);
            lblCreatedByUser.Text = _membership.CreatedByUserInfo.UserName;
            return true;
        }
        public bool LoadInfo(int memberID)
        {           
            _membership = clsMembership.FindByMemberID(memberID);
            if (_membership == null)
            {
                return false;
            }
            return _LoadInfo();
        }
        public void ResetValues()
        {
            lblMembershipID.Text = "????";
            lblMembershipclass.Text = "????";
            lblPaidFees.Text = "????";
            lblStartDate.Text = "????";
            lblExpirationDate.Text = "????";
            lblCreatedByUser.Text = "????";
        }
    }
}
