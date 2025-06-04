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

namespace LIbraryManagmentSystem.Books
{
    public partial class frmInsertCopies : Form
    {
        private int _BookID;
        public frmInsertCopies(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

       

        private void txtNumberOfCopies_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumberOfCopies.Text.Trim()))
            {

                errorProvider1.SetError(txtNumberOfCopies, "Can't be blank!");
                btnAdd.Enabled = false;
                return;
            }
            else
            {
                errorProvider1.SetError(txtNumberOfCopies, null);             
            };
        }
        void _NotifyMembers(ref DataTable reservationsList)
        {
            foreach (DataRow row in reservationsList.Rows)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Availabe";
                notifyIcon1.BalloonTipText = $"Dear Member with ID {row[0]} The book is available! please pick it up with in three days ";
                notifyIcon1.ShowBalloonTip(1000);
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Fields were not valid!;Put the mouse over the red icon to see ther error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataTable reservationList = new DataTable();
                if (clsBook.InserNumberOfCopies(_BookID,int.Parse(txtNumberOfCopies.Text.Trim()), ref  reservationList))
                {
                    if (reservationList.Rows.Count > 0)
                    {
                        _NotifyMembers(ref reservationList);
                    }                   
                    MessageBox.Show("Copies Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Copies was not inserted!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNumberOfCopies_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !string.IsNullOrEmpty(txtNumberOfCopies.Text.Trim());
        }

        private void frmInsertCopies_Load(object sender, EventArgs e)
        {
            ctrlBookInfo1.LoadBookInfo(_BookID);
        }

        private void txtNumberOfCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    
}
