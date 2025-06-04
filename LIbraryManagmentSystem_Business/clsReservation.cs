using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsReservation
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enStatus {Pending = 0, Available = 1};
        private enMode _Mode;

        public int ReservationID { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public DateTime ReservationDate { get; set; }
        public enStatus Status { get; set; }
        public int CreatedByUserID { get; set; }

        public clsReservation()
        {
            ReservationID = -1;
            MemberID = -1;
            BookID = -1;
            ReservationDate = DateTime.Now;
            Status = enStatus.Pending;
            CreatedByUserID = -1;
            _Mode = enMode.AddNew;
        }

        clsReservation (int  ReservationID, int MemberID, int BookID, DateTime ReservationDate, enStatus status, int CreatedByUserID)
        {
            this.ReservationID = ReservationID;
            this.MemberID = MemberID;
            this.BookID = BookID;
            this.ReservationDate = ReservationDate;
            this.Status = status;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.Update;
        }

        public clsReservation Find (int ReservationID)
        {
            int MemberID = -1, BookID = -1;
            DateTime ReservationDate = DateTime.Now;
            byte Status = 0;
            int CreatedByUserID = -1;
            bool IsFound = false;

            IsFound = clsReservationData.GetReservationInfoInfoByID(ReservationID, ref MemberID,  ref BookID, ref ReservationDate, ref Status, ref CreatedByUserID);
            if (IsFound) 
                return new clsReservation(ReservationID,MemberID, BookID, ReservationDate,(enStatus) Status, CreatedByUserID);
            else
                return null;
        }
        public static int GetReservationID (int BookID, int memberID)
        {
            return clsReservationData.GetReservationID(BookID, memberID);
        }
        private bool _AddNewReservation()
        {
            ReservationID = clsReservationData.AddNewReservation(MemberID, BookID, CreatedByUserID);
            return ReservationID != -1;
        }
        private bool _UpdateReservation()
        {
            return clsReservationData.UpdateReservation(ReservationID,MemberID, BookID, ReservationDate, (byte) Status, CreatedByUserID);
        }
        public static DataTable GetAllReservations()
        {
            return clsReservationData.GetAllReservations();
        }
        public static bool Cancel(int reservationID, ref int reservedForMemberID)
        {
            return clsReservationData.CancelReservation(reservationID, ref reservedForMemberID);
        }
        public bool Delete ()
        {
            return clsReservationData.DeleteReservation(this.ReservationID);
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateReservation();
                default:
                    return false;
            }
        }
    }
}
