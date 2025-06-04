using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsMembership
    {
        public enum enMode {  AddNew = 0, Update = 1 };
        private enMode _Mode;

        public int MembershipID {  get; set; }
        public int MembershipClassID { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public int MemberID { get; set; }
        public clsMembershipCalss MembershipClassInfo { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public DateTime MembershipExpirationDate { get; set; }
        public float PaidFees { get; set; }
        
        public clsMembership ()
        {
            MembershipID = -1;
            MembershipClassID = -1;
            MemberID = -1;
            MembershipStartDate = DateTime.Now;
            MembershipExpirationDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            CreatedByUserInfo = new clsUser();
            _Mode = enMode.AddNew;
        }
        clsMembership(int MembershipID, int MemberID, int MembershipClassID, DateTime MembershipStartDate, DateTime MembershipExpirationDate, float PaidFees, int CreatedByUserID)
        {
            this.MembershipID = MembershipID;
            this.MembershipClassID = MembershipClassID;
            this.MembershipID = MembershipID;
            this.MembershipClassInfo = clsMembershipCalss.Find(MembershipClassID);
            this.MembershipStartDate = MembershipStartDate;
            this.MembershipExpirationDate = MembershipExpirationDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            CreatedByUserInfo = clsUser.Find(CreatedByUserID);
            _Mode = enMode.Update;
        }

        public static clsMembership Find(int MembershipID)
        {
            int MembershipClassID = -1, MemberID = -1, CreatedByUserID = -1; DateTime MembershipStartDate = DateTime.Now, MembershipExpirationDate = DateTime.Now; float PaidFees = 0;
            bool IsFound = false;
            IsFound = clsMembershipData.GetMemberShipInfoInfoByID(MembershipID, ref MemberID, ref MembershipClassID, ref MembershipStartDate, ref MembershipExpirationDate, ref PaidFees, ref CreatedByUserID);
            if (IsFound)
                return new clsMembership(MembershipID,  MemberID, MembershipClassID, MembershipStartDate, MembershipExpirationDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static clsMembership FindByMemberID(int MemberID)
        {
            int MembershipClassID = -1, MembershipID = -1, CreatedByUserID = -1; DateTime MembershipStartDate = DateTime.Now, MembershipExpirationDate = DateTime.Now; float PaidFees = 0;
            bool IsFound = false;
            IsFound = clsMembershipData.GetMemberShipInfoInfoByMemberID(MemberID, ref MembershipID, ref MembershipClassID, ref MembershipStartDate, ref MembershipExpirationDate, ref PaidFees, ref CreatedByUserID);
            if (IsFound)
                return new clsMembership(MembershipID, MemberID, MembershipClassID, MembershipStartDate, MembershipExpirationDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public bool IsActive()
        {
            return this.MembershipExpirationDate > DateTime.Now;
        }
        private bool _AddNewMembership()
        {
            MembershipID = clsMembershipData.AddNewMembership(MemberID, MembershipClassID, MembershipStartDate,MembershipExpirationDate, PaidFees, CreatedByUserID);
            return MembershipID != -1;
        }
        private bool _UpdateMembership()
        {
            return clsMembershipData.UpdateMembership(MembershipID,MemberID, MembershipClassID, MembershipStartDate, MembershipExpirationDate, PaidFees);
        }
        public bool Delete()
        {
            return clsMembershipData.DeleteMembership(MembershipID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMembership())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateMembership();
                default:
                    return false;
            }
        }

    }
}
