namespace LIbraryManagmentSystem.Borrows
{
    partial class frmBorrowBook
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
            this.chkHasReservation = new System.Windows.Forms.CheckBox();
            this.gbBorrowInfromation = new System.Windows.Forms.GroupBox();
            this.lblCopyID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBorrowID = new System.Windows.Forms.Label();
            this.lblBorrowFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDuteTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.ctrlBookInfoWithFilter1 = new LIbraryManagmentSystem.Books.Controls.ctrlBookInfoWithFilter();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tcMemberInfo.SuspendLayout();
            this.tcBookInfo.SuspendLayout();
            this.gbBorrowInfromation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tcMemberInfo);
            this.tabControl1.Controls.Add(this.tcBookInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControl1.Location = new System.Drawing.Point(8, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 829);
            this.tabControl1.TabIndex = 0;
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
            this.ctrlMemberInfoWithFilter1.Location = new System.Drawing.Point(-4, 0);
            this.ctrlMemberInfoWithFilter1.Name = "ctrlMemberInfoWithFilter1";
            this.ctrlMemberInfoWithFilter1.Size = new System.Drawing.Size(910, 800);
            this.ctrlMemberInfoWithFilter1.TabIndex = 0;
            this.ctrlMemberInfoWithFilter1.OnMemberSelected += new System.Action<int>(this.ctrlMemberInfoWithFilter1_OnMemberSelected);
            // 
            // tcBookInfo
            // 
            this.tcBookInfo.BackColor = System.Drawing.Color.White;
            this.tcBookInfo.Controls.Add(this.chkHasReservation);
            this.tcBookInfo.Controls.Add(this.gbBorrowInfromation);
            this.tcBookInfo.Controls.Add(this.ctrlBookInfoWithFilter1);
            this.tcBookInfo.Controls.Add(this.btnBorrow);
            this.tcBookInfo.Location = new System.Drawing.Point(4, 25);
            this.tcBookInfo.Name = "tcBookInfo";
            this.tcBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcBookInfo.Size = new System.Drawing.Size(924, 800);
            this.tcBookInfo.TabIndex = 1;
            this.tcBookInfo.Text = "Book Info";
            // 
            // chkHasReservation
            // 
            this.chkHasReservation.AutoSize = true;
            this.chkHasReservation.Enabled = false;
            this.chkHasReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasReservation.Location = new System.Drawing.Point(568, 35);
            this.chkHasReservation.Name = "chkHasReservation";
            this.chkHasReservation.Size = new System.Drawing.Size(177, 29);
            this.chkHasReservation.TabIndex = 157;
            this.chkHasReservation.Text = "Has Reservation";
            this.chkHasReservation.UseVisualStyleBackColor = true;
            // 
            // gbBorrowInfromation
            // 
            this.gbBorrowInfromation.Controls.Add(this.lblCopyID);
            this.gbBorrowInfromation.Controls.Add(this.label7);
            this.gbBorrowInfromation.Controls.Add(this.lblBorrowID);
            this.gbBorrowInfromation.Controls.Add(this.lblBorrowFees);
            this.gbBorrowInfromation.Controls.Add(this.label3);
            this.gbBorrowInfromation.Controls.Add(this.label5);
            this.gbBorrowInfromation.Controls.Add(this.label2);
            this.gbBorrowInfromation.Controls.Add(this.dtpDuteTo);
            this.gbBorrowInfromation.Controls.Add(this.label1);
            this.gbBorrowInfromation.Controls.Add(this.dtpFrom);
            this.gbBorrowInfromation.Enabled = false;
            this.gbBorrowInfromation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBorrowInfromation.Location = new System.Drawing.Point(22, 360);
            this.gbBorrowInfromation.Name = "gbBorrowInfromation";
            this.gbBorrowInfromation.Size = new System.Drawing.Size(849, 173);
            this.gbBorrowInfromation.TabIndex = 156;
            this.gbBorrowInfromation.TabStop = false;
            this.gbBorrowInfromation.Text = "Borrow Information";
            // 
            // lblCopyID
            // 
            this.lblCopyID.AutoSize = true;
            this.lblCopyID.Location = new System.Drawing.Point(617, 43);
            this.lblCopyID.Name = "lblCopyID";
            this.lblCopyID.Size = new System.Drawing.Size(56, 25);
            this.lblCopyID.TabIndex = 163;
            this.lblCopyID.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 162;
            this.label7.Text = "Copy ID:";
            // 
            // lblBorrowID
            // 
            this.lblBorrowID.AutoSize = true;
            this.lblBorrowID.Location = new System.Drawing.Point(154, 53);
            this.lblBorrowID.Name = "lblBorrowID";
            this.lblBorrowID.Size = new System.Drawing.Size(56, 25);
            this.lblBorrowID.TabIndex = 161;
            this.lblBorrowID.Text = "????";
            // 
            // lblBorrowFees
            // 
            this.lblBorrowFees.AutoSize = true;
            this.lblBorrowFees.Location = new System.Drawing.Point(760, 120);
            this.lblBorrowFees.Name = "lblBorrowFees";
            this.lblBorrowFees.Size = new System.Drawing.Size(56, 25);
            this.lblBorrowFees.TabIndex = 159;
            this.lblBorrowFees.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 158;
            this.label3.Text = "Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 160;
            this.label5.Text = "Borrow ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 156;
            this.label2.Text = "Due To:";
            // 
            // dtpDuteTo
            // 
            this.dtpDuteTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDuteTo.CustomFormat = "dd/M/yyyy";
            this.dtpDuteTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuteTo.Location = new System.Drawing.Point(417, 120);
            this.dtpDuteTo.Name = "dtpDuteTo";
            this.dtpDuteTo.Size = new System.Drawing.Size(167, 30);
            this.dtpDuteTo.TabIndex = 157;
            this.dtpDuteTo.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtpDuteTo.ValueChanged += new System.EventHandler(this.dtDuteTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.CustomFormat = "dd/M/yyyy";
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(87, 120);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(167, 30);
            this.dtpFrom.TabIndex = 155;
            this.dtpFrom.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // ctrlBookInfoWithFilter1
            // 
            this.ctrlBookInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlBookInfoWithFilter1.Name = "ctrlBookInfoWithFilter1";
            this.ctrlBookInfoWithFilter1.Size = new System.Drawing.Size(924, 364);
            this.ctrlBookInfoWithFilter1.TabIndex = 0;
            this.ctrlBookInfoWithFilter1.OnBookSelected += new System.Action<int>(this.ctrlBookInfoWithFilter1_OnBookSelected);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Enabled = false;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrow.Location = new System.Drawing.Point(745, 552);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(126, 37);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // frmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 841);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "borrow Book";
            this.Activated += new System.EventHandler(this.frmBorrowBook_Activated);
            this.Load += new System.EventHandler(this.frmBorrowBook_Load);
            this.tabControl1.ResumeLayout(false);
            this.tcMemberInfo.ResumeLayout(false);
            this.tcBookInfo.ResumeLayout(false);
            this.tcBookInfo.PerformLayout();
            this.gbBorrowInfromation.ResumeLayout(false);
            this.gbBorrowInfromation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tcMemberInfo;
        private System.Windows.Forms.TabPage tcBookInfo;
        private Members.Controls.ctrlMemberInfoWithFilter ctrlMemberInfoWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBorrow;
        private Books.Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbBorrowInfromation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDuteTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblBorrowFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCopyID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBorrowID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkHasReservation;
    }
}