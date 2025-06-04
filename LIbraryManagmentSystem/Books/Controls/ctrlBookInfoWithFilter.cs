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

namespace LIbraryManagmentSystem.Books.Controls
{
    public partial class ctrlBookInfoWithFilter : UserControl
    {

        public event Action<int> OnBookSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void BookSelected(int BookID)
        {
            Action<int> handler = OnBookSelected;
            if (handler != null)
            {
                handler(BookID); // Raise the event with the parameter
            }
        }      
        public ctrlBookInfoWithFilter()
        {
            InitializeComponent();
        }
        public void TextboxFoucs()
        {
            txtFilterValue.Focus();
        }
        public void DisableFilte()
        {
            gbFilters.Enabled = false;
        }
        private void txtBookID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((txtFilterValue.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, "");
            }
        }

        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        public void Search(int bookID)
        {
            gbFilters.Enabled = false;
            txtFilterValue.Text = bookID.ToString();
            _FindNow(txtFilterValue.Text);    
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
            _FindNow(txtFilterValue.Text, cbFilterBy.Text);
        }
        void _FindNow(string txtFilterValue, string txtFilterBy = "ID")
        {
            if (ctrlBookInfo1.LoadBookInfo(txtFilterValue, txtFilterBy))
            {
                BookSelected(ctrlBookInfo1.BookInfo.BookID);
            }
            else
            {

                //MessageBox.Show($"Coudn't find the member with ID = {_memberID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BookSelected(-1);
            }
        }
        private void txtBookID_KeyUp(object sender, KeyEventArgs e)
        {
            btnFind.Enabled = txtFilterValue.Text != "";
        }
        public clsBook BookInfo
        {
            get
            {
                return ctrlBookInfo1.BookInfo;
            }
        }
        public void FilterValueFocus()
        {
            txtFilterValue.Focus();
        }

        private void ctrlBookInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
            if (cbFilterBy.Text == "ID")
            {
                e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
            }
        }
    }
}
