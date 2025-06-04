namespace LIbraryManagmentSystem.Memberships
{
    partial class frmRenewMembership
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMembershipInfo = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbMembershipClasess = new System.Windows.Forms.ComboBox();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblPaidFees = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMembershipCreatedByUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlMembershipInfoWithFilter1 = new LIbraryManagmentSystem.Memberships.Controls.ctrlMembershipInfoWithFilter();
            this.gbMembershipInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMembershipInfo
            // 
            this.gbMembershipInfo.Controls.Add(this.dtpExpirationDate);
            this.gbMembershipInfo.Controls.Add(this.dtpStartDate);
            this.gbMembershipInfo.Controls.Add(this.cbMembershipClasess);
            this.gbMembershipInfo.Controls.Add(this.lblMembershipID);
            this.gbMembershipInfo.Controls.Add(this.label8);
            this.gbMembershipInfo.Controls.Add(this.label9);
            this.gbMembershipInfo.Controls.Add(this.pictureBox9);
            this.gbMembershipInfo.Controls.Add(this.pictureBox8);
            this.gbMembershipInfo.Controls.Add(this.lblPaidFees);
            this.gbMembershipInfo.Controls.Add(this.label12);
            this.gbMembershipInfo.Controls.Add(this.label6);
            this.gbMembershipInfo.Controls.Add(this.lblMembershipCreatedByUserName);
            this.gbMembershipInfo.Controls.Add(this.label5);
            this.gbMembershipInfo.Controls.Add(this.label1);
            this.gbMembershipInfo.Controls.Add(this.pictureBox6);
            this.gbMembershipInfo.Controls.Add(this.pictureBox7);
            this.gbMembershipInfo.Controls.Add(this.label10);
            this.gbMembershipInfo.Controls.Add(this.pictureBox5);
            this.gbMembershipInfo.Controls.Add(this.pictureBox4);
            this.gbMembershipInfo.Enabled = false;
            this.gbMembershipInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbMembershipInfo.Location = new System.Drawing.Point(17, 422);
            this.gbMembershipInfo.Name = "gbMembershipInfo";
            this.gbMembershipInfo.Size = new System.Drawing.Size(874, 273);
            this.gbMembershipInfo.TabIndex = 158;
            this.gbMembershipInfo.TabStop = false;
            this.gbMembershipInfo.Text = "New Membership Info";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.CustomFormat = "dd/M/yyyy";
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDate.Location = new System.Drawing.Point(288, 226);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(167, 30);
            this.dtpExpirationDate.TabIndex = 155;
            this.dtpExpirationDate.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtpExpirationDate.ValueChanged += new System.EventHandler(this.dtpExpirationDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/M/yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(288, 160);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(167, 30);
            this.dtpStartDate.TabIndex = 154;
            this.dtpStartDate.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // cbMembershipClasess
            // 
            this.cbMembershipClasess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembershipClasess.FormattingEnabled = true;
            this.cbMembershipClasess.Location = new System.Drawing.Point(256, 93);
            this.cbMembershipClasess.Name = "cbMembershipClasess";
            this.cbMembershipClasess.Size = new System.Drawing.Size(204, 33);
            this.cbMembershipClasess.TabIndex = 151;
            this.cbMembershipClasess.SelectedIndexChanged += new System.EventHandler(this.cbMembershipClasess_SelectedIndexChanged);
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipID.Location = new System.Drawing.Point(251, 38);
            this.lblMembershipID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(48, 25);
            this.lblMembershipID.TabIndex = 149;
            this.lblMembershipID.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 25);
            this.label8.TabIndex = 148;
            this.label8.Text = "Membership Start Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-36, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 25);
            this.label9.TabIndex = 148;
            this.label9.Text = "MembershipExpirationDate:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(698, 95);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 153;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(697, 39);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 153;
            this.pictureBox8.TabStop = false;
            // 
            // lblPaidFees
            // 
            this.lblPaidFees.AutoSize = true;
            this.lblPaidFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidFees.Location = new System.Drawing.Point(738, 95);
            this.lblPaidFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaidFees.Name = "lblPaidFees";
            this.lblPaidFees.Size = new System.Drawing.Size(48, 25);
            this.lblPaidFees.TabIndex = 152;
            this.lblPaidFees.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(574, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 25);
            this.label12.TabIndex = 151;
            this.label12.Text = "Paid Fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 148;
            this.label6.Text = "MembershipClass:";
            // 
            // lblMembershipCreatedByUserName
            // 
            this.lblMembershipCreatedByUserName.AutoSize = true;
            this.lblMembershipCreatedByUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipCreatedByUserName.Location = new System.Drawing.Point(737, 39);
            this.lblMembershipCreatedByUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembershipCreatedByUserName.Name = "lblMembershipCreatedByUserName";
            this.lblMembershipCreatedByUserName.Size = new System.Drawing.Size(48, 25);
            this.lblMembershipCreatedByUserName.TabIndex = 152;
            this.lblMembershipCreatedByUserName.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 148;
            this.label5.Text = "Membership ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 148;
            this.label1.Text = "Membership ID:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(243, 160);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 150;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(243, 230);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 150;
            this.pictureBox7.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(512, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 25);
            this.label10.TabIndex = 151;
            this.label10.Text = "Created By User:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(211, 96);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 150;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(211, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 150;
            this.pictureBox4.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(189, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(492, 52);
            this.lblTitle.TabIndex = 160;
            this.lblTitle.Text = "Renew Membership";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(756, 712);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(135, 36);
            this.btnRenew.TabIndex = 161;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(583, 712);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 162;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlMembershipInfoWithFilter1
            // 
            this.ctrlMembershipInfoWithFilter1.Location = new System.Drawing.Point(7, 117);
            this.ctrlMembershipInfoWithFilter1.Name = "ctrlMembershipInfoWithFilter1";
            this.ctrlMembershipInfoWithFilter1.Size = new System.Drawing.Size(884, 299);
            this.ctrlMembershipInfoWithFilter1.TabIndex = 163;
            this.ctrlMembershipInfoWithFilter1.OnMembershipSelected += new System.Action<int>(this.ctrlMembershipInfoWithFilter1_OnMembershipSelected);
            // 
            // frmRenewMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 771);
            this.Controls.Add(this.ctrlMembershipInfoWithFilter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbMembershipInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRenewMembership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renew Membership";
            this.Activated += new System.EventHandler(this.frmRenewMembership_Activated);
            this.Load += new System.EventHandler(this.frmRenewMembership_Load);
            this.gbMembershipInfo.ResumeLayout(false);
            this.gbMembershipInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMembershipInfo;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbMembershipClasess;
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblPaidFees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMembershipCreatedByUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
        private Controls.ctrlMembershipInfoWithFilter ctrlMembershipInfoWithFilter1;
    }
}