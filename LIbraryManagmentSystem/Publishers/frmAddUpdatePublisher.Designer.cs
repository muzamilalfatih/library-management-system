namespace LIbraryManagmentSystem.Publishers
{
    partial class frmAddUpdatePublisher
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
            this.bnClose = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.lblPublisherID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonInfo1 = new LIbraryManagmentSystem.People.Controls.ctrlPersonInfo();
            this.SuspendLayout();
            // 
            // bnClose
            // 
            this.bnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(663, 507);
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
            this.btnAddUpdate.Location = new System.Drawing.Point(825, 507);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(133, 35);
            this.btnAddUpdate.TabIndex = 17;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // lblPublisherID
            // 
            this.lblPublisherID.AutoSize = true;
            this.lblPublisherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherID.Location = new System.Drawing.Point(159, 460);
            this.lblPublisherID.Name = "lblPublisherID";
            this.lblPublisherID.Size = new System.Drawing.Size(56, 25);
            this.lblPublisherID.TabIndex = 16;
            this.lblPublisherID.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Publiser ID:";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(12, 12);
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
            this.ctrlPersonInfo1.TabIndex = 14;
            // 
            // frmAddUpdatePublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 563);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.lblPublisherID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdatePublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Publisher";
            this.Load += new System.EventHandler(this.frmAddUpdatePublisher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Label lblPublisherID;
        private System.Windows.Forms.Label label1;
        private People.Controls.ctrlPersonInfo ctrlPersonInfo1;
    }
}