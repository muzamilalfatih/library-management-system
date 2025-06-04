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
using System.Windows.Forms.VisualStyles;

namespace LIbraryManagmentSystem.Authors
{
    public partial class frmAddNewUpdateAuthor : Form
    {
        int _authorID = -1;
        clsAuthor _author;

        enum enMode { AddNew = 0, Update = 1 }
        enMode _mode;
        public frmAddNewUpdateAuthor()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }
        public frmAddNewUpdateAuthor(int AuthorID)
        {
            InitializeComponent();
            _authorID = AuthorID;
            _mode = enMode.Update;
        }
        private void _LoadData()
        {
            _author = clsAuthor.Find(_authorID);
            if (_author != null)
            {
                ctrlPersonInfo1.FillData(_author.PersonInfo);
                lblAuthorID.Text = _authorID.ToString();
            }
        }
        private void _ResetDefaulValues()
        {
            if (_mode == enMode.Update)
            {
                this.Text = "Update Auhtor";
                btnAddUpdate.Text = "Update";
                _LoadData();
            }
            else
            {
                _author = new clsAuthor();
                this.Text = "Add New Auhtor";
                btnAddUpdate.Text = "Add";
            }
        }

        private void frmAddNewUpdateAuthor_Load(object sender, EventArgs e)
        {
            _ResetDefaulValues();
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (!ctrlPersonInfo1.Validate_Children())
            {
                MessageBox.Show("Some fiels are not valid!, put the mouse of the red icon to see the error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _author.PersonInfo = ctrlPersonInfo1.PersonInfo;
            if (_author.Save())
            {
                lblAuthorID.Text = _author.ID.ToString();
                btnAddUpdate.Text = "Update";
                this.Text = "Update Author";
                ctrlPersonInfo1.PersonID = _author.PersonID;
                MessageBox.Show("Data save successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while saving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
