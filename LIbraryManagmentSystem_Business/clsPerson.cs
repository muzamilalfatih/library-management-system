using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0 , Update = 1}
        public enum enGender { Male = 0 , Female = 1 }
        private enMode _Mode;
       
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }   
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }
        public enGender Gender { get; set; }
        public string GenderText()
        {
            string Gender = this.Gender == enGender.Male ? "Male" : "Female";
            return Gender;
        }
        public string Email {  get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public clsPerson()
        {
            PersonID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;  
            ThirdName = string.Empty;
            LastName = string.Empty;
            Gender = 0;
            Email = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            _Mode = enMode.AddNew;
        }
        clsPerson(int PersonID, string NationlNo, string FirstName, string SecondName, string ThirdName, string LastName, enGender Gender, string Address, string Phone, string Email)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationlNo;
           this. FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            _Mode = enMode.Update;
        }
        
        public static clsPerson Find (int PersonID)
        {
            bool IsFound;
            string NationalNO = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", 
                 Address = "", Phone = "", Email = "";
            
            int Gender = 0;
                               
            IsFound = clsPersonData.GetPersonInfoByID(PersonID, ref NationalNO, ref FirstName,ref SecondName, ref ThirdName, ref LastName,ref Gender, ref Address, ref Phone, ref Email);
            if (IsFound)
            {
                return new clsPerson(PersonID,NationalNO, FirstName, SecondName, ThirdName, LastName, (enGender)Gender, Address, Phone, Email);
            }
            else
            { return null; }
        }
        

        private bool _AddNewPerson()
        {
            this.PersonID  = clsPersonData.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName,(short)Gender,Address, Phone, Email);

            return PersonID != -1;
        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, (short)Gender, Address, Phone, Email);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }
        public bool SendEmail(string Body, string Subject)
        {
            //Implement the code that send and email here
            return true;
        }
        public bool Delete()
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    if (_UpdatePerson())
                        return true;
                    else
                        return false;
                default: return false;
                
            }
        }
    }
}
