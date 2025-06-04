namespace LIbraryManagmentSystem.Members
{
    partial class frmListMemebers
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
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.cmMembers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnAddNewMemeber = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.cmMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToOrderColumns = true;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.ContextMenuStrip = this.cmMembers;
            this.dgvMembers.Location = new System.Drawing.Point(12, 303);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(1368, 371);
            this.dgvMembers.TabIndex = 29;
            // 
            // cmMembers
            // 
            this.cmMembers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmMembers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewMemberToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renewMembershipToolStripMenuItem,
            this.BorrowABookToolStripMenuItem});
            this.cmMembers.Name = "cmMembers";
            this.cmMembers.Size = new System.Drawing.Size(226, 232);
            this.cmMembers.Opening += new System.ComponentModel.CancelEventHandler(this.cmMembers_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.PersonDetails_321;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewMemberToolStripMenuItem
            // 
            this.addNewMemberToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.AddNewMember_32;
            this.addNewMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewMemberToolStripMenuItem.Name = "addNewMemberToolStripMenuItem";
            this.addNewMemberToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.addNewMemberToolStripMenuItem.Text = "Add New Member";
            this.addNewMemberToolStripMenuItem.Click += new System.EventHandler(this.addNewMemberToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // renewMembershipToolStripMenuItem
            // 
            this.renewMembershipToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.RenewMembership_32;
            this.renewMembershipToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewMembershipToolStripMenuItem.Name = "renewMembershipToolStripMenuItem";
            this.renewMembershipToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.renewMembershipToolStripMenuItem.Text = "Renew Membership";
            this.renewMembershipToolStripMenuItem.Click += new System.EventHandler(this.renewMembershipToolStripMenuItem_Click);
            // 
            // BorrowABookToolStripMenuItem
            // 
            this.BorrowABookToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_borrow_book_32__1_;
            this.BorrowABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrowABookToolStripMenuItem.Name = "BorrowABookToolStripMenuItem";
            this.BorrowABookToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.BorrowABookToolStripMenuItem.Text = "Borrow A Book";
            this.BorrowABookToolStripMenuItem.Click += new System.EventHandler(this.BorrowABookToolStripMenuItem_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(314, 270);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(255, 30);
            this.txtFilterValue.TabIndex = 27;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Member ID",
            "Full Name",
            "Membership Class Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(98, 270);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 33);
            this.cbFilterBy.TabIndex = 25;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filter By:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(438, 208);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(398, 40);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Manage Members";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(116, 690);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(34, 25);
            this.lblRecordsCount.TabIndex = 31;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 690);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "# Records:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1245, 679);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(314, 270);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(122, 33);
            this.cbIsActive.TabIndex = 34;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnAddNewMemeber
            // 
            this.btnAddNewMemeber.BackColor = System.Drawing.Color.White;
            this.btnAddNewMemeber.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewMemeber.FlatAppearance.BorderSize = 0;
            this.btnAddNewMemeber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewMemeber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewMemeber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewMemeber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewMemeber.Image = global::LIbraryManagmentSystem.Properties.Resources.Add_New_64;
            this.btnAddNewMemeber.Location = new System.Drawing.Point(1310, 230);
            this.btnAddNewMemeber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddNewMemeber.Name = "btnAddNewMemeber";
            this.btnAddNewMemeber.Size = new System.Drawing.Size(65, 65);
            this.btnAddNewMemeber.TabIndex = 33;
            this.btnAddNewMemeber.UseVisualStyleBackColor = false;
            this.btnAddNewMemeber.Click += new System.EventHandler(this.btnAddNewMemeber_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::LIbraryManagmentSystem.Properties.Resources.member___512;
            this.pbPersonImage.Location = new System.Drawing.Point(526, 14);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(219, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 22;
            this.pbPersonImage.TabStop = false;
            // 
            // frmListMemebers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 732);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnAddNewMemeber);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListMemebers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mangae Membersh";
            this.Load += new System.EventHandler(this.frmListMemebers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.cmMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmMembers;
        private System.Windows.Forms.ToolStripMenuItem addNewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNewMemeber;
        private System.Windows.Forms.ComboBox cbIsActive;
    }
}