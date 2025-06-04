using LIbraryManagmentSystem.People.Controls;
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

namespace LIbraryManagmentSystem.Library_Settings
{
    public partial class frmFineSettings : Form
    {
        public frmFineSettings()
        {
            InitializeComponent();
        }
        DataTable dtFineSettings;
        void _LoadData()
        {
            txtFineAmountForDamagedBook.Text = dtFineSettings.Rows[0]["FineForDamagedBook"].ToString();
            txtFineAmountPerDay.Text = dtFineSettings.Rows[0]["FineAmountPerDay"].ToString();
        }
        private void frmFineSettings_Load(object sender, EventArgs e)
        {
            dtFineSettings = clsFineSettings.GetFineSettingInfo();
            _LoadData();
        }

        private void EmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {

                errorProvider1.SetError(textBox, "This field is required");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            };
        }

        private void NotDigit_Validation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren() )
            {
                MessageBox.Show("Some fields were not valid!,put the mouse over the red icon to see the error"
                    , "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtFineSettings.Rows[0]["FineForDamagedBook"] = txtFineAmountForDamagedBook.Text;
            dtFineSettings.Rows[0]["FineAmountPerDay"] = txtFineAmountPerDay.Text;

            if (clsFineSettings.UpdateFineSettings(dtFineSettings))
            {
                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while updating data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
