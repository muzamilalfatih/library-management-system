using LIbraryManagmentSystem.Borrows;
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

namespace LIbraryManagmentSystem.Reservations
{
    public partial class frmReserveBook : Form
    {
        int _memberID = -1;
        int _bookID = -1;
        clsReservation _reservation;
        public frmReserveBook()
        {
            InitializeComponent();
        }
        public frmReserveBook(int memberID, int bookID)
        {
            InitializeComponent();
            this._memberID = memberID;
            this._bookID = bookID;
        }
        private void frmReserveBook_Load(object sender, EventArgs e)
        {
            tcBookInfo.Enabled = false;
            lblReservationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUserID.Text = clsGlobal.CurrentUser.UserName;
            if (_memberID != -1 && _bookID != -1)
            {
                ctrlMemberInfoWithFilter1.Search(_memberID);
                ctrlMemberInfoWithFilter1.DisableFilte();
                ctrlBookInfoWithFilter1.Search(_bookID);
                ctrlBookInfoWithFilter1.DisableFilte();
            }
        }
        bool _HandleMemberCritera()
        {
            if (!ctrlMemberInfoWithFilter1.MemberInfo.IsActive)
            {
                MessageBox.Show("Your account is InActive!", "InActive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ctrlMemberInfoWithFilter1.MemberInfo.HasUnpaidFine())
            {
                MessageBox.Show("You Membership was Deactivated;Due to Fine claims!", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!ctrlMemberInfoWithFilter1.MemberInfo.HasActiveMembership())
            {
                tcBookInfo.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("This member does not have an active membership, please renew the membership and try again", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ctrlMemberInfoWithFilter1.MemberInfo.GetNumberOFBorrowedBooks() >= ctrlMemberInfoWithFilter1.MemberInfo.MembershipInfo.MembershipClassInfo.MaxNumberOfBookCanBorrow)
            {
                tcBookInfo.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("This member has achive his max number of book  wiht his membership class!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        bool _HandleBookCoditions()
        {
            if (ctrlBookInfoWithFilter1.BookInfo.IsAvaiable())
            {

                if (MessageBox.Show("This book is Availalble, Do you want to Borrow it ?", "Avalibale", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    == DialogResult.Yes)
                {
                    frmBorrowBook frm = new frmBorrowBook(_memberID, _bookID);
                    frm.ShowDialog();
                    this.Close();
                    return false;
                }               
            }
            if (ctrlMemberInfoWithFilter1.MemberInfo.DoesHasReservationForBookID(_bookID))
            {
                MessageBox.Show("This member already has a reservation for this book!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ctrlMemberInfoWithFilter1_OnMemberSelected(int obj)
        {
            _memberID = obj;
            if (_memberID == -1)
            {
                tcBookInfo.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show($"No member Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandleMemberCritera())
            {
                return;
            }
            btnNext.Enabled = true;
        }

        private void ctrlBookInfoWithFilter1_OnBookSelected(int obj)
        {
            _bookID = obj;
            if (_bookID == -1)
            {
                btnReserve.Enabled = false;
                MessageBox.Show("No book Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandleBookCoditions())
            {
                return;
            }
            gbReservationInfo.Enabled = true;
            btnReserve.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcBookInfo.Enabled = true;
            tabControl1.SelectedTab = tabControl1.TabPages["tcBookInfo"];
        }

        private void frmReserveBook_Activated(object sender, EventArgs e)
        {
            ctrlMemberInfoWithFilter1.FilterValueFocus();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to reserve this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No))
            {
                return;
            }
            if (!_HandleMemberCritera())
            {
                return;
            }
            if (!_HandleBookCoditions())
            {
                return;
            }
            _reservation = new clsReservation();
            _reservation.MemberID = _memberID;
            _reservation.BookID = _bookID;
            _reservation.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_reservation.Save())
            {
                lblReservationID.Text = _reservation.ReservationID.ToString();
                btnReserve.Enabled = false;
                MessageBox.Show("Book reserved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to reserve book!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
