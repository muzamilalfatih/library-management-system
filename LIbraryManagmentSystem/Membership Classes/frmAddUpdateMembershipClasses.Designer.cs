namespace LIbraryManagmentSystem.Membership_Classes
{
    partial class frmAddNewUpdateMembershipClasses
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bnClose = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.lblMembershipClassID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFeesPerDay = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxNumberOFBooksCanBorrow = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMebershipClassName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bnClose
            // 
            this.bnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(573, 361);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(125, 35);
            this.bnClose.TabIndex = 18;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(735, 361);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(133, 35);
            this.btnAddUpdate.TabIndex = 17;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // lblMembershipClassID
            // 
            this.lblMembershipClassID.AutoSize = true;
            this.lblMembershipClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipClassID.Location = new System.Drawing.Point(303, 74);
            this.lblMembershipClassID.Name = "lblMembershipClassID";
            this.lblMembershipClassID.Size = new System.Drawing.Size(45, 25);
            this.lblMembershipClassID.TabIndex = 13;
            this.lblMembershipClassID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Membership Class ID :";
            // 
            // txtFeesPerDay
            // 
            this.txtFeesPerDay.Location = new System.Drawing.Point(476, 153);
            this.txtFeesPerDay.Name = "txtFeesPerDay";
            this.txtFeesPerDay.Size = new System.Drawing.Size(315, 30);
            this.txtFeesPerDay.TabIndex = 3;
            this.txtFeesPerDay.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBoxValidating);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(420, 156);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 25);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fees Per Day:";
            // 
            // txtMaxNumberOFBooksCanBorrow
            // 
            this.txtMaxNumberOFBooksCanBorrow.Location = new System.Drawing.Point(476, 104);
            this.txtMaxNumberOFBooksCanBorrow.Name = "txtMaxNumberOFBooksCanBorrow";
            this.txtMaxNumberOFBooksCanBorrow.Size = new System.Drawing.Size(315, 30);
            this.txtMaxNumberOFBooksCanBorrow.TabIndex = 2;
            this.txtMaxNumberOFBooksCanBorrow.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBoxValidating);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(420, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 25);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Number Of Books Can Borrow:";
            // 
            // txtMebershipClassName
            // 
            this.txtMebershipClassName.Location = new System.Drawing.Point(476, 54);
            this.txtMebershipClassName.Name = "txtMebershipClassName";
            this.txtMebershipClassName.Size = new System.Drawing.Size(315, 30);
            this.txtMebershipClassName.TabIndex = 1;
            this.txtMebershipClassName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBoxValidating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(420, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Membership Class Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFeesPerDay);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaxNumberOFBooksCanBorrow);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMebershipClassName);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 226);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Class Info:";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 19);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(856, 39);
            this.lblFormTitle.TabIndex = 15;
            this.lblFormTitle.Text = "Add New Membership Class";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(252, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 25);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddNewUpdateMembershipClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 417);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.lblMembershipClassID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewUpdateMembershipClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Update MembershipClass";
            this.Load += new System.EventHandler(this.frmAddNewUpdateMembershipClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Label lblMembershipClassID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFeesPerDay;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxNumberOFBooksCanBorrow;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMebershipClassName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}