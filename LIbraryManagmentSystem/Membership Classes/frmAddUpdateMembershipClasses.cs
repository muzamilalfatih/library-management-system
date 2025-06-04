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

namespace LIbraryManagmentSystem.Membership_Classes
{
    public partial class frmAddNewUpdateMembershipClasses : Form
    {
        private int _membershipClassID = -1;
        private clsMembershipCalss _membershipClass;
        enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public frmAddNewUpdateMembershipClasses()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddNewUpdateMembershipClasses(int membershipClassID)
        {
            InitializeComponent();
            this._membershipClassID = membershipClassID;
            _Mode = enMode.Update;
        }


        private void EmptyTextBoxValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {

                errorProvider1.SetError(textBox, "This field is required!");
                e.Cancel = true;
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(textBox, null);
            }

        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            _membershipClass = clsMembershipCalss.Find(_membershipClassID);
            if (_membershipClass != null )
            {
                lblMembershipClassID.Text = _membershipClass.ID.ToString();
                txtMebershipClassName.Text = _membershipClass.Name;
                txtMaxNumberOFBooksCanBorrow.Text = _membershipClass.MaxNumberOfBookCanBorrow.ToString();
                txtFeesPerDay.Text = _membershipClass.FeesPerDay.ToString();
            }
        }
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                _membershipClass = new clsMembershipCalss();
                lblFormTitle.Text = "Add New Membership Class";             
                btnAddUpdate.Text = "Add";
            }
            else
            {
                _LoadData();
                lblFormTitle.Text = "Update Membership Class";
                btnAddUpdate.Text = "Update";
            }
        }
        private void frmAddNewUpdateMembershipClasses_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Fields are not valid!, Put the mouse over the red icon to see the error.","Not Allowed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                _membershipClass.Name = txtMebershipClassName.Text.Trim();
                _membershipClass.MaxNumberOfBookCanBorrow = int.Parse(txtMaxNumberOFBooksCanBorrow.Text.Trim());
                _membershipClass.FeesPerDay = Convert.ToSingle(txtFeesPerDay.Text.Trim());
                if (_membershipClass.Save())
                {
                    if (_Mode == enMode.AddNew)
                    {
                        btnAddUpdate.Text = "Update";
                        lblFormTitle.Text = "Update Membership Class";
                        lblMembershipClassID.Text = _membershipClass.ID.ToString();
                        _Mode = enMode.Update;
                    }
                    MessageBox.Show("Data saved successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
