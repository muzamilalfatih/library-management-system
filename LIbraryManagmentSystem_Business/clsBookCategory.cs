using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsBookCategory
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        static DataTable GetAllCategories()
        {
            return clsBookCategory.GetAllCategories();
        }
        public clsBookCategory()
        {
            CategoryID = -1;
            CategoryName = string.Empty;
            _Mode = enMode.AddNew;
        }
        clsBookCategory (int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            _Mode = enMode.Update;
        }
        public static int GetCategoryID(string CategoryName)
        {
            return clsBookCategoryData.GetCategoryID(CategoryName);
        }
        public static string GetCategoryName(int CategoryID)
        {
            return clsBookCategoryData.GetCategoryName(CategoryID);
        }
        public static clsBookCategory Find(int CategoryID)
        {
            
            string CategoryName = string.Empty;

            CategoryName =  clsBookCategoryData.GetCategoryName (CategoryID);
            if (CategoryName == null)
            {
                return null;
            }
            else
                return new clsBookCategory(CategoryID, CategoryName);
        }
        private bool _AddNewCategory()
        {
            CategoryID = clsBookCategoryData.AddNewCategory(CategoryName);
            return CategoryID != -1;
        }
        private bool _UpdateCategory()
        {
            return clsBookCategoryData.UpdateCategory(this.CategoryID, this.CategoryName);
        }
        public static DataTable GetAllCategory()
        {
            return clsBookCategoryData.GetAllGategories();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCategory())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    if (_UpdateCategory())
                        return true;
                    else
                        return false;
                default : return false;
            }
        }
    }
}
