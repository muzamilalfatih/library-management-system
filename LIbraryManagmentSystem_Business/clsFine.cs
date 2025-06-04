using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsFine
    {
       public enum enReason { OverDueData  = 0, DamagedBook = 1};
        public int FineID { get; set; }
        public int MemberID { get; set; }
        public int BorrowID { get; set; }
        public float FineAmount { get; set; }
        public DateTime FineDate { get; set; }
        public float PaidAmount { get; set; }
        public bool IsPaid {  get; set; } 
        public enReason Reason { get; set; }
        public string GetReasonText
        {
            get
            {
                if (Reason == enReason.OverDueData)
                {
                    return "Over Due Date";
                }
                else
                {
                    return "Damaged Book";
                }
            }
        }


        clsFine()
        {
            FineID = -1;
            MemberID = -1;
            BorrowID = -1;
            FineAmount = 0;
            FineDate = DateTime.Now;
            IsPaid = false;   
        }

        clsFine(int fineID, int memberID, int BorrowID, float fineAmount, DateTime fineDate, 
            float paidAmount,  bool IsPaid, enReason reason)
        {
            this.FineID = fineID;
            this.MemberID = memberID;
            this.BorrowID = BorrowID;
            this.FineAmount = fineAmount;
            this.FineDate = fineDate;
            this.PaidAmount = paidAmount;
            this.IsPaid = IsPaid;
            this.Reason = reason;
        }

        public static clsFine Find(int  FineID)
        {
            int BorrowID = 0, MemberID = 0, Reason = 0;
            float FineAmount = 0, PaidAmount = 0;
            DateTime FineDate = DateTime.Now;
            bool IsPaid = false;
            bool IsFound = false;


            IsFound = clsFineData.GetFineInfoByBorrowID(FineID, ref MemberID, ref  BorrowID,ref FineAmount,ref PaidAmount, ref IsPaid,ref FineDate,ref Reason);
            if (IsFound )
                return new clsFine(FineID,MemberID, BorrowID,FineAmount,FineDate, PaidAmount, IsPaid,(enReason) Reason);
            else
                return null;
        }
        public bool Pay(int PaidByUserID, float PaidAmount)
        {
            return clsFineData.PayFine(this.FineID,PaidByUserID,PaidAmount);
        }
        
        //private bool _AddNewFine()
        //{
        //    this.FineID = clsFineData.AddNewFine(this.MemberID, this.BorrowID, this.FineAmount);
        //    return FineID != -1;
        //}
        public static DataTable GetAllFines()
        {
            return clsFineData.GetAllFines();
        }
        public bool Save()
        {
            // return _AddNewFine();
            return false;
        }

    }
}
