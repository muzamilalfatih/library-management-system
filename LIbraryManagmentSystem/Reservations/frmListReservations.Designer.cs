namespace LIbraryManagmentSystem.Reservations
{
    partial class frmListReservations
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.cmReservation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBorrow = new System.Windows.Forms.Button();
            this.cbReservationStatus = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.cmReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(230, 296);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(264, 30);
            this.txtFilterValue.TabIndex = 51;
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
            "Reservation ID",
            "Member ID",
            "Book ID",
            "Reservation Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(14, 296);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(219, 33);
            this.cbFilterBy.TabIndex = 50;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Filter By:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(-5, 214);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(731, 47);
            this.lblTitle.TabIndex = 48;
            this.lblTitle.Text = "Manage Reservations";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(132, 719);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(34, 25);
            this.lblRecordsCount.TabIndex = 54;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 719);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "# Records:";
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AllowUserToOrderColumns = true;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.ContextMenuStrip = this.cmReservation;
            this.dgvReservations.Location = new System.Drawing.Point(14, 337);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(5);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(739, 371);
            this.dgvReservations.TabIndex = 52;
            // 
            // cmReservation
            // 
            this.cmReservation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmReservation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBookToolStripMenuItem,
            this.cancellToolStripMenuItem});
            this.cmReservation.Name = "cmBorrowing";
            this.cmReservation.Size = new System.Drawing.Size(181, 80);
            this.cmReservation.Opening += new System.ComponentModel.CancelEventHandler(this.cmReservation_Opening);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(648, 293);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(105, 36);
            this.btnBorrow.TabIndex = 57;
            this.btnBorrow.Text = "Reserve ";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // cbReservationStatus
            // 
            this.cbReservationStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "All",
            "Pending",
            "Available",
            "Complete",
            "Cancelled"});
            this.cbReservationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbReservationStatus.FormattingEnabled = true;
            this.cbReservationStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Available",
            "Complete",
            "Cancelled"});
            this.cbReservationStatus.Location = new System.Drawing.Point(230, 296);
            this.cbReservationStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbReservationStatus.Name = "cbReservationStatus";
            this.cbReservationStatus.Size = new System.Drawing.Size(122, 33);
            this.cbReservationStatus.TabIndex = 56;
            this.cbReservationStatus.SelectedIndexChanged += new System.EventHandler(this.cbReservationStatus_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(609, 716);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 36);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::LIbraryManagmentSystem.Properties.Resources.books_512;
            this.pbPersonImage.Location = new System.Drawing.Point(239, 20);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(228, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 47;
            this.pbPersonImage.TabStop = false;
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
            // cancellToolStripMenuItem
            // 
            this.cancellToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_cancel_32;
            this.cancellToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancellToolStripMenuItem.Name = "cancellToolStripMenuItem";
            this.cancellToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.cancellToolStripMenuItem.Text = "Cancel";
            this.cancellToolStripMenuItem.Click += new System.EventHandler(this.cancellToolStripMenuItem_Click);
            // 
            // frmListReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 755);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.cbReservationStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFilterValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Reservations";
            this.Load += new System.EventHandler(this.frmListReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.cmReservation.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.ContextMenuStrip cmReservation;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.ComboBox cbReservationStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem cancellToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}