using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsMember 
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public int MemberID { get; set; }
        public int PersonID {  get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserID { get; set; }  
        public clsUser CreatedByUserInfo { get; set; }
        public clsPerson PersonInfo { get; set; }
        public clsMembership MembershipInfo { get; set; }
        
        public clsMember ()
        {
            MemberID = -1;
            PersonID = -1;
            PersonInfo = new clsPerson ();
            CreatedByUserID = -1;
            CreatedByUserInfo = new clsUser ();
            MembershipInfo = new clsMembership ();
            CreatedDate = DateTime.Now;
            _Mode = enMode.AddNew;
        }
        clsMember(int memberID, int personID,bool IsActive,DateTime CreatedDate, int createdByUserID)
        {
            
            MemberID = memberID;
            this.IsActive = IsActive;
            PersonID = personID;
            PersonInfo = clsPerson.Find(personID);
            CreatedByUserID = createdByUserID;
            CreatedByUserInfo = clsUser.Find(createdByUserID);
            this.CreatedDate = CreatedDate;
            MembershipInfo = clsMembership.FindByMemberID(memberID);
            _Mode = enMode.Update;
        }

        public static clsMember Find(int MemberID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;
            bool IsFound = clsMemberData.GetMemberInfoByID(MemberID, ref PersonID,ref CreatedDate,ref IsActive, ref CreatedByUserID);
            if (IsFound)
                return new clsMember(MemberID, PersonID,IsActive,CreatedDate,CreatedByUserID );
            else
                return null;
        }

        private bool _AddNewMember()
        {
            if (!PersonInfo.Save())
                return false;
            PersonID = PersonInfo.PersonID;
            
            MemberID = clsMemberData.AddNewMember(PersonID,CreatedDate,IsActive, CreatedByUserID);
            if (MemberID!= -1)
            {
                MembershipInfo.MemberID = MemberID;
                MembershipInfo.Save();
            }
            return MemberID != -1;
        }

        private bool _UpdateMember()
        {
            if (PersonInfo.Save())
            {
                return clsMemberData.UpdateMember(this.MemberID, this.IsActive);
            }
            else
            {
                return false; 
            }
        }

        public static bool DeleteMember(int MemberID)
        {
            return clsMemberData.DeleteMember(MemberID);

        }
        public static int GetTotalMembers()
        {
            return clsMemberData.GetTotalMembers();
        }
        public  bool HasUnpaidFine()
        {
            return clsFineData.DoesMemberHasUnpaidFine(this.MemberID);
        }
        public static  DataTable GetAllMembers()
        {
            return clsMemberData.GetAllMembers();   
        }
        public bool HasActiveMembership()
        {
            return this.MembershipInfo.IsActive();
        }
        public  int GetNumberOFBorrowedBooks()
        {
            return clsBorrowData.GetTotalBorrowedBook(this.MemberID); 
        }
        public bool DoesHasReservationForBookID(int BookID)
        {
            return clsReservationData.DoesHasActiveReservationForBookID(this.MemberID, BookID);
        }
        public bool IsReservationAvailable(int bookID)
        {
            return clsBookCopyData.ISReservationAvialbaleForBookID(this.MemberID, bookID);
        }
        public bool DoesHasActiveReservationForBookID(int bookID)
        {
            return clsReservationData.DoesHasActiveReservationForBookID(this.MemberID,bookID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMember())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else     
                        return false;
                case enMode.Update:
                   return _UpdateMember();
                default:
                    return false;
                    
            }
        }
    }
}
