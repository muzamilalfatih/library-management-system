using LIbraryManagmentSystem.Borrows.Controls;
using LIbraryManagmentSystem.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.BookCopies
{
    public partial class frmRepairBookCopy : Form
    {
        int _copyID = -1;
        int _reservedForMemberID = -1;
        public frmRepairBookCopy()
        {
            InitializeComponent();
        }
        public frmRepairBookCopy(int copyID)
        {
            InitializeComponent();
            _copyID = copyID;
        }
        private void bnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlBookCopyInfoWithFilter1_OnCopySelected(int obj)
        {
            _copyID = obj;
            if (_copyID == -1)
            {
                MessageBox.Show($"No Copy Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ctrlBookCopyInfoWithFilter1.CopyInfo.IsDamaged)
            {
                MessageBox.Show("This copy is not damaged", "Not Damaged", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMaintenanceFees.Focus();
            gbMaintenaceInfo.Enabled = true;
            btnRepair.Enabled = true;
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((txtDescription.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, "");
            }
        }

        private void txtMaintenanceFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((txtMaintenanceFees.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMaintenanceFees, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMaintenanceFees, "");
            }
        }

        private void txtMaintenanceFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void frmRepairBookCopy_Load(object sender, EventArgs e)
        {
            if (_copyID!=-1)
            {
                ctrlBookCopyInfoWithFilter1.DisableFilte();
                ctrlBookCopyInfoWithFilter1.Search(_copyID);
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
        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Some Fields were not valid!;Put the mouse over the red icon(s) to see ther error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!ctrlBookCopyInfoWithFilter1.CopyInfo.IsDamaged)
            {
                MessageBox.Show("This copy is not damaged", "Not Damaged", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ctrlBookCopyInfoWithFilter1.CopyInfo.Repair(txtDescription.Text.Trim(),dtpRepaidDate.Value,Convert.ToSingle(txtMaintenanceFees.Text.Trim()),ref _reservedForMemberID))
            {
                btnRepair.Enabled = false;
                ctrlBookCopyInfoWithFilter1.IsDamagedText = "NO";
                if (_reservedForMemberID != -1)
                {
                    _HandleAvailableReservationForMember();
                }
                MessageBox.Show("Repaired successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Paying!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRepairBookCopy_Activated(object sender, EventArgs e)
        {
            ctrlBookCopyInfoWithFilter1.FilterValueFocus();
        }
    }
}
