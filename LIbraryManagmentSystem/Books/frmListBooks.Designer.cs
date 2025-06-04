namespace LIbraryManagmentSystem.Books
{
    partial class frmListBooks
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cmBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.cmBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1380, 675);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(108, 681);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(34, 25);
            this.lblRecordsCount.TabIndex = 31;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 681);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "# Records:";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.ContextMenuStrip = this.cmBooks;
            this.dgvBooks.Location = new System.Drawing.Point(4, 294);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(5);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(1511, 371);
            this.dgvBooks.TabIndex = 29;
            // 
            // cmBooks
            // 
            this.cmBooks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.edToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.insertCopiesToolStripMenuItem,
            this.showAllCopiesToolStripMenuItem});
            this.cmBooks.Name = "cmBooks";
            this.cmBooks.Size = new System.Drawing.Size(227, 228);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(306, 261);
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
            "Book ID",
            "Title",
            "Author",
            "ISBN",
            "Category Name",
            "Location",
            "Borrow Fees"});
            this.cbFilterBy.Location = new System.Drawing.Point(90, 261);
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
            this.label1.Location = new System.Drawing.Point(6, 264);
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
            this.lblTitle.Location = new System.Drawing.Point(667, 208);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 40);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Manage Books";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::LIbraryManagmentSystem.Properties.Resources.th;
            this.pbPersonImage.Location = new System.Drawing.Point(724, 14);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(219, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 22;
            this.pbPersonImage.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.White;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddUser.Image = global::LIbraryManagmentSystem.Properties.Resources.Add_New_64;
            this.btnAddUser.Location = new System.Drawing.Point(1450, 221);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(65, 65);
            this.btnAddUser.TabIndex = 28;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_add_book_32;
            this.addNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // edToolStripMenuItem
            // 
            this.edToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.edit_32;
            this.edToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edToolStripMenuItem.Name = "edToolStripMenuItem";
            this.edToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.edToolStripMenuItem.Text = "Edit";
            this.edToolStripMenuItem.Click += new System.EventHandler(this.edToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // insertCopiesToolStripMenuItem
            // 
            this.insertCopiesToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_book_32;
            this.insertCopiesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertCopiesToolStripMenuItem.Name = "insertCopiesToolStripMenuItem";
            this.insertCopiesToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.insertCopiesToolStripMenuItem.Text = "Insert Copies";
            this.insertCopiesToolStripMenuItem.Click += new System.EventHandler(this.insertCopiesToolStripMenuItem_Click);
            // 
            // showAllCopiesToolStripMenuItem
            // 
            this.showAllCopiesToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_show_property_32;
            this.showAllCopiesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAllCopiesToolStripMenuItem.Name = "showAllCopiesToolStripMenuItem";
            this.showAllCopiesToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.showAllCopiesToolStripMenuItem.Text = "Show All Copies";
            this.showAllCopiesToolStripMenuItem.Click += new System.EventHandler(this.showAllCopiesToolStripMenuItem_Click);
            // 
            // frmListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1577, 759);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListBooks";
            this.Load += new System.EventHandler(this.frmListBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.cmBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip cmBooks;
        private System.Windows.Forms.ToolStripMenuItem insertCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}