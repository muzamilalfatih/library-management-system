using LIbraryManagmentSystem.Members.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.Memberships.Controls
{
    public partial class ctrlMembershipInfoWithFilter : UserControl
    {
        public event Action<int> OnMembershipSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void MembershipSelected(int MemberID)
        {
            Action<int> handler = OnMembershipSelected;
            if (handler != null)
            {
                handler(MemberID); // Raise the event with the parameter
            }
        }

        int _memberID;
        public ctrlMembershipInfoWithFilter()
        {
            InitializeComponent();
        }
        void _ResetValue()
        {
            ctrlMembershipInfo1.ResetValues();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Som fields are not valide; put the mouse over the red icon(s) to see the erro",
                                "Validation Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(txtMemberID.Text.Trim(), out _memberID))
            {
                if (ctrlMembershipInfo1.LoadInfo(_memberID))
                {
                    MembershipSelected(_memberID);
                }
                else
                {
                    _ResetValue();
                    MembershipSelected(-1);
                }

            }
            else
            {
                return;
            }
        }

        public void MemberIDFocus()
        {
            txtMemberID.Focus();
        }
        public void DisableFilte()
        {
            gbFilters.Enabled = false;
        }
        private void txtMemberID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((txtMemberID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMemberID, "This field is required!");

            }
            else
            {
                
                e.Cancel = false;
                errorProvider1.SetError(txtMemberID, "");
            }
        }
        public void Search(int memberID)
        {
            gbFilters.Enabled = false;
            txtMemberID.Text = memberID.ToString();
            btnFind_Click(null, null);
        }
        public void LoadInfo(int memberID)
        {
            ctrlMembershipInfo1.LoadInfo(memberID);
        }
        private void txtMemberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                       
            if (e.KeyChar == (char)11 && txtMemberID.Text != "")
            {
                btnFind_Click(null, null);
            }
        }

        private void txtMemberID_KeyUp(object sender, KeyEventArgs e)
        {
            btnFind.Enabled = !(txtMemberID.Text == "");
        }
    }
}
