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

namespace LIbraryManagmentSystem.Publishers
{
    public partial class frmPublisherInfo : Form
    {
        int _publisherID;
        public frmPublisherInfo(int publishserID)
        {
            InitializeComponent();
            _publisherID = publishserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPublisherInfo_Load(object sender, EventArgs e)
        {
            ctrlPublisherCard1.LoadInfo(_publisherID);
        }

        private void llbUpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePublisher frm = new frmAddUpdatePublisher(_publisherID);
            frm.ShowDialog();
            ctrlPublisherCard1.LoadInfo(_publisherID);
        }
    }
}
