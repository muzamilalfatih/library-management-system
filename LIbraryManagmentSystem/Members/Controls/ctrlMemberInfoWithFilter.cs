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

namespace LIbraryManagmentSystem.Members.Controls
{
    
    public partial class ctrlMemberInfoWithFilter : UserControl
    {   
        int _memberID =-1;
        // Define a custom event handler delegate with parameters
        public event Action<int> OnMemberSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void MemberSelected(int MemberID)
        {
            Action<int> handler = OnMemberSelected;
            if (handler != null)
            {
                handler(MemberID); // Raise the event with the parameter
            }
        }
        public ctrlMemberInfoWithFilter()
        {
            InitializeComponent();
        }
        public clsMember MemberInfo
        {
            get
            {
                return ctrlMemberInfo1.MemberInfo;
            }
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
                if (ctrlMemberInfo1.LoadInfo(_memberID))
                {
                    MemberSelected(_memberID);
                }
                else
                {

                    ctrlMemberInfo1.ResetValues();
                    MemberSelected(-1);
                }

            }
            else
            {
                return;
            }
        }
        public void FilterValueFocus()
        {
            txtMemberID.Focus();
        }
        public void DisableFilte()
        {
            gbFilters.Enabled = false;
        }
        private void txtMemberID_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void txtMemberID_KeyUp(object sender, KeyEventArgs e)
        {
            btnFind.Enabled = txtMemberID.Text != "";
        }

        private void txtMemberID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
