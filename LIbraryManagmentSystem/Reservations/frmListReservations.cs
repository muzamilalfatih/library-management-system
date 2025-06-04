using LIbraryManagmentSystem.Borrows;
using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.Reservations
{
    public partial class frmListReservations : Form
    {
        private static DataTable _dtAllReservations;
        private void _RefreshDataGrid()
        {
            _dtAllReservations = clsReservation.GetAllReservations();
            dgvReservations.DataSource = _dtAllReservations;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvReservations.Rows.Count.ToString();
            if (_dtAllReservations.Rows.Count == 0)
            {
                return;
            }
            dgvReservations.Columns[0].HeaderText = "Reservation ID";
            dgvReservations.Columns[0].Width = 80;

            dgvReservations.Columns[1].HeaderText = "Member ID";
            dgvReservations.Columns[1].Width = 80;

            dgvReservations.Columns[2].HeaderText = "Book ID";
            dgvReservations.Columns[2].Width = 80;

            dgvReservations.Columns[3].HeaderText = "Reservation Date";
            dgvReservations.Columns[3].Width = 150;

            dgvReservations.Columns[4].HeaderText = "Reservation Status";
            dgvReservations.Columns[4].Width = 80;
        }
        public frmListReservations()
        {
            InitializeComponent();
        }

        private void frmListReservations_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Reservation Status")
            {
                txtFilterValue.Visible = false;
                cbReservationStatus.Visible = true;
                cbReservationStatus.Focus();
                cbReservationStatus.SelectedIndex = 0;
            }
            else if (cbFilterBy.Text == "Reservation Date")
            {
                txtFilterValue.Visible = false;
                cbReservationStatus.Visible = false;
            }
            else

            {

                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbReservationStatus.Visible = false;
                if (cbFilterBy.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void cbReservationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "ReservationStatus";
            string FilterValue = cbReservationStatus.Text;
          

            if (FilterValue == "All")
                _dtAllReservations.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllReservations.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtAllReservations.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Reservation ID":
                    FilterColumn = "ReservationID";
                    break;
                case "Member ID":
                    FilterColumn = "MemberID";
                    break;

                case "Book ID":
                    FilterColumn = "BookID";
                    break;
                
                case "Reservation Date":
                    FilterColumn = "ReservationDate";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllReservations.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvReservations.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "ReservationID" || FilterColumn == "MemberID" || FilterColumn == "BookID")
                //in this case we deal with numbers not string.
                _dtAllReservations.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllReservations.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllReservations.Rows.Count.ToString();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmReserveBook frm = new frmReserveBook();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvReservations.CurrentRow.Cells[4].Value.ToString() != "Available")
            {
                                                                     
                MessageBox.Show("The book is not availble yet!","Not Availabe",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int _memberID = (int)dgvReservations.CurrentRow.Cells[1].Value;
            int _bookID = (int)dgvReservations.CurrentRow.Cells[2].Value;
            frmBorrowBook frm = new frmBorrowBook(_memberID, _bookID);
            frm.ShowDialog(this);
            _RefreshDataGrid();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text != "Reservation Date" && cbFilterBy.Text != "Reservation Status")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        void _HandleAvailableReservationForMember()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Availabe";
            notifyIcon1.BalloonTipText = "The book is available! please pick it up with in three days ";
            notifyIcon1.ShowBalloonTip(1000);

        }
        private void cancellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel reservation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            int reservedForMemberID = -1;
            if (clsReservation.Cancel((int)dgvReservations.CurrentRow.Cells[0].Value, ref reservedForMemberID))
            {
                if (reservedForMemberID != -1)
                {
                    _HandleAvailableReservationForMember();
                }
                _RefreshDataGrid();
                MessageBox.Show("Canelled Successfully!","Cancelled",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while cancelling the resevation!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmReservation_Opening(object sender, CancelEventArgs e)
        {
            cancellToolStripMenuItem.Enabled = dgvReservations.CurrentRow.Cells[4].Value.ToString() == "Pending" || dgvReservations.CurrentRow.Cells[4].Value.ToString() == "Available";
            borrowBookToolStripMenuItem.Enabled = dgvReservations.CurrentRow.Cells[4].Value.ToString() == "Available";
        }

    }
}
