using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsPublisher
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int ID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsPublisher()
        {
            ID = -1;
            PersonID = -1;
            PersonInfo = new clsPerson();
            CreatedDate = DateTime.Now;
            _Mode = enMode.AddNew;
        }
        clsPublisher(int ID, int PersonID, DateTime CreatedDate)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(this.PersonID);
            this.CreatedDate = CreatedDate;
            _Mode = enMode.Update;
        }
        public static clsPublisher Find(int PublisherID)
        {
            int PersonID = -1;
            bool IsFound = false;
            DateTime CreatedDate = DateTime.Now;

            IsFound = clsPublisherData.GetPublisherInfoByID(PublisherID, ref PersonID, ref CreatedDate);
            if (IsFound)
            {
                return new clsPublisher(PublisherID, PersonID, CreatedDate);
            }
            else
            {
                return null;
            }

        }
        bool _AddNewPublisher()
        {
            if (!PersonInfo.Save())
            {
                return false;
            }
            PersonID = PersonInfo.PersonID;
            this.ID = clsPublisherData.AddNewPublisher(PersonID);
            return ID != -1;
        }
        bool _UpdatePublisher()
        {
            return PersonInfo.Save();
        }
        static public bool DeletePublisher(int PublisherID)
        {
            return clsPublisherData.DeletePublisher(PublisherID);
        }
        static public DataTable GetAllPublishers()
        {
            return clsPublisherData.GetAllPublishers();
        }
        public static string GetPublisherName(int PublisherID)
        {
            return clsPublisherData.GetPublisherName(PublisherID);
        }
        public static int GetPublisherID(string PublisherName)
        {
            return clsPublisherData.GetPublisherID(PublisherName);
        }
        public static int GetTotalPublishers()
        {
            return clsPublisherData.GetTotalPublishers();
        }
        public static DataTable GetAllBooks(int PublisherID)
        {
            return clsBookData.GetAllBooksForPublisher(PublisherID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPublisher())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }

                    return false;
                case enMode.Update:
                    if (_UpdatePublisher())
                        return true;
                    else
                        return false;
                default: return false;
            }
        }
    }
}
