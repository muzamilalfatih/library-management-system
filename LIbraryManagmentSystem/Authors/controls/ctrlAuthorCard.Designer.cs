namespace LIbraryManagmentSystem.Authors.controls
{
    partial class ctrlAuthorCard
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
            this.ctrlPersonCard1 = new LIbraryManagmentSystem.People.Controls.ctrlPersonCard();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.llbUpdateInfo = new System.Windows.Forms.LinkLabel();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.ctrlPersonCard1.Size = new System.Drawing.Size(867, 265);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.llbUpdateInfo);
            this.groupBox2.Controls.Add(this.lblCreatedDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblAuthorID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auhtor Info";
            // 
            // llbUpdateInfo
            // 
            this.llbUpdateInfo.AutoSize = true;
            this.llbUpdateInfo.Enabled = false;
            this.llbUpdateInfo.Location = new System.Drawing.Point(732, 93);
            this.llbUpdateInfo.Name = "llbUpdateInfo";
            this.llbUpdateInfo.Size = new System.Drawing.Size(112, 25);
            this.llbUpdateInfo.TabIndex = 7;
            this.llbUpdateInfo.TabStop = true;
            this.llbUpdateInfo.Text = "Update Info";
            this.llbUpdateInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdateInfo_LinkClicked);
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.Location = new System.Drawing.Point(644, 36);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(56, 25);
            this.lblCreatedDate.TabIndex = 6;
            this.lblCreatedDate.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Created Date:";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorID.Location = new System.Drawing.Point(174, 36);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(56, 25);
            this.lblAuthorID.TabIndex = 4;
            this.lblAuthorID.Text = "????";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LIbraryManagmentSystem.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(128, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIbraryManagmentSystem.Properties.Resources.Calendar_32;
            this.pictureBox1.Location = new System.Drawing.Point(596, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlAuthorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlAuthorCard";
            this.Size = new System.Drawing.Size(874, 399);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbUpdateInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
