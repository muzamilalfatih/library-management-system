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

namespace LIbraryManagmentSystem.Membership_Classes
{
    public partial class frmListmembershipClasses : Form
    {
        public frmListmembershipClasses()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllBooks;
        private void _RefreshDataGrid()
        {
            _dtAllBooks = clsMembershipCalss.GetAllMembershipClassess();
            dgvMembershipClasses.DataSource = _dtAllBooks;          
            lblRecordsCount.Text = dgvMembershipClasses.Rows.Count.ToString();
            if (_dtAllBooks.Rows.Count == 0)
            {
                return;
            }
            dgvMembershipClasses.Columns[0].HeaderText = "Membershipclass ID";
            dgvMembershipClasses.Columns[0].Width = 110;

            //dgvUsers.Columns[1].HeaderText = "Person ID";
            //dgvUsers.Columns[1].Width = 120;

            dgvMembershipClasses.Columns[1].HeaderText = "Membership Class Name";
            dgvMembershipClasses.Columns[1].Width = 250;

            dgvMembershipClasses.Columns[2].HeaderText = "Max Number Of Book Can Borrow";
            dgvMembershipClasses.Columns[2].Width = 150;

            dgvMembershipClasses.Columns[3].HeaderText = "Fees Per Day";
            dgvMembershipClasses.Columns[3].Width = 80;

        }
        private void frmListmembershipClasses_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAddNewUpdateMembershipClasses frm = new frmAddNewUpdateMembershipClasses((int)dgvMembershipClasses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGrid();
        }

       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateMembershipClasses frm = new frmAddNewUpdateMembershipClasses();
            frm.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this class", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) 
                == DialogResult.No)
            {
                return;
            }

            if (clsMembershipCalss.Delete((int)dgvMembershipClasses.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Classes deleted successfully","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Classes was not because data linked with it!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMembershipClass_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateMembershipClasses frm = new frmAddNewUpdateMembershipClasses();
            frm.ShowDialog();
            _RefreshDataGrid();
        }
    }
}
