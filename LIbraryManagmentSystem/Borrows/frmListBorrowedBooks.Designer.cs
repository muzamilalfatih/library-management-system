namespace LIbraryManagmentSystem.Borrows
{
    partial class frmListBorrowedBooks
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
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBorrows = new System.Windows.Forms.DataGridView();
            this.cmBorrowing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbIsReturned = new System.Windows.Forms.ComboBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).BeginInit();
            this.cmBorrowing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(231, 244);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(264, 30);
            this.txtFilterValue.TabIndex = 37;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Borrow ID",
            "Member ID",
            "Member Name",
            "Book Name",
            "Book Copy ID",
            "Is Returned"});
            this.cbFilterBy.Location = new System.Drawing.Point(15, 244);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(219, 33);
            this.cbFilterBy.TabIndex = 36;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filter By:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(308, 194);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(495, 47);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Manage Borrows";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(133, 667);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(34, 25);
            this.lblRecordsCount.TabIndex = 41;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 667);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "# Records:";
            // 
            // dgvBorrows
            // 
            this.dgvBorrows.AllowUserToAddRows = false;
            this.dgvBorrows.AllowUserToDeleteRows = false;
            this.dgvBorrows.AllowUserToOrderColumns = true;
            this.dgvBorrows.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrows.ContextMenuStrip = this.cmBorrowing;
            this.dgvBorrows.Location = new System.Drawing.Point(15, 285);
            this.dgvBorrows.Margin = new System.Windows.Forms.Padding(5);
            this.dgvBorrows.Name = "dgvBorrows";
            this.dgvBorrows.ReadOnly = true;
            this.dgvBorrows.RowHeadersWidth = 51;
            this.dgvBorrows.RowTemplate.Height = 24;
            this.dgvBorrows.Size = new System.Drawing.Size(1090, 371);
            this.dgvBorrows.TabIndex = 39;
            // 
            // cmBorrowing
            // 
            this.cmBorrowing.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmBorrowing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBookToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.cmBorrowing.Name = "cmBorrowing";
            this.cmBorrowing.Size = new System.Drawing.Size(181, 80);
            this.cmBorrowing.Opening += new System.ComponentModel.CancelEventHandler(this.cmBorrowing_Opening);
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_borrow_book_32__1_;
            this.borrowBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.borrowBookToolStripMenuItem.Text = "Borrow Book";
            this.borrowBookToolStripMenuItem.Click += new System.EventHandler(this.borrowBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_return_book_32__1_;
            this.returnBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.returnBookToolStripMenuItem.Text = "Return";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(961, 667);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 36);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbIsReturned
            // 
            this.cbIsReturned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsReturned.FormattingEnabled = true;
            this.cbIsReturned.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReturned.Location = new System.Drawing.Point(231, 244);
            this.cbIsReturned.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIsReturned.Name = "cbIsReturned";
            this.cbIsReturned.Size = new System.Drawing.Size(122, 33);
            this.cbIsReturned.TabIndex = 43;
            this.cbIsReturned.SelectedIndexChanged += new System.EventHandler(this.cbIsReturned_SelectedIndexChanged);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_borrow_book_32;
            this.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrow.Location = new System.Drawing.Point(961, 238);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(144, 36);
            this.btnBorrow.TabIndex = 45;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_return_book_32;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(808, 238);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 36);
            this.btnReturn.TabIndex = 46;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::LIbraryManagmentSystem.Properties.Resources.borrow___512;
            this.pbPersonImage.Location = new System.Drawing.Point(439, 0);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(228, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 33;
            this.pbPersonImage.TabStop = false;
            // 
            // frmListBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 707);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.cbIsReturned);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBorrows);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListBorrowedBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Borrowed Books";
            this.Load += new System.EventHandler(this.frmListBorrowedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).EndInit();
            this.cmBorrowing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBorrows;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbIsReturned;
        private System.Windows.Forms.ContextMenuStrip cmBorrowing;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
    }
}