using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsBookCopy
    {
        
        public int BookCopyID {  get; set; }
        public int BookID { get; set; }
        public int ReservedForMemberID {  get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDamaged { get; set; }

        public clsBookCopy()
        {
            BookCopyID = -1;
            BookID = -1;
            ReservedForMemberID = -1;
            IsAvailable = true;
            IsDamaged = false;
            
        }
        clsBookCopy(int BookCopyID , int BookID, int ReservedForMemberID, bool IsAvailable, bool IsDamaged)
        {
            this.BookCopyID = BookCopyID;
            this.BookID = BookID;
            this.ReservedForMemberID = ReservedForMemberID;
            this.IsAvailable = IsAvailable;
            this.IsDamaged = IsDamaged;
        }

        public static clsBookCopy Find (int BookCopyID)
        {
            int BookID = -1, ReservedForMemberID = -1;
            bool IsAvailable = false, IsFound = false, IsDamaged = false;

            IsFound = clsBookCopyData.GetBookCopyInfoByID(BookCopyID,ref BookID,ref ReservedForMemberID, ref IsAvailable, ref IsDamaged);

            if (IsFound)
                return new clsBookCopy(BookCopyID,BookID, ReservedForMemberID, IsAvailable, IsDamaged);
            else
                return null;
           
        }
        public static DataTable GetAllCopies(int BookID)
        {
            return clsBookCopyData.GetAllCopies(BookID);
        }
        private bool _AddNewCopyBook()
        {
            this.BookCopyID = clsBookCopyData.AddNewBookCopy(BookID,IsAvailable,IsDamaged);
            return BookCopyID != -1;
        }
        public bool Reserve()
        {
            return clsBookCopyData.Reserve(this.BookCopyID, this.ReservedForMemberID);
        }
        public bool Repair(string Description,DateTime Date, float Cost, ref int ReservedForMemberID)
        {
            return clsBookCopyData.RepairBookCopy(this.BookCopyID, Description, Date, Cost,ref ReservedForMemberID);
        }
        public bool Save()
        {
            if (_AddNewCopyBook())
                return true;
            else
                return false;
        }
        
    }
}
