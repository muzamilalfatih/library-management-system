using LIbraryManagmentSystem.Borrows.Controls;
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
    public partial class ctrlBookCopyInfoWithFilter : UserControl
    {
        public event Action<int> OnCopySelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void CopySelected(int CopyID)
        {
            Action<int> handler = OnCopySelected;
            if (handler != null)
            {
                handler(CopyID); // Raise the event with the parameter
            }
        }
        public ctrlBookCopyInfoWithFilter()
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
        public clsBookCopy CopyInfo
        {
            get
            {
                return ctrlBookCopyInfo1.CopyInfo;
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
                if (ctrlBookCopyInfo1.LoadCopyInfo(copyID))
                {
                    CopySelected(ctrlBookCopyInfo1.CopyInfo.BookCopyID  );
                }
                else
                {
                    CopySelected(-1);
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
        public string IsDamagedText
        {
            set
            {
                ctrlBookCopyInfo1.IsDamagedText = value.ToString(); 
            }
        }
    }
}
