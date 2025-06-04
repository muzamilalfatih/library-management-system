using LIbraryManagmentSystem.Books;
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
    public partial class frmListPublishers : Form
    {
        private static DataTable _dtAllPublishers;
        private void _RefreshDataGrid()
        {
            _dtAllPublishers = clsPublisher.GetAllPublishers();
            dgvPublishers.DataSource = _dtAllPublishers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPublishers.Rows.Count.ToString();
            if (_dtAllPublishers.Rows.Count == 0)
            {
                return;
            }
            dgvPublishers.Columns[0].HeaderText = "Publisher ID";
            dgvPublishers.Columns[0].Width = 80;



            dgvPublishers.Columns[1].HeaderText = "Publisher Name";
            dgvPublishers.Columns[1].Width = 250;

            dgvPublishers.Columns[2].HeaderText = "Email";
            dgvPublishers.Columns[2].Width = 200;

            dgvPublishers.Columns[3].HeaderText = "Phone";
            dgvPublishers.Columns[3].Width = 80;

            dgvPublishers.Columns[4].HeaderText = "Total Books";
            dgvPublishers.Columns[4].Width = 80;

        }
        public frmListPublishers()
        {
            InitializeComponent();
        }

        private void frmListPublishers_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Publisher ID":
                    FilterColumn = "PublisherID";
                    break;
                case "Publisher Name":
                    FilterColumn = "PublisherName";
                    break;
                default:
                    FilterColumn = cbFilterBy.Text;
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPublishers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllPublishers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PublisherID")
                //in this case we deal with numbers not string.
                _dtAllPublishers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllPublishers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllPublishers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Publisher ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnPubliserUser_Click(object sender, EventArgs e)
        {
            frmAddUpdatePublisher frm = new frmAddUpdatePublisher();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublisherInfo frm = new frmPublisherInfo((int)dgvPublishers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void addNewPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePublisher frm = new frmAddUpdatePublisher();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePublisher frm = new frmAddUpdatePublisher((int)dgvPublishers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Publisher?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                if (clsPublisher.DeletePublisher((int)dgvPublishers.CurrentRow.Cells[0].Value))
                {
                    _RefreshDataGrid();
                    MessageBox.Show("Publisher deleted successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Publisher is not deleted;because data linked wiht it!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBooks frm = new frmListBooks(publiserID: (int)dgvPublishers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
