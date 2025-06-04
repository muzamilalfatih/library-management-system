namespace LIbraryManagmentSystem.Borrows
{
    partial class frmReturnBook
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
            this.components = new System.ComponentModel.Container();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gbReturnInfo = new System.Windows.Forms.GroupBox();
            this.txtReturnNote = new System.Windows.Forms.TextBox();
            this.chkIsDamaged = new System.Windows.Forms.CheckBox();
            this.lblReturnedByUser = new System.Windows.Forms.Label();
            this.lblReturnFees = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlBorrowInfoWithFilter1 = new LIbraryManagmentSystem.Borrows.Controls.ctrlBorrowInfoWithFilter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbReturnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFormTitle.Location = new System.Drawing.Point(4, 30);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(868, 52);
            this.lblFormTitle.TabIndex = 8;
            this.lblFormTitle.Text = "Return  A Book";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbReturnInfo
            // 
            this.gbReturnInfo.Controls.Add(this.txtReturnNote);
            this.gbReturnInfo.Controls.Add(this.chkIsDamaged);
            this.gbReturnInfo.Controls.Add(this.lblReturnedByUser);
            this.gbReturnInfo.Controls.Add(this.lblReturnFees);
            this.gbReturnInfo.Controls.Add(this.lblReturnDate);
            this.gbReturnInfo.Controls.Add(this.label3);
            this.gbReturnInfo.Controls.Add(this.label5);
            this.gbReturnInfo.Controls.Add(this.label2);
            this.gbReturnInfo.Controls.Add(this.label1);
            this.gbReturnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReturnInfo.Location = new System.Drawing.Point(12, 393);
            this.gbReturnInfo.Name = "gbReturnInfo";
            this.gbReturnInfo.Size = new System.Drawing.Size(860, 272);
            this.gbReturnInfo.TabIndex = 10;
            this.gbReturnInfo.TabStop = false;
            this.gbReturnInfo.Text = "Return Info";
            // 
            // txtReturnNote
            // 
            this.txtReturnNote.Location = new System.Drawing.Point(147, 141);
            this.txtReturnNote.Multiline = true;
            this.txtReturnNote.Name = "txtReturnNote";
            this.txtReturnNote.Size = new System.Drawing.Size(648, 98);
            this.txtReturnNote.TabIndex = 4;
            this.txtReturnNote.Validating += new System.ComponentModel.CancelEventHandler(this.txtReturnNote_Validating);
            // 
            // chkIsDamaged
            // 
            this.chkIsDamaged.AutoSize = true;
            this.chkIsDamaged.Location = new System.Drawing.Point(605, 87);
            this.chkIsDamaged.Name = "chkIsDamaged";
            this.chkIsDamaged.Size = new System.Drawing.Size(134, 29);
            this.chkIsDamaged.TabIndex = 2;
            this.chkIsDamaged.Text = "IsDamaged";
            this.chkIsDamaged.UseVisualStyleBackColor = true;
            // 
            // lblReturnedByUser
            // 
            this.lblReturnedByUser.AutoSize = true;
            this.lblReturnedByUser.Location = new System.Drawing.Point(729, 45);
            this.lblReturnedByUser.Name = "lblReturnedByUser";
            this.lblReturnedByUser.Size = new System.Drawing.Size(56, 25);
            this.lblReturnedByUser.TabIndex = 1;
            this.lblReturnedByUser.Text = "????";
            // 
            // lblReturnFees
            // 
            this.lblReturnFees.AutoSize = true;
            this.lblReturnFees.Location = new System.Drawing.Point(147, 91);
            this.lblReturnFees.Name = "lblReturnFees";
            this.lblReturnFees.Size = new System.Drawing.Size(56, 25);
            this.lblReturnFees.TabIndex = 1;
            this.lblReturnFees.Text = "????";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(147, 45);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(56, 25);
            this.lblReturnDate.TabIndex = 1;
            this.lblReturnDate.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Return By User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Return Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Return Fees:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Date:";
            // 
            // bnClose
            // 
            this.bnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(577, 692);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(125, 35);
            this.bnClose.TabIndex = 13;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(739, 692);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(133, 35);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlBorrowInfoWithFilter1
            // 
            this.ctrlBorrowInfoWithFilter1.Location = new System.Drawing.Point(6, 112);
            this.ctrlBorrowInfoWithFilter1.Name = "ctrlBorrowInfoWithFilter1";
            this.ctrlBorrowInfoWithFilter1.Size = new System.Drawing.Size(866, 294);
            this.ctrlBorrowInfoWithFilter1.TabIndex = 9;
            this.ctrlBorrowInfoWithFilter1.OnBorrowSelected += new System.Action<int>(this.ctrlBorrowInfoWithFilter1_OnBorrowSelected);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 749);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbReturnInfo);
            this.Controls.Add(this.ctrlBorrowInfoWithFilter1);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.frmReturnBook_Load);
            this.gbReturnInfo.ResumeLayout(false);
            this.gbReturnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private Controls.ctrlBorrowInfoWithFilter ctrlBorrowInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbReturnInfo;
        private System.Windows.Forms.CheckBox chkIsDamaged;
        private System.Windows.Forms.Label lblReturnedByUser;
        private System.Windows.Forms.Label lblReturnFees;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReturnNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}