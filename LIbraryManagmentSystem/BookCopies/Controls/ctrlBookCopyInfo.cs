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

namespace LIbraryManagmentSystem.BookCopies.Controls
{
    public partial class ctrlBookCopyInfo : UserControl
    {
        clsBookCopy _bookCopy;
        public ctrlBookCopyInfo()
        {
            InitializeComponent();
        }
        void _ResetDefaultValues()
        {
            ctrlBookInfo1.ResetValues();
            lblCopyID.Text = "????";
            lblIsAvailable.Text = "????";
            lblIsDamaged.Text = "????";
            lblReservedForMemberID.Text = "????";
        }
        bool _LoadInfo()
        {
            ctrlBookInfo1.LoadBookInfo(_bookCopy.BookID);
            lblCopyID.Text = _bookCopy.BookCopyID.ToString();
            lblIsAvailable.Text = _bookCopy.IsAvailable ? "Yes" : "NO";
            lblIsDamaged.Text = _bookCopy.IsDamaged ? "Yes" : "No";
            lblReservedForMemberID.Text = _bookCopy.ReservedForMemberID != -1 ? _bookCopy.ReservedForMemberID.ToString() : "None";
            return true; 
        }

        public bool LoadCopyInfo(int BookCopyID)
        {
            _bookCopy = clsBookCopy.Find(BookCopyID);
            if (_bookCopy == null )
            {
                _ResetDefaultValues();
                return false;
            }
            return _LoadInfo();
        }
        public clsBookCopy CopyInfo
        {
            get
            {
                return _bookCopy;
            }
        }
        public string IsDamagedText
        {
            set
            {
                lblIsDamaged.Text = value.ToString();
            }
        }
    }
}
