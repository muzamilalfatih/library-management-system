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

namespace LIbraryManagmentSystem.Publishers.Controls
{
    public partial class ctrlPublisherCard : UserControl
    {
        clsPublisher _publisher;
        public ctrlPublisherCard()
        {
            InitializeComponent();
        }
        public void ResetValues()
        {
            ctrlPersonCard1.ResetValues();
            lblPublisherID.Text = "????";
            lblCreatedDate.Text = "????";
        }
        bool _LoadInfo()
        {
            ctrlPersonCard1.LoadInfo(_publisher.PersonID);
            lblPublisherID.Text = _publisher.ID.ToString();
            lblCreatedDate.Text = clsFormat.DateToShort(_publisher.CreatedDate);
            llbUpdateInfo.Enabled = true;
            return true;
        }
        public bool LoadInfo(int publisherID)
        {
            _publisher = clsPublisher.Find(publisherID);
            if (_publisher == null)
            {
                llbUpdateInfo.Enabled = false;
                return false;
            }
            return _LoadInfo();
        }

        private void llbUpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePublisher frm = new frmAddUpdatePublisher(_publisher.ID);
            frm.ShowDialog();
            _LoadInfo();
        }
    }
}
