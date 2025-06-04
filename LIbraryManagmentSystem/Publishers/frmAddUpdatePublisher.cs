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

namespace LIbraryManagmentSystem.Publishers
{
    public partial class frmAddUpdatePublisher : Form
    {
        int _publisherID = -1;
        clsPublisher _publisher;

        enum enMode { AddNew = 0, Update = 1 }
        enMode _mode;
        public frmAddUpdatePublisher()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }
        public frmAddUpdatePublisher(int publisherID)
        {
            InitializeComponent();
            this._publisherID = publisherID;
            _mode = enMode.Update;
        }
        private void _LoadData()
        {
            _publisher = clsPublisher.Find(_publisherID);
            if (_publisher != null)
            {
                ctrlPersonInfo1.FillData(_publisher.PersonInfo);
                lblPublisherID.Text = _publisherID.ToString();
            }
        }
        private void _ResetDefaulValues()
        {
            if (_mode == enMode.Update)
            {
                this.Text = "Update Publisher";
                btnAddUpdate.Text = "Update";
                _LoadData();
            }
            else
            {
                _publisher = new clsPublisher();
                this.Text = "Add New Publisher";
                btnAddUpdate.Text = "Add";
            }
        }

        private void frmAddUpdatePublisher_Load(object sender, EventArgs e)
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
            _publisher.PersonInfo = ctrlPersonInfo1.PersonInfo;
            if (_publisher.Save())
            {
                lblPublisherID.Text = _publisher.ID.ToString();
                btnAddUpdate.Text = "Update";
                this.Text = "Update Publisher";
                ctrlPersonInfo1.PersonID = _publisher.PersonID;
                MessageBox.Show("Data save successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while saving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
