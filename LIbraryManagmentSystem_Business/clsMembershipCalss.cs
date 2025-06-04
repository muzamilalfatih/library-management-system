using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsMembershipCalss
    {
        public enum enMode { AddNew = 0, Update =  1 };
        private enMode _Mode;

        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxNumberOfBookCanBorrow {  get; set; }
        public float FeesPerDay;

        public clsMembershipCalss ()
        {
            ID = -1;
            Name = string.Empty;
            MaxNumberOfBookCanBorrow = 0;
            FeesPerDay = 0;
            _Mode = enMode.AddNew;
        }
        clsMembershipCalss (int ID, string Name, int MaxNumberOfBookCanBorrow, float FeesPerDay)
        {
            this.ID = ID;
            this.Name = Name;
            this.MaxNumberOfBookCanBorrow = MaxNumberOfBookCanBorrow;
            this.FeesPerDay = FeesPerDay;
            _Mode = enMode.Update;
        }
        public static clsMembershipCalss Find (int MemberShipClassID)
        {
             string Name = string.Empty; int MaxNumberOfBookCanBorrow = 0; float FeesPerDay = 0;
            bool IsFound = false;
            IsFound = clsMembershipClassesData.GetMemberShipClassInfoInfo(MemberShipClassID, ref Name, ref MaxNumberOfBookCanBorrow, ref FeesPerDay);
            if (IsFound)
                return new clsMembershipCalss(MemberShipClassID, Name, MaxNumberOfBookCanBorrow, FeesPerDay);
            else
                return null;
        }
        public static clsMembershipCalss Find(string MembershipClassName)
        {
            int MembershipClassID = -1; int MaxNumberOfBookCanBorrow = 0; float FeesPerDay = 0;
            bool IsFound = false;
            IsFound = clsMembershipClassesData.GetMemberShipClassInfoInfo(MembershipClassName, ref MembershipClassID, ref MaxNumberOfBookCanBorrow, ref FeesPerDay);
            if (IsFound)
                return new clsMembershipCalss(MembershipClassID, MembershipClassName, MaxNumberOfBookCanBorrow, FeesPerDay);
            else
                return null;
        }
        public static DataTable GetAllMembershipClassess()
        {
            return clsMembershipClassesData.GetAllMembershipClassess();
        }
        private bool _AddNewMembershipClass()
        {
            ID = clsMembershipClassesData.AddNewMembershipClass(Name,MaxNumberOfBookCanBorrow,FeesPerDay);
            return ID != -1;
        }
        private bool _UpdateMembershipClass()
        {
            return clsMembershipClassesData.UpdateMembership(ID, Name, MaxNumberOfBookCanBorrow, FeesPerDay);
        }
        public static bool Delete(int membershipClassID)
        {
            return clsMembershipClassesData.DeleteMembershipClass(membershipClassID);
        }

        public static int GetMembershipClassID(string  MembershipClassName)
        {
            return clsMembershipClassesData.GetMembershipClassID(MembershipClassName);
        }
        public static string GetMembershipClassName(int MembershipClassID)
        {
            return clsMembershipClassesData.GetMembershipClassName(MembershipClassID);
        }

        public bool Save ()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMembershipClass())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
            case enMode.Update:
                    return _UpdateMembershipClass();
                default:
                    return false;
                        

            }
        }
    }
}
