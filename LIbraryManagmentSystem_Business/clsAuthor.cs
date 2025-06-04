using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsAuthor
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int ID {  get; set; }
        public int PersonID { get; set; }
        public DateTime CreatedDate { get; set; }
        public clsPerson PersonInfo { get; set; }

        public clsAuthor()
        {
            ID = -1;
            PersonID = -1; 
            PersonInfo = new clsPerson();
            CreatedDate = DateTime.Now;
            _Mode = enMode.AddNew;
        }
        clsAuthor(int ID, int PersonID, DateTime CreatedDate)
        {
            this.ID  = ID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(this.PersonID);
            this.CreatedDate = CreatedDate;
            _Mode = enMode.Update;
        }
        public static clsAuthor Find(int AuthorID)
        {
           int  PersonID = -1;
            DateTime CreatedDate = DateTime.Now;
            bool IsFound = false;

            IsFound = clsAuthorData.GetAuthorInfoByID(AuthorID,ref PersonID,ref CreatedDate);
            if (IsFound)
            {
                return new clsAuthor(AuthorID, PersonID, CreatedDate);
            }
            else
            {
                return null;
            }

        }
        bool _AddNewAuthor()
        {
            if (!PersonInfo.Save())
            {
                return false;
            }
            PersonID = PersonInfo.PersonID;
            this.ID = clsAuthorData.AddNewAuthor(PersonID);
            return ID != -1;
        }
        bool _UpdateAuthor()
        {
            return PersonInfo.Save();
        }
        static public bool DeleteAuthor(int AuthorID)
        {
            return clsAuthorData.DeleteAuthor(AuthorID);
        }
        static public DataTable GetAllAuthors()
        {
            return clsAuthorData.GetAllAuthors();
        }
        public static string GetAuthorName(int AuthorID)
        {
            return clsAuthorData.GetAuthorName(AuthorID);
        }
        public static int GetAuthorID(string AuthorName)
        {
            return clsAuthorData.GetAuthorID(AuthorName);
        }
        public static int GetTotalAuthors()
        {
            return clsAuthorData.GetTotalAuthors();
        }
        public static DataTable GetAllBooks(int authorID)
        {
            return clsAuthorData.GetAllBooks(GetAuthorName(authorID));
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAuthor())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }

                    return false;
                case enMode.Update:
                    if (_UpdateAuthor())
                        return true;
                    else
                        return false;
                default: return false;
            }
        }
    }
}
