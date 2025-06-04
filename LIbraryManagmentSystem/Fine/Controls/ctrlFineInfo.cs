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

namespace LIbraryManagmentSystem.Fine
{
    public partial class ctrlFineInfo : UserControl
    {
        clsFine _fine;
        
        public ctrlFineInfo()
        {
            InitializeComponent();
        }
        void _ResetDefaultValues()
        {
            lblFineID.Text = "????";
            lblMemberID.Text = "????";
            lblMemberID.Text = "????";
            lblFineAmount.Text = "????";
            lblFineDate.Text = "????";
            lblReason.Text = "????";
            lblPaidAmount.Text = "????";
        }
        bool _LoadInfo()
        {
            lblFineID.Text = _fine.FineID.ToString();
            lblMemberID.Text = _fine.MemberID.ToString();
            lblBorrowID.Text = _fine.BorrowID.ToString();
            lblFineAmount.Text = _fine.FineAmount.ToString();
            lblFineDate.Text = clsFormat.DateToShort(_fine.FineDate);
            lblReason.Text = _fine.GetReasonText;
            lblPaidAmount.Text = _fine.PaidAmount.ToString();
            return true;
        }
        public bool LoadInfo(int FineID)
        {
            _fine = clsFine.Find(FineID);
            if (_fine == null)
            {
                _ResetDefaultValues();
                return false;
            }
            return _LoadInfo();
        }
        public clsFine FineInfo
        {
            get
            {
                return _fine;
            }
        }
    }
}
