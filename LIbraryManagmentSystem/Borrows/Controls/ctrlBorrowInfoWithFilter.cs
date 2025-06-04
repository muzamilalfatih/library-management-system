using LIbraryManagmentSystem.Members.Controls;
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
    public partial class ctrlBorrowInfoWithFilter : UserControl
    {
        public event Action<int> OnBorrowSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void BorrowSelected(int BorrowID)
        {
            Action<int> handler = OnBorrowSelected;
            if (handler != null)
            {
                handler(BorrowID); // Raise the event with the parameter
            }
        }
        public ctrlBorrowInfoWithFilter()
        {
            InitializeComponent();
        }
        public void FilterValueFocus()
        {
            txtCopyID.Focus();
        }
        public void DisableFilte()
        {
            gbFilters.Enabled = false;
        }
        private void txtCopyID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((txtCopyID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCopyID, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCopyID, "");
            }
        }
        public clsBorrow BorrowInfo
        {
            get
            {
                return ctrlBorrowInfo1.BorrowInfo;
            }
        }

        private void txtCopyID_KeyUp(object sender, KeyEventArgs e)
        {
            btnFind.Enabled = txtCopyID.Text != "";
        }

        private void txtCopyID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Som fields are not valide; put the mouse over the red icon(s) to see the error",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(txtCopyID.Text.Trim(), out int copyID))
            {
                if (ctrlBorrowInfo1.LoadInfo(copyID))
                {
                    BorrowSelected(ctrlBorrowInfo1.BorrowInfo.BorrowID);
                }
                else
                {
                    BorrowSelected(-1);
                }
            }
            else
            {
                return;
            }
        }
        public void Search(int copyID)
        {
            gbFilters.Enabled = false;
            txtCopyID.Text = copyID.ToString();
            btnFind_Click(null, null);
        }
    }
}
