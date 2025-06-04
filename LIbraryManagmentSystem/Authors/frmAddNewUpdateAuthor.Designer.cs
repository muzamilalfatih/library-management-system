namespace LIbraryManagmentSystem.Authors
{
    partial class frmAddNewUpdateAuthor
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
            LIbraryManagmentSystem_Business.clsPerson clsPerson1 = new LIbraryManagmentSystem_Business.clsPerson();
            this.ctrlPersonInfo1 = new LIbraryManagmentSystem.People.Controls.ctrlPersonInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.bnClose = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfo1.Mode = 0;
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            clsPerson1.Address = "";
            clsPerson1.Email = "";
            clsPerson1.FirstName = "";
            clsPerson1.Gender = LIbraryManagmentSystem_Business.clsPerson.enGender.Male;
            clsPerson1.LastName = "";
            clsPerson1.NationalNo = "";
            clsPerson1.PersonID = -1;
            clsPerson1.Phone = "";
            clsPerson1.SecondName = "";
            clsPerson1.ThirdName = "";
            this.ctrlPersonInfo1.PersonInfo = clsPerson1;
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(957, 436);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author ID :";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorID.Location = new System.Drawing.Point(147, 448);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(56, 25);
            this.lblAuthorID.TabIndex = 2;
            this.lblAuthorID.Text = "????";
            // 
            // bnClose
            // 
            this.bnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(651, 495);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(125, 35);
            this.bnClose.TabIndex = 2;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(813, 495);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(133, 35);
            this.btnAddUpdate.TabIndex = 1;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // frmAddNewUpdateAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 542);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewUpdateAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Author";
            this.Load += new System.EventHandler(this.frmAddNewUpdateAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button btnAddUpdate;
    }
}