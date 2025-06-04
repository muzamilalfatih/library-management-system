using LIbraryManagmentSystem.Global_Classes;
using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.People.Controls
{
    public partial class ctrlPersonInfo : UserControl
    {
        private clsPerson _PersonInfo = new clsPerson();
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode = enMode.AddNew;
        public int Mode
        {
            get
            {
                return (int)_Mode;
            }
            set
            {
                _Mode = (enMode) value;
            }
        }
        private void _LoadPersonInfo()
        {    
            
            _PersonInfo.FirstName = txtFirstName.Text.Trim();
            _PersonInfo.SecondName = txtSecondName.Text.Trim();
            _PersonInfo.ThirdName = txtThirdName.Text.Trim();
            _PersonInfo.LastName = txtLastName.Text.Trim();
            _PersonInfo.NationalNo = txtNationalNo.Text.Trim();
            _PersonInfo.Gender = (clsPerson.enGender)(rbMale.Checked ? 0 : 1);
            _PersonInfo.Email = txtEmail.Text.Trim();
            _PersonInfo.Phone = txtPhone.Text.Trim();
            _PersonInfo.Address = txtAddress.Text.Trim();
            
        }
        public void FillData (clsPerson PersonInfo)
        {
            _PersonInfo =  PersonInfo;
            lblPersonID.Text = PersonInfo.PersonID.ToString();
            txtFirstName.Text = PersonInfo.FirstName.ToString();
            txtSecondName.Text = PersonInfo.SecondName.ToString();
            txtThirdName.Text = PersonInfo.ThirdName.ToString();
            txtLastName.Text = PersonInfo.LastName.ToString();
            txtNationalNo.Text = PersonInfo.NationalNo.ToString();
            rbMale.Checked = PersonInfo.Gender == clsPerson.enGender.Male;
            rbFemale.Checked = !rbMale.Checked;
            txtPhone.Text = PersonInfo.Phone.ToString();
            txtEmail.Text = PersonInfo.Email.ToString();
            txtAddress.Text = PersonInfo.Address.ToString();
            _Mode = enMode.Update;
        }
        public clsPerson PersonInfo
        {
            get { 
                _LoadPersonInfo();
                return _PersonInfo; 
                }
            set { _PersonInfo = value; }
        }
        
        public int PersonID
        {
            set { lblPersonID.Text = value.ToString(); }
        }
        private  void RaiseValidation(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                
                errorProvider1.SetError(textBox, "This field is required!");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, null);
            }

            if (textBox == txtNationalNo && textBox.Text != string.Empty)
            {
                if (_Mode == enMode.AddNew && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()) )
                {
                    
                    errorProvider1.SetError(textBox, "National Number is used for another person!");
                    e.Cancel = true;
                }
                else if (txtNationalNo.Text.Trim() != _PersonInfo.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
                {
                    errorProvider1.SetError(textBox, "National Number is used for another person!");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtNationalNo, null);
                }
            }
            if (textBox == txtEmail && txtEmail.Text.Trim() != string.Empty)
            {
                if (!(txtEmail.Text =="") && !clsValidation.ValidateEmail(txtEmail.Text.Trim()))
                {
                   
                    errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
                }
                else
                {
                    errorProvider1.SetError(txtEmail, null);
                };
            }
        }

        public bool Validate_Children()
        {
            
            return this.ValidateChildren();
        }
        public void FirstNameTextBoxFocus()
        {
            txtFirstName.Focus();
        }

        
    }
}
