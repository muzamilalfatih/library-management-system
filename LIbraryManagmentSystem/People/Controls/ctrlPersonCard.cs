using LIbraryManagmentSystem.Properties;
using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        
        public int PersonID
        {
            get
            {
                return Convert.ToInt32(lblPersonID.Text);
            }
            set
            {
                lblPersonID.Text = value.ToString();
            }
        }
        public string FullName
        {
            get
            {
                return lblFullName.Text;
            }
            set
            {
                
                lblFullName.Text = value;
            }
        }
        public string NationalNo
        {
            get
            {
                return lblNationalNo.Text;
            }
            set
            {

                lblNationalNo.Text = value;
            }
        }
        public string Gendor
        {
            get
            {
                return lblGendor.Text;
            }
            set
            {

                lblGendor.Text = value;
            }
        }
        public string Phone
        {
            get
            {
                return lblPhone.Text;
            }
            set
            {

                lblPhone.Text = value;
            }
        }
        public string Email
        {
            get
            {
                return lblEmail.Text;
            }
            set
            {

                lblEmail.Text = value;
            }
        }
        public string Address
        {
            get
            {
                return lblAddress.Text;
            }
            set
            {

                lblAddress.Text = value;
            }
        }

        public void LoadInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person !=null)
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                lblFullName.Text = _Person.FullName;
                lblNationalNo.Text = _Person.NationalNo;
                lblGendor.Text = _Person.GenderText();
                pbGender.Image = _Person.Gender == clsPerson.enGender.Male ? Resources.Man_32 : Resources.Woman_32;
                lblPhone.Text = _Person.Phone;
                lblEmail.Text = _Person.Email;
                lblAddress.Text = _Person.Address;
            }

        }
        public void ResetValues()
        {
            lblPersonID.Text = "????";
            lblFullName.Text = "????";
            lblNationalNo.Text = "????";
            lblGendor.Text = "????";
            lblPhone.Text = "????";
            lblEmail.Text = "????";
            lblAddress.Text = "????";
        }

       
    }
}
