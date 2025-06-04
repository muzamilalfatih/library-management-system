using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsBook
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _NumberOfCopies;
        public int BookID {  get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public clsAuthor AuthorInfo { get; set; }
        public string ISBN { get; set; }
        public int PublisherID { get; set; }
        public clsPublisher PublisherInfo { get; set; }
        public int CategoryID { get; set; }
        public clsBookCategory CategoryInfo { get; set; }
        public DateTime Year { get; set; }

        public string Location {  get; set; }
        public float BorrowFees { get; set; }
        public int NumberOfCopies
        {
           
            get
            {
                return TotalCopies();
            }
            set
            {
                _NumberOfCopies = value;
            }
        }
        public clsBook()
        {
            this.BookID = -1;
            this.Title = string.Empty;
            this.AuthorID = -1;
            this.AuthorInfo = new clsAuthor();
            this.ISBN = string.Empty;
            this.PublisherID = -1;
            this.PublisherInfo = new clsPublisher();
            this.CategoryID = -1;
            this.Year = DateTime.Now;

            this.Location = string.Empty;
            this._Mode = enMode.AddNew;
        }
        clsBook (int BookID, string Title, int AuthorID,string ISBN, int PublisherID, int CategoryID, DateTime Year,
             string Location,float BorrowFees
            )
        {
            this.BookID= BookID;
            this.Title = Title;
            this.AuthorID = AuthorID;
            this.AuthorInfo = clsAuthor.Find(AuthorID);
            this.ISBN = ISBN;
            this.PublisherID= PublisherID;
            this.PublisherInfo = clsPublisher.Find(PublisherID);
            this.CategoryID = CategoryID;
            this.CategoryInfo = clsBookCategory.Find(CategoryID);
            this.Year = Year;            
            this.Location = Location;
            this.BorrowFees = BorrowFees;
            this._Mode = enMode.Update;
        }

        static public clsBook FindID(int BookID)
        {
            bool IsFound = false;
            string Title = "",  ISBN = "",  Location = "";
            float BorrowFees = 0;
            int CategoryID = -1, AuthorID = -1, PublisherID = -1;
            DateTime Year = DateTime.Now;

            IsFound = clsBookData.GetBookInfoByID(BookID, ref Title, ref AuthorID, ref ISBN, ref PublisherID, ref CategoryID, ref Year ,ref Location,ref BorrowFees);

            if (IsFound)
                return new clsBook(BookID,Title, AuthorID, ISBN, PublisherID, CategoryID,Year, Location,BorrowFees);
            else
                return null;
        }
        static public clsBook FindByTitle(string Title)
        {
            bool IsFound = false;
            string  ISBN = "", Location = "";
            float BorrowFees = 0;
            int CategoryID = -1, AuthorID = -1, PublisherID = -1, BookID = -1;
            DateTime Year = DateTime.Now;

            IsFound = clsBookData.GetBookInfoByTitle( ref Title, ref BookID, ref AuthorID, ref ISBN, ref PublisherID, ref CategoryID, ref Year, ref Location, ref BorrowFees);

            if (IsFound)
                return new clsBook(BookID, Title, AuthorID, ISBN, PublisherID, CategoryID, Year, Location, BorrowFees);
            else
                return null;
        }
        static public clsBook FindByISBN(string ISBN)
        {
            bool IsFound = false;
            string Title = "", Location = "";
            float BorrowFees = 0;
            int CategoryID = -1, AuthorID = -1, PublisherID = -1, BookID = -1;
            DateTime Year = DateTime.Now;

            IsFound = clsBookData.GetBookInfoByISBN(ref ISBN, ref BookID, ref AuthorID, ref Title, ref PublisherID, ref CategoryID, ref Year, ref Location, ref BorrowFees);

            if (IsFound)
                return new clsBook(BookID, Title, AuthorID, ISBN, PublisherID, CategoryID, Year, Location, BorrowFees);
            else
                return null;
        }
        private bool _AddNewBook()
        {
            BookID = clsBookData.AddNewBook(Title, AuthorID,
           ISBN,  PublisherID,
            CategoryID,  Year,  Location, BorrowFees,_NumberOfCopies);
            return BookID != -1;
        }
        private bool _UpdateBook()
        {
            return clsBookData.UpdateBook(this.BookID,this.Title,this.AuthorID,this.ISBN,this.PublisherID,this.CategoryID,this.Year, this.Location);
        }
        public static bool Delete(int BookID)
        {
            return clsBookData.DeleteBook(BookID);
        }
        static public int GetCopiesAvilable(int BookID)
        {
            return clsBookCopyData.AvailbleCopies(BookID) ;
        }
        public int GetCopiesAvilable()
        {
            return GetCopiesAvilable(this.BookID) ;
        }
        static public int TotalCopies(int BookID)
        {
            return clsBookCopyData.TotalCopies(BookID) ;
        }
        public int TotalCopies()
        {
            return TotalCopies(this.BookID) ;   
        }
        public static int GetTotalBooks()
        {
            return clsBookCopyData.GetTotalBooks();
        }
        public static DataTable GetAllBooks()
        {
            return clsBookData.GetAllBooks();
        }
        static public bool InserNumberOfCopies(int BookID,int NumberOfCopies, ref DataTable reservationsList)
        {
            return clsBookCopyData.IsertNumberOfCopiesForBookID(BookID,NumberOfCopies, ref  reservationsList);
        }
        public bool IsAvaiable()
        {
            return GetCopiesAvilable() > 0;
        }      
        public bool Save(ref DataTable dt)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBook())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    if ( _UpdateBook())
                        return true;
                    else
                        return false;
                default:
                    return false;
            }
        }
    }
}
