namespace LIbraryManagmentSystem.Reservations
{
    partial class frmReserveBook
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tcMemberInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlMemberInfoWithFilter1 = new LIbraryManagmentSystem.Members.Controls.ctrlMemberInfoWithFilter();
            this.tcBookInfo = new System.Windows.Forms.TabPage();
            this.gbReservationInfo = new System.Windows.Forms.GroupBox();
            this.lblCreatedByUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlBookInfoWithFilter1 = new LIbraryManagmentSystem.Books.Controls.ctrlBookInfoWithFilter();
            this.btnReserve = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tcMemberInfo.SuspendLayout();
            this.tcBookInfo.SuspendLayout();
            this.gbReservationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tcMemberInfo);
            this.tabControl1.Controls.Add(this.tcBookInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 829);
            this.tabControl1.TabIndex = 1;
            // 
            // tcMemberInfo
            // 
            this.tcMemberInfo.BackColor = System.Drawing.Color.White;
            this.tcMemberInfo.Controls.Add(this.btnNext);
            this.tcMemberInfo.Controls.Add(this.ctrlMemberInfoWithFilter1);
            this.tcMemberInfo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tcMemberInfo.Location = new System.Drawing.Point(4, 25);
            this.tcMemberInfo.Name = "tcMemberInfo";
            this.tcMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcMemberInfo.Size = new System.Drawing.Size(924, 800);
            this.tcMemberInfo.TabIndex = 0;
            this.tcMemberInfo.Text = "Member Info";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(767, 746);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 37);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlMemberInfoWithFilter1
            // 
            this.ctrlMemberInfoWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlMemberInfoWithFilter1.Location = new System.Drawing.Point(-4, 0);
            this.ctrlMemberInfoWithFilter1.Name = "ctrlMemberInfoWithFilter1";
            this.ctrlMemberInfoWithFilter1.Size = new System.Drawing.Size(910, 800);
            this.ctrlMemberInfoWithFilter1.TabIndex = 0;
            this.ctrlMemberInfoWithFilter1.OnMemberSelected += new System.Action<int>(this.ctrlMemberInfoWithFilter1_OnMemberSelected);
            // 
            // tcBookInfo
            // 
            this.tcBookInfo.BackColor = System.Drawing.Color.White;
            this.tcBookInfo.Controls.Add(this.gbReservationInfo);
            this.tcBookInfo.Controls.Add(this.ctrlBookInfoWithFilter1);
            this.tcBookInfo.Controls.Add(this.btnReserve);
            this.tcBookInfo.Location = new System.Drawing.Point(4, 25);
            this.tcBookInfo.Name = "tcBookInfo";
            this.tcBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcBookInfo.Size = new System.Drawing.Size(924, 800);
            this.tcBookInfo.TabIndex = 1;
            this.tcBookInfo.Text = "Book Info";
            // 
            // gbReservationInfo
            // 
            this.gbReservationInfo.Controls.Add(this.lblCreatedByUserID);
            this.gbReservationInfo.Controls.Add(this.label3);
            this.gbReservationInfo.Controls.Add(this.lblReservationDate);
            this.gbReservationInfo.Controls.Add(this.label2);
            this.gbReservationInfo.Controls.Add(this.lblReservationID);
            this.gbReservationInfo.Controls.Add(this.label5);
            this.gbReservationInfo.Enabled = false;
            this.gbReservationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReservationInfo.Location = new System.Drawing.Point(22, 360);
            this.gbReservationInfo.Name = "gbReservationInfo";
            this.gbReservationInfo.Size = new System.Drawing.Size(849, 209);
            this.gbReservationInfo.TabIndex = 156;
            this.gbReservationInfo.TabStop = false;
            this.gbReservationInfo.Text = "Reservation Info";
            // 
            // lblCreatedByUserID
            // 
            this.lblCreatedByUserID.AutoSize = true;
            this.lblCreatedByUserID.Location = new System.Drawing.Point(636, 35);
            this.lblCreatedByUserID.Name = "lblCreatedByUserID";
            this.lblCreatedByUserID.Size = new System.Drawing.Size(56, 25);
            this.lblCreatedByUserID.TabIndex = 165;
            this.lblCreatedByUserID.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 164;
            this.label3.Text = "Created By User  :";
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.Location = new System.Drawing.Point(196, 98);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(56, 25);
            this.lblReservationDate.TabIndex = 163;
            this.lblReservationDate.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 162;
            this.label2.Text = "Reservation Date :";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Location = new System.Drawing.Point(196, 53);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(56, 25);
            this.lblReservationID.TabIndex = 161;
            this.lblReservationID.Text = "????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 160;
            this.label5.Text = "Reservation ID :";
            // 
            // ctrlBookInfoWithFilter1
            // 
            this.ctrlBookInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlBookInfoWithFilter1.Name = "ctrlBookInfoWithFilter1";
            this.ctrlBookInfoWithFilter1.Size = new System.Drawing.Size(924, 364);
            this.ctrlBookInfoWithFilter1.TabIndex = 0;
            this.ctrlBookInfoWithFilter1.OnBookSelected += new System.Action<int>(this.ctrlBookInfoWithFilter1_OnBookSelected);
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.Location = new System.Drawing.Point(745, 584);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(126, 37);
            this.btnReserve.TabIndex = 4;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // frmReserveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 848);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReserveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserve Book";
            this.Activated += new System.EventHandler(this.frmReserveBook_Activated);
            this.Load += new System.EventHandler(this.frmReserveBook_Load);
            this.tabControl1.ResumeLayout(false);
            this.tcMemberInfo.ResumeLayout(false);
            this.tcBookInfo.ResumeLayout(false);
            this.gbReservationInfo.ResumeLayout(false);
            this.gbReservationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tcMemberInfo;
        private System.Windows.Forms.Button btnNext;
        private Members.Controls.ctrlMemberInfoWithFilter ctrlMemberInfoWithFilter1;
        private System.Windows.Forms.TabPage tcBookInfo;
        private System.Windows.Forms.GroupBox gbReservationInfo;
        private System.Windows.Forms.Label lblCreatedByUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label label5;
        private Books.Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
        private System.Windows.Forms.Button btnReserve;
    }
}