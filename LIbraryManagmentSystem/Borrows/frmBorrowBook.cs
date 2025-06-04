using LIbraryManagmentSystem.Global_Classes;
using LIbraryManagmentSystem.Reservations;
using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.Borrows
{
    public partial class frmBorrowBook : Form
    {
        int _memberID = -1;
        int _bookID = -1;
        float _paidFees = 0;
        clsBorrow _borrow;
        public frmBorrowBook()
        {
            InitializeComponent();
        }
        public frmBorrowBook(int memberID, int bookID)
        {
            InitializeComponent();
            this._memberID = memberID;
            this._bookID = bookID;
        }
        public frmBorrowBook(int memberID)
        {
            InitializeComponent();
            _memberID = memberID;
        }
        void _HandleDateTimePickers()
        {
            dtpFrom.Value = DateTime.Now;
            dtpFrom.MinDate = DateTime.Now;

            DateTime EXPMinDate = DateTime.Now.AddDays(1);
            dtpDuteTo.MinDate = EXPMinDate;
            dtpDuteTo.Value = EXPMinDate;
        }
        private void frmBorrowBook_Load(object sender, EventArgs e)
        {
            tcBookInfo.Enabled = false;
            _HandleDateTimePickers();
            if (_memberID != -1 && _bookID ==-1)
            {
                ctrlMemberInfoWithFilter1.Search(_memberID);
            }
            if (_memberID != -1 && _bookID != -1)
            {
                ctrlMemberInfoWithFilter1.Search(_memberID);
                ctrlMemberInfoWithFilter1.DisableFilte();
                ctrlBookInfoWithFilter1.Search(_bookID);
                ctrlBookInfoWithFilter1.DisableFilte();
            }
        }
        bool _HandleMemberCriteria()
        {
            if (!ctrlMemberInfoWithFilter1.MemberInfo.IsActive)
            {
                tcBookInfo.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("Your account is InActive!", "InActive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ctrlMemberInfoWithFilter1.MemberInfo.HasUnpaidFine())
            {
                MessageBox.Show("Your Membership was Deactivated;Due to Fine claims!", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!ctrlMemberInfoWithFilter1.MemberInfo.HasActiveMembership())
            {
                tcBookInfo.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("This member does not have an active membership, please renew the member ship and try again", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ctrlMemberInfoWithFilter1.MemberInfo.GetNumberOFBorrowedBooks() >= ctrlMemberInfoWithFilter1.MemberInfo.MembershipInfo.MembershipClassInfo.MaxNumberOfBookCanBorrow)
            {
                tcBookInfo.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("This member has achive his max number of book can borrow wiht his membership class!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ctrlMemberInfoWithFilter1_OnMemberSelected(int obj)
        {
            _memberID = obj;
            if (_memberID == -1)
            {
                MessageBox.Show($"No member Found!","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error );
                return;
            }
           if (!_HandleMemberCriteria())
            {
                return;
            }
            btnNext.Enabled = true;          
        }
        private void ctrlBookInfoWithFilter1_OnBookSelected(int obj)
        {
            _bookID = obj;
            if ( _bookID == -1 )
            {
                MessageBox.Show("No book Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _paidFees = ctrlBookInfoWithFilter1.BookInfo.BorrowFees;
            lblBorrowFees.Text = _paidFees.ToString();
            chkHasReservation.Checked = ctrlMemberInfoWithFilter1.MemberInfo.DoesHasActiveReservationForBookID(ctrlBookInfoWithFilter1.BookInfo.BookID); 
            if (chkHasReservation.Checked )
            {
                if (ctrlMemberInfoWithFilter1.MemberInfo.IsReservationAvailable(ctrlBookInfoWithFilter1.BookInfo.BookID))
                {
                    MessageBox.Show("The book is aviable for you please borrow it!", "Availbale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbBorrowInfromation.Enabled = true;
                    btnBorrow.Enabled = true;
                }
                else
                {
                    btnBorrow.Enabled = false;
                    gbBorrowInfromation.Enabled = false;
                    MessageBox.Show("The book is not availbale yet!","Not Availbale",MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }
                return;
            }
            if (!ctrlBookInfoWithFilter1.BookInfo.IsAvaiable())
            {
                if (MessageBox.Show("This book is checked out! Do you want to reserve it?", "Checked Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)
                    == DialogResult.Yes)
                {
                    frmReserveBook frm = new frmReserveBook(_memberID, _bookID);
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            gbBorrowInfromation.Enabled = true;
            btnBorrow.Enabled = true;
            
        }

        private void dtDuteTo_ValueChanged(object sender, EventArgs e)
        {
            if (ctrlBookInfoWithFilter1.BookInfo != null)
            {
                _paidFees += ctrlBookInfoWithFilter1.BookInfo.BorrowFees * (dtpDuteTo.Value.Subtract(DateTime.Now).Days);
                lblBorrowFees.Text = _paidFees.ToString() + "$";
            }
            
        }
        
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue this book?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!_HandleMemberCriteria())
                {
                    return;
                }

                if (!ctrlBookInfoWithFilter1.BookInfo.IsAvaiable() && !chkHasReservation.Checked)
                {
                    if (MessageBox.Show("This book is checked out! Do you want to reserve it?", "Checked Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    == DialogResult.Yes)
                    {
                        frmReserveBook frm = new frmReserveBook(_memberID, _bookID);
                        frm.ShowDialog();
                        this.Close();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                 _borrow = new clsBorrow();
                _borrow.MemberID = _memberID;
                _borrow.BorrowDate = dtpFrom.Value;
                _borrow.DueDate = dtpDuteTo.Value;
                _borrow.BookID = _bookID;
                _borrow.HasReserrvation = chkHasReservation.Checked;
                _borrow.PaidFees = _paidFees;
                _borrow.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                if (_borrow.Save())
                {
                    btnBorrow.Enabled = !chkHasReservation.Checked;
                    lblBorrowID.Text = _borrow.BorrowID.ToString();
                    lblCopyID.Text = _borrow.copyID.ToString();
                    MessageBox.Show("Book Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to issued book!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcBookInfo.Enabled = true;
            tabControl1.SelectedTab = tabControl1.TabPages["tcBookInfo"];
        }

        private void frmBorrowBook_Activated(object sender, EventArgs e)
        {
            ctrlMemberInfoWithFilter1.FilterValueFocus();
        }
    }
}
