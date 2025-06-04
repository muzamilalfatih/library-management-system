using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsUser 
    {
        private enum enMode { AddNew = 0, Update= 1 };
        private enMode _Mode;
        public enum enUserRole { Librarian = 1, Admin =  0 };
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public string UserName { get; set; }
        public string Password {  get; set; }
        public enUserRole UserRole {  get; set; }
        public string UserRoleText()
        {
            string Role = this.UserRole == enUserRole.Admin ? "Admin" : "Librarian";
            return Role;
        }
        public bool IsActive { get; set; }

        public clsUser()
        {
            UserID = -1;
            PersonID = -1;  
            PersonInfo = new clsPerson();
            UserName = string.Empty;
            Password = string.Empty;
            UserRole = enUserRole.Librarian;
            IsActive = true;
            _Mode = enMode.AddNew;
        }
        clsUser ( int UserID, int PersonID, string UserName, string Password, int UserRole, bool IsActive)
        {
            this.UserID = UserID;
           this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);

            this.UserName = UserName;
            this.Password = Password;
            this.UserRole = (enUserRole)UserRole;
            this.IsActive = IsActive;
            _Mode = enMode.Update;
        }
        
        static public clsUser Find(int UserID)
        {
            bool IsFound;
            int PersonID = -1; string UserName = "",Password = ""; int UserRole = 0; bool IsActive = false;

            IsFound = clsUserData.GetUeserInfoByUserID(UserID,ref PersonID,ref UserName,ref Password, ref UserRole, ref IsActive);

            if (IsFound)
            {
                clsPerson PersonInfo = clsPerson.Find(PersonID);

                return new clsUser(UserID, PersonID, UserName, Password, UserRole,IsActive );
            }
            else
            {
                return null;
            }
        }
        static public clsUser Find(string UserName)
        {
            bool IsFound;
            int UserID = -1, PersonID = -1; string  Password = ""; int UserRole = 0; bool IsActive = false;

            IsFound = clsUserData.GetUserInfoByUserName(UserName, ref PersonID, ref UserID, ref Password, ref UserRole, ref IsActive);
            if (IsFound)
            {          
                return new clsUser(UserID, PersonID, UserName, Password, UserRole, IsActive);
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewUser()
        {
            if (!PersonInfo.Save()) 
                return false;
            PersonID = PersonInfo.PersonID;

            UserID = clsUserData.AddNewUser(PersonID,UserName,Password,(byte) UserRole, IsActive);

            return UserID != -1;
        }
        private bool _UpdateUser()
        {
            if (!PersonInfo.Save()) return false;
            PersonID = PersonInfo.PersonID;
            return clsUserData.UpdateUser(UserID,PersonID,UserName,Password,(Byte) UserRole,IsActive);
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);   
        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        public static bool IsUserExsit(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }
        public static int GetTotalUsers()
        {
            return clsUserData.GetTotalUsers();
        }
        public static bool IsThereOtherAdmins(int CurrentUserID)
        {
            return clsUserData.IsThereOtherAdmins(CurrentUserID);
        }
        public bool ChangePassword(string newPassword)
        {
            return clsUserData.ChangePassword(this.UserID , newPassword);
        }
        public bool SendEmail(string Body, string Subject)
        {
            //Implement the code that send and email here
            return true;
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    
                    return false;
                case enMode.Update:
                    if (_UpdateUser())
                        return true;
                    else
                        return false;
                default: return false;
            } 
        }
    }
}
