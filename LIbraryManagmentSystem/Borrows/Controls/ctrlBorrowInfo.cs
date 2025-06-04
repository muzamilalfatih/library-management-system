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

namespace LIbraryManagmentSystem.Borrows.Controls
{
    public partial class ctrlBorrowInfo : UserControl
    {
        clsBorrow _borrow;
        public ctrlBorrowInfo()
        {
            InitializeComponent();
        }
        void _ResetDefaultValues()
        {
            lblBorrowID.Text = "????";
            lblMemberID.Text = "????";
            lblPaidFees.Text = "????";
            lblBorrowDate.Text = "????";
            lblDueDate.Text = "????";
            lblCreatedbyUser.Text = "????";
        }
        bool _LoadInfo()
        {
            lblBorrowID.Text = _borrow.BorrowID.ToString();
            lblMemberID.Text = _borrow.MemberID.ToString();
            lblPaidFees.Text = _borrow.PaidFees.ToString();
            lblBorrowDate.Text = clsFormat.DateToShort(_borrow.BorrowDate);
            lblDueDate.Text = clsFormat.DateToShort(_borrow.DueDate);
            lblCreatedbyUser.Text = clsUser.Find(_borrow.CreatedByUserID).UserName;
            return true;
        }
        public bool LoadInfo(int copyID)
        {
            _borrow = clsBorrow.FindByCopyID(copyID);
            if ( _borrow == null )
            {
                _ResetDefaultValues();
                return false;
            }
            return _LoadInfo();
        }
        public clsBorrow BorrowInfo
        {
            get
            {
                return _borrow;
            }
        }
    }
}
