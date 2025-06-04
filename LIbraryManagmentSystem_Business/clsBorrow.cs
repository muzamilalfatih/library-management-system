using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsBorrow
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        float _returnFees = 0;
        int _reservedForMemberID = -1;
        public int BorrowID { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public int copyID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public float PaidFees { get; set; }
        public string ReturnNotes { get; set; }
        public DateTime? ReturnDate { get; set; }
        public float ReturnFees
        {
            set
            {
                _returnFees = value;
            }
            get
            {
                return _returnFees;
            }
        }
        public int CreatedByUserID { get; set; }
        public int ReturnedByUserID { get; set; }
        public clsFine FineInfo { get; set; }
        public bool HasReserrvation { get; set; }
        public bool IsDamaged { get; set; }
        public int ReservedForMemberID
        {
            set
            {
                _reservedForMemberID = value;
            }
            get
            {
                return _reservedForMemberID;
            }
        }

        public clsBorrow ()
        {
            BorrowID = -1;
            MemberID = -1;
            BookID = -1;
            BorrowDate = DateTime.Now;
            DueDate = DateTime.Now;
            PaidFees = 0;
            ReturnNotes = string.Empty;
            ReturnDate = DateTime.Now;
            ReturnFees = 0;
            CreatedByUserID = -1;
            ReturnedByUserID = -1;
            copyID = -1;
            _Mode = enMode.AddNew;
        }
       
        clsBorrow( int borrowID, int memberID, int bookID, DateTime borrowDate, DateTime dueDate, float 
            paidFees, string returnNotes, DateTime? returnDate, float returnFees, int createdByUserID, int returnedByUserID, int copyID)
        {
            
            BorrowID = borrowID;
            MemberID = memberID;
            this.BookID = bookID;
            BorrowDate = borrowDate;
            DueDate = dueDate;
            PaidFees = paidFees;
            ReturnNotes = returnNotes;
            ReturnDate = returnDate;
            ReturnFees = returnFees;
            CreatedByUserID = createdByUserID;
            ReturnedByUserID = returnedByUserID;
            this.copyID = copyID;
            _Mode = enMode.Update;
        }

        public static clsBorrow Find (int BorrowID)
        {
            int memberID = -1, BookID = -1, createdByUserID = -1, returnedByUserID = -1, copyID = -1;
                DateTime BorrowDate = DateTime.Now, dueDate = DateTime.Now, returnDate = DateTime.Now;  float paidFees = 0, returnFees = 0;
                  string returnNotes = string.Empty;
            bool IsFound = false;

            IsFound = clsBorrowData.GetBorrowInfoByID(BorrowID, ref memberID, ref BookID, ref BorrowDate, ref dueDate, ref paidFees, ref returnNotes, ref returnDate, ref returnFees, ref createdByUserID, ref returnedByUserID);
            if (IsFound)
                return new clsBorrow(BorrowID, memberID, BookID, BorrowDate, dueDate, paidFees, returnNotes, returnDate, returnFees, createdByUserID, returnedByUserID,copyID);
            else
                return null;
            
        }
        public static clsBorrow FindByCopyID(int CopyID)
        {
            int BorrowID = -1, memberID = -1, BookID = -1, createdByUserID = -1, returnedByUserID = -1, copyID = -1;
            DateTime BorrowDate = DateTime.Now, dueDate = DateTime.Now; float paidFees = 0, returnFees = 0;
            DateTime? returnDate = null;
            string returnNotes = string.Empty;
            bool IsFound = false;

            IsFound = clsBorrowData.GetBorrowInfoByCopyID(CopyID, ref BorrowID, ref memberID, ref BorrowDate, ref dueDate, ref paidFees,ref createdByUserID,ref returnNotes,ref returnDate,ref returnFees,ref returnedByUserID);
            if (IsFound)
                return new clsBorrow(BorrowID, memberID, BookID, BorrowDate, dueDate, paidFees, returnNotes,returnDate, returnFees,createdByUserID,returnedByUserID,copyID);
            else
                return null;

        }

        private bool _AddNewBorrow ()
        {
            int CopyID = -1;
            BorrowID = clsBorrowData.AddNewBorrow(MemberID,BookID,BorrowDate,DueDate,PaidFees,CreatedByUserID, HasReserrvation, ref CopyID);
            this.copyID = CopyID;
            return BorrowID != -1;
        }
        private bool _UpdateBorrow()
        {
            return clsBorrowData.UpdateBorrow(BorrowID, MemberID, BookID, BorrowDate, DueDate, PaidFees, CreatedByUserID);
        }

        public bool ReturnBook()
        {
            
           return  clsBorrowData.ReturnBook(this.BorrowID,this.ReturnNotes,ref _returnFees, ref _reservedForMemberID,this.ReturnedByUserID,this.IsDamaged);
        }
        //public bool PayFine (int PaidByUserID)
        //{
        //    clsFine Fine = clsFine.Find(BorrowID);

        //    return Fine.PayFine(PaidByUserID);
        //}
       public static int GetTotalIssuedBooks()
        {
            return clsBorrowData.GetTotalIssuedBooks();
        }

        public static DataTable GetAllBorrows()
        {
            return clsBorrowData.GetAllBorrows();
        }
        public bool Save ()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrow())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                       return false;
                case enMode.Update:
                    if (_UpdateBorrow())
                        return true;
                    else
                        return false;
                default:
                    return false;
            }
        }
    }
}
