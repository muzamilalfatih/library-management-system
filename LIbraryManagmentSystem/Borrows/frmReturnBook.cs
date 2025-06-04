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

namespace LIbraryManagmentSystem.Borrows
{
    
    public partial class frmReturnBook : Form
    {
        int _borrowID = -1;
        int _copyID = -1;
        
        public frmReturnBook()
        {
            InitializeComponent();
        }
        public frmReturnBook(int copyID)
        {
            InitializeComponent();
            this._copyID = copyID;
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlBorrowInfoWithFilter1_OnBorrowSelected(int obj)
        {
            _borrowID = obj;
            if (_borrowID == -1)
            {
                MessageBox.Show($"No Borrow Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnDate.HasValue)
            {
                MessageBox.Show($"This book is already returned in date {clsFormat.DateToShort((DateTime) ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnDate)}", "Already Returned", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                this.Close();
                return;
            }
            btnReturn.Enabled = true;
        }
        void _HandleAvailableReservationForMember()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Availabe";
            notifyIcon1.BalloonTipText = "The book is available! please pick it up with in three days ";
            notifyIcon1.ShowBalloonTip(1000);

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Som fields are not valide; put the mouse over the red icon(s) to see the error",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnDate.HasValue)
            {
                MessageBox.Show($"This book is already returned in date {clsFormat.DateToShort((DateTime)ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnDate)}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnNotes = txtReturnNote.Text;
            ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnDate = DateTime.Now;
            ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnedByUserID = clsGlobal.CurrentUser.UserID;
            ctrlBorrowInfoWithFilter1.BorrowInfo.IsDamaged = chkIsDamaged.Checked;
            if (ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnBook())
            {
                lblReturnFees.Text = ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnFees.ToString();
                lblReturnDate.Text = clsFormat.DateToShort((DateTime) ctrlBorrowInfoWithFilter1.BorrowInfo.ReturnDate);
                lblReturnedByUser.Text = clsGlobal.CurrentUser.UserName;
                if (ctrlBorrowInfoWithFilter1.BorrowInfo.ReservedForMemberID != -1)
                {
                _HandleAvailableReservationForMember();
                }
                MessageBox.Show("The book retured successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReturn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error occur while returning the book", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtReturnNote_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((txtReturnNote.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtReturnNote, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtReturnNote, "");
            }
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {
            lblReturnDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblReturnedByUser.Text = clsGlobal.CurrentUser.UserName;
            if (_copyID != -1)
            {
                ctrlBorrowInfoWithFilter1.DisableFilte();
                ctrlBorrowInfoWithFilter1.Search(_copyID);
            }
        }
    }
}
