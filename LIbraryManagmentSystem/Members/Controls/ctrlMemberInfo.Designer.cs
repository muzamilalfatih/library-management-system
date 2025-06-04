namespace LIbraryManagmentSystem.Members.Controls
{
    partial class ctrlMemberInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlMembershipInfo1 = new LIbraryManagmentSystem.Memberships.Controls.ctrlMembershipInfo();
            this.gbMemberInfo = new System.Windows.Forms.GroupBox();
            this.llbUpdateInfo = new System.Windows.Forms.LinkLabel();
            this.lblNumberOFBorrowedBooks = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new LIbraryManagmentSystem.People.Controls.ctrlPersonCard();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbMemberInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(690, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "????";
            // 
            // ctrlMembershipInfo1
            // 
            this.ctrlMembershipInfo1.Location = new System.Drawing.Point(3, 413);
            this.ctrlMembershipInfo1.Name = "ctrlMembershipInfo1";
            this.ctrlMembershipInfo1.Size = new System.Drawing.Size(874, 207);
            this.ctrlMembershipInfo1.TabIndex = 8;
            // 
            // gbMemberInfo
            // 
            this.gbMemberInfo.Controls.Add(this.lblIsActive);
            this.gbMemberInfo.Controls.Add(this.label7);
            this.gbMemberInfo.Controls.Add(this.llbUpdateInfo);
            this.gbMemberInfo.Controls.Add(this.lblNumberOFBorrowedBooks);
            this.gbMemberInfo.Controls.Add(this.label6);
            this.gbMemberInfo.Controls.Add(this.lblCreatedByUser);
            this.gbMemberInfo.Controls.Add(this.label4);
            this.gbMemberInfo.Controls.Add(this.lblCreatedDate);
            this.gbMemberInfo.Controls.Add(this.label3);
            this.gbMemberInfo.Controls.Add(this.lblMemberID);
            this.gbMemberInfo.Controls.Add(this.label1);
            this.gbMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemberInfo.Location = new System.Drawing.Point(3, 253);
            this.gbMemberInfo.Name = "gbMemberInfo";
            this.gbMemberInfo.Size = new System.Drawing.Size(867, 168);
            this.gbMemberInfo.TabIndex = 10;
            this.gbMemberInfo.TabStop = false;
            this.gbMemberInfo.Text = "Member Info";
            // 
            // llbUpdateInfo
            // 
            this.llbUpdateInfo.AutoSize = true;
            this.llbUpdateInfo.Enabled = false;
            this.llbUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbUpdateInfo.Location = new System.Drawing.Point(740, 115);
            this.llbUpdateInfo.Name = "llbUpdateInfo";
            this.llbUpdateInfo.Size = new System.Drawing.Size(112, 25);
            this.llbUpdateInfo.TabIndex = 20;
            this.llbUpdateInfo.TabStop = true;
            this.llbUpdateInfo.Text = "Update Info";
            this.llbUpdateInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdateInfo_LinkClicked);
            // 
            // lblNumberOFBorrowedBooks
            // 
            this.lblNumberOFBorrowedBooks.AutoSize = true;
            this.lblNumberOFBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOFBorrowedBooks.Location = new System.Drawing.Point(299, 104);
            this.lblNumberOFBorrowedBooks.Name = "lblNumberOFBorrowedBooks";
            this.lblNumberOFBorrowedBooks.Size = new System.Drawing.Size(56, 25);
            this.lblNumberOFBorrowedBooks.TabIndex = 19;
            this.lblNumberOFBorrowedBooks.Text = "????";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(15, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Number Of Borrowed Books:";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreatedByUser.Location = new System.Drawing.Point(585, 42);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(56, 25);
            this.lblCreatedByUser.TabIndex = 17;
            this.lblCreatedByUser.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(417, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Created By User:";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreatedDate.Location = new System.Drawing.Point(585, 104);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(56, 25);
            this.lblCreatedDate.TabIndex = 15;
            this.lblCreatedDate.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(445, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Created Date:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMemberID.Location = new System.Drawing.Point(299, 42);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(56, 25);
            this.lblMemberID.TabIndex = 13;
            this.lblMemberID.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(167, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "MemberID:";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Address = "????";
            this.ctrlPersonCard1.Email = "????";
            this.ctrlPersonCard1.FullName = "????";
            this.ctrlPersonCard1.Gendor = "????";
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.NationalNo = "????";
            this.ctrlPersonCard1.Phone = "????";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(867, 253);
            this.ctrlPersonCard1.TabIndex = 21;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIsActive.Location = new System.Drawing.Point(767, 42);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(56, 25);
            this.lblIsActive.TabIndex = 22;
            this.lblIsActive.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(669, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Is Active:";
            // 
            // ctrlMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbMemberInfo);
            this.Controls.Add(this.ctrlMembershipInfo1);
            this.Name = "ctrlMemberInfo";
            this.Size = new System.Drawing.Size(893, 642);
            this.gbMemberInfo.ResumeLayout(false);
            this.gbMemberInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Memberships.Controls.ctrlMembershipInfo ctrlMembershipInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMemberInfo;
        private System.Windows.Forms.LinkLabel llbUpdateInfo;
        private System.Windows.Forms.Label lblNumberOFBorrowedBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label1;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label7;
    }
}
