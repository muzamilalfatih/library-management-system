using LIbraryManagmentSystem.Authors;
using LIbraryManagmentSystem.Books;
using LIbraryManagmentSystem.Global_Classes;
using LIbraryManagmentSystem.Library_Settings;
using LIbraryManagmentSystem.Borrows;
using LIbraryManagmentSystem.Members;
using LIbraryManagmentSystem.Membership_Classes;
using LIbraryManagmentSystem.Memberships;
using LIbraryManagmentSystem.Publishers;
using LIbraryManagmentSystem.Users;
using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIbraryManagmentSystem.Reservations;
using LIbraryManagmentSystem.Fine;
using System.Diagnostics;

namespace LIbraryManagmentSystem
{
    public partial class frmMain : Form
    {
        private frmLogin _frm;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.UserRole != clsUser.enUserRole.Admin)
            {
                MessageBox.Show("Access Denied, You don't have permission!","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
            lblTotalUsers.Text = clsUser.GetTotalUsers().ToString();
        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            clsGlobal.refreshObject?.Invoke(null);
            _frm.Show();
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            lblTotalUsers.Text = clsUser.GetTotalUsers().ToString();
            lblTotalBooks.Text = clsBook.GetTotalBooks().ToString();
            lblTotalMembers.Text = clsMember.GetTotalMembers().ToString();
            lblTotalIssuedBooks.Text = clsBorrow.GetTotalIssuedBooks().ToString();
            lblTotalAuthors.Text = clsAuthor.GetTotalAuthors().ToString();
            lblTotalPublishers.Text = clsPublisher .GetTotalPublishers().ToString();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBooks frm = new frmListBooks();
            frm.ShowDialog();
            this.Refresh();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();

        }

        private void membershipClassesSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListmembershipClasses frm = new frmListmembershipClasses();
            frm.ShowDialog();

        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmListMemebers frm  = new frmListMemebers();   
            frm.ShowDialog();
            lblTotalMembers.Text = clsMember.GetTotalMembers().ToString();
        }

        private void renewMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewMembership frm = new frmRenewMembership();
            frm.ShowDialog();
            
        }

        private void fineSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmFineSettings frm = new frmFineSettings();
            frm.ShowDialog();
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAuthors frm = new frmListAuthors();
            frm.ShowDialog();
            lblTotalAuthors.Text = clsAuthor.GetTotalAuthors().ToString();  
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPublishers frm = new frmListPublishers();
            frm.ShowDialog();
            lblTotalPublishers.Text = clsPublisher.GetTotalPublishers().ToString();
        }
        private void borrowBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBorrowBook frm = new frmBorrowBook();
            frm.ShowDialog();
            lblTotalIssuedBooks.Text = clsBorrow.GetTotalIssuedBooks().ToString();
        }

        private void manageBorrowedBooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBorrowedBooks frm = new frmListBorrowedBooks();
            frm.ShowDialog();
            lblTotalIssuedBooks.Text = clsBorrow.GetTotalIssuedBooks().ToString();
        }

        private void reserveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserveBook frm = new frmReserveBook();
            frm.ShowDialog();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnBook frm = new frmReturnBook();
            frm.ShowDialog();
            lblTotalIssuedBooks.Text = clsBorrow.GetTotalIssuedBooks().ToString();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListReservations frm = new frmListReservations();
            frm.ShowDialog();
        }

        private void manageFinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListFines frm = new frmListFines();
            frm.ShowDialog();
        }
    }
}
