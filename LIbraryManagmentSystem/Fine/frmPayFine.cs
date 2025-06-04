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

namespace LIbraryManagmentSystem.Fine
{
    public partial class frmPayFine : Form
    {
        int _fineID;
        public frmPayFine(int fineID)
        {
            InitializeComponent();
            _fineID = fineID;
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPayAmount_TextChanged(object sender, EventArgs e)
        {
            btnPay.Enabled = !string.IsNullOrEmpty(txtPayAmount.Text.Trim());
        }

        private void txtPayAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPayAmount.Text.Trim()))
            {

                errorProvider1.SetError(txtPayAmount, "Can't be blank!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPayAmount, null);
            };
        }

        private void frmPayFine_Load(object sender, EventArgs e)
        {
            ctrlFineInfo1.LoadInfo(_fineID);
            lblPaidByUser.Text = clsGlobal.CurrentUser.UserName;
            lblPaymentDate.Text = clsFormat.DateToShort(DateTime.Now);
            txtPayAmount.Text = (ctrlFineInfo1.FineInfo.FineAmount - ctrlFineInfo1.FineInfo.PaidAmount).ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Some Fields were not valid!;Put the mouse over the red icon to see ther error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if ( ctrlFineInfo1.FineInfo.IsPaid)
            {
                MessageBox.Show("This Fine is already paid!", "Paid Already", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((Convert.ToSingle(txtPayAmount.Text.Trim()) + ctrlFineInfo1.FineInfo.PaidAmount) > ctrlFineInfo1.FineInfo.FineAmount )
            {
                MessageBox.Show("The enter amonunt is greated than claim!", "To Much Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ctrlFineInfo1.FineInfo.Pay(clsGlobal.CurrentUser.UserID, Convert.ToSingle(txtPayAmount.Text.Trim())))
            {
                ctrlFineInfo1.LoadInfo(_fineID);
                MessageBox.Show("Paid successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Paying!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPayFine_Activated(object sender, EventArgs e)
        {
            txtPayAmount.Focus();
        }
    }
}
