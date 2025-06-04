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
    public partial class frmAddUpdateBook : Form
    {
        private enum enMode { AddNew = 0, Update  = 1 }
        private enMode _Mode;
        private int _BookID;
        private clsBook _Book;

        public frmAddUpdateBook()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
            _Mode = enMode.Update;
        }


        
        private void EmptyTextBoxValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {

                errorProvider1.SetError(textBox, "This field is required!");
                e.Cancel = true;
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(textBox, null);
            }

        }

        private void txtNumberOfCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void _FillBookCategoriesInComboBox ()
        {
            DataTable dtBooCategory = clsBookCategory.GetAllCategory();

            foreach (DataRow row in dtBooCategory.Rows)
            {
                cbCategory.Items.Add(row["CategoryName"]);
            }
        }
        private void _FillAuthorsComboBox()
        {
            DataTable dtAuthors = clsAuthor.GetAllAuthors();

            foreach (DataRow row in dtAuthors.Rows)
            {
                
                 cbAuthors.Items.Add(row["AuthorName"]);
            }
            cbAuthors.SelectedIndex = 0;
        }
        private void _FillPubliserComboBox()
        {
            DataTable dtPublisher = clsPublisher.GetAllPublishers();

            foreach (DataRow row in dtPublisher.Rows)
            {

                cbPublishers.Items.Add(row["PublisherName"]);
            }
            cbPublishers.SelectedIndex = 0;
        }
        private void _LoadData()
        {
            _Book = clsBook.FindID(_BookID);
            if( _Book != null )
            {
                lblBookID.Text = _Book.BookID.ToString();
                txtTitle.Text = _Book.Title.ToString();
                cbAuthors.Text = _Book.AuthorInfo.PersonInfo.FullName;   
                txtISBN.Text = _Book.ISBN.ToString();
                cbPublishers.Text = _Book.PublisherInfo.PersonInfo.FullName;
                cbCategory.Text = _Book.CategoryInfo.CategoryName;
                dtpYear.Text = _Book.Year.ToString();
                txtLocation.Text = _Book.Location.ToString();
                txtBorrowFees.Text = _Book.BorrowFees.ToString();
                txtNumberOfCopies.Text = _Book.TotalCopies().ToString();
                txtNumberOfCopies.ReadOnly = true;
            }

        }
        private void _ResetDefaulValues()
        {
            _FillBookCategoriesInComboBox();
            _FillAuthorsComboBox();
            _FillPubliserComboBox();
            if (_Mode == enMode.Update)
            {
                lblFormTitle.Text = "Update Book";
                btnAddUpdate.Text = "Update";
            }
            else
            {
                lblFormTitle.Text = "Add New Book";
                btnAddUpdate.Text = "Add";
                cbCategory.SelectedIndex = 0;
                _Book = new clsBook();
            }
        }
        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            _ResetDefaulValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();                
            }
        }    
        private void bnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillBookObjectWithData()
        {
            //_Book = new clsBook();
            _Book.Title = txtTitle.Text.Trim();
            
            _Book.ISBN = txtISBN.Text.Trim();
            _Book.AuthorID = clsAuthor.GetAuthorID(cbAuthors.Text);
            _Book.CategoryID = clsBookCategory.GetCategoryID(cbCategory.Text);
            _Book.Year = dtpYear.Value;
            _Book.Location = txtLocation.Text.Trim();
            _Book.PublisherID = clsPublisher.GetPublisherID(cbPublishers.Text);
            _Book.BorrowFees = Convert.ToSingle(txtBorrowFees.Text.Trim());
            _Book.NumberOfCopies = int.Parse(txtNumberOfCopies.Text.Trim());
        }
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fiels are not valid!, put the mouse of the red icon to see the error","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = new DataTable();
            _FillBookObjectWithData();
            if (_Book.Save(ref dt))
            {
                lblBookID.Text = _Book.BookID.ToString();
                lblFormTitle.Text = "Update Book";
                btnAddUpdate.Text = "Update";
                txtNumberOfCopies.ReadOnly = true;
                MessageBox.Show("Data save successfuly!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Error while saving Data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
