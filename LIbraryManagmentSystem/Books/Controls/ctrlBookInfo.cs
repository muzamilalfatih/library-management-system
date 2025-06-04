using LIbraryManagmentSystem.Global_Classes;
using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbraryManagmentSystem.Books
{
    public partial class ctrlBookInfo : UserControl
    {
        
        private clsBook _Book;
        public ctrlBookInfo()
        {
            InitializeComponent();
        }
        bool HandleSearchType(string FindBy, string Value)
        {
            switch (FindBy)
            {
                case "ID":
                    _Book = clsBook.FindID(int.Parse(Value));
                    break;
                case "Title":
                    _Book = clsBook.FindByTitle(Value);
                    break;
                case "ISBN":
                    _Book = clsBook.FindByISBN(Value);
                    break;
                default 
                    : return false;
            }
            return true;
        }
        void _ResetDefaultValues()
        {
            lblBookID.Text = "????";
            lblBookID.Text = "????";
            lblTitle.Text = "????";
            lblAuthor.Text = "????";
            lblISBN.Text = "????";
            lblCategory.Text = "????";
            lblYear.Text = "????";
            lblLocation.Text = "????";
            lblBorrowFees.Text = "????";
            lblTotalCopies.Text = "????";
            lblAvialableCopies.Text = "????";
        }
        private bool _LoadInfo( string Value, string FindBy)
        {
            if (!HandleSearchType(FindBy, Value))
            {
                return false; ;
            }
            if (_Book == null)
            {
                _ResetDefaultValues();
                return false;
            }
            lblBookID.Text = _Book.BookID.ToString();
            lblTitle.Text = _Book.Title.ToString();
            lblAuthor.Text = _Book.AuthorInfo.PersonInfo.FullName;
            lblISBN.Text = _Book.ISBN.ToString();
            lblCategory.Text = _Book.CategoryInfo.CategoryName;
            lblYear .Text = clsFormat.DateToShort(_Book.Year);
            lblLocation.Text = _Book.Location;
            lblBorrowFees.Text = _Book.BorrowFees.ToString();
            lblTotalCopies.Text = clsBook.TotalCopies(_Book.BookID).ToString();
            lblAvialableCopies.Text = clsBook.GetCopiesAvilable(_Book.BookID).ToString();
            return true;
        }
        public bool LoadBookInfo(string Value ,string FindBy)
        {
            return _LoadInfo(Value, FindBy);
        }
        public bool LoadBookInfo(int bookID)
        {
            return _LoadInfo(bookID.ToString(), FindBy:"ID");
        }
        public clsBook BookInfo
        {
            get { return _Book; }
        }
        public void ResetValues()
        {
            _ResetDefaultValues();
        }
    }
}
