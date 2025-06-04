namespace LIbraryManagmentSystem.Books
{
    partial class frmListCopies
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBookCopies = new System.Windows.Forms.DataGridView();
            this.cmBookCopies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbIsAvailable = new System.Windows.Forms.ComboBox();
            this.cbIsDamaged = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnRepairCopy = new System.Windows.Forms.Button();
            this.btnAddCopies = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).BeginInit();
            this.cmBookCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(317, 270);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(255, 30);
            this.txtFilterValue.TabIndex = 27;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Copy ID",
            "Member ID",
            "Is Available",
            "Is Damaged"});
            this.cbFilterBy.Location = new System.Drawing.Point(101, 270);
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
            this.label1.Location = new System.Drawing.Point(17, 273);
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
            this.lblTitle.Location = new System.Drawing.Point(276, 208);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 40);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Manage Copies";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(754, 706);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(119, 690);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(34, 25);
            this.lblRecordsCount.TabIndex = 31;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 690);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "# Records:";
            // 
            // dgvBookCopies
            // 
            this.dgvBookCopies.AllowUserToAddRows = false;
            this.dgvBookCopies.AllowUserToDeleteRows = false;
            this.dgvBookCopies.AllowUserToOrderColumns = true;
            this.dgvBookCopies.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookCopies.ContextMenuStrip = this.cmBookCopies;
            this.dgvBookCopies.Location = new System.Drawing.Point(15, 303);
            this.dgvBookCopies.Margin = new System.Windows.Forms.Padding(5);
            this.dgvBookCopies.Name = "dgvBookCopies";
            this.dgvBookCopies.ReadOnly = true;
            this.dgvBookCopies.RowHeadersWidth = 51;
            this.dgvBookCopies.RowTemplate.Height = 24;
            this.dgvBookCopies.Size = new System.Drawing.Size(895, 371);
            this.dgvBookCopies.TabIndex = 29;
            // 
            // cmBookCopies
            // 
            this.cmBookCopies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmBookCopies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repairToolStripMenuItem});
            this.cmBookCopies.Name = "cmBookCopies";
            this.cmBookCopies.Size = new System.Drawing.Size(138, 42);
            this.cmBookCopies.Opening += new System.ComponentModel.CancelEventHandler(this.cmBookCopies_Opening);
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsAvailable.FormattingEnabled = true;
            this.cbIsAvailable.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsAvailable.Location = new System.Drawing.Point(317, 270);
            this.cbIsAvailable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(122, 33);
            this.cbIsAvailable.TabIndex = 34;
            this.cbIsAvailable.SelectedIndexChanged += new System.EventHandler(this.cbIsAvailable_SelectedIndexChanged);
            // 
            // cbIsDamaged
            // 
            this.cbIsDamaged.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsDamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsDamaged.FormattingEnabled = true;
            this.cbIsDamaged.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsDamaged.Location = new System.Drawing.Point(317, 270);
            this.cbIsDamaged.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIsDamaged.Name = "cbIsDamaged";
            this.cbIsDamaged.Size = new System.Drawing.Size(122, 33);
            this.cbIsDamaged.TabIndex = 35;
            this.cbIsDamaged.SelectedIndexChanged += new System.EventHandler(this.cbIsDamaged_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnRepairCopy
            // 
            this.btnRepairCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRepairCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepairCopy.Location = new System.Drawing.Point(677, 244);
            this.btnRepairCopy.Name = "btnRepairCopy";
            this.btnRepairCopy.Size = new System.Drawing.Size(135, 36);
            this.btnRepairCopy.TabIndex = 37;
            this.btnRepairCopy.Text = "Repair ";
            this.btnRepairCopy.UseVisualStyleBackColor = true;
            this.btnRepairCopy.Click += new System.EventHandler(this.btnRepairCopy_Click);
            // 
            // btnAddCopies
            // 
            this.btnAddCopies.BackColor = System.Drawing.Color.White;
            this.btnAddCopies.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCopies.FlatAppearance.BorderSize = 0;
            this.btnAddCopies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddCopies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddCopies.Image = global::LIbraryManagmentSystem.Properties.Resources.Add_New_64;
            this.btnAddCopies.Location = new System.Drawing.Point(845, 230);
            this.btnAddCopies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCopies.Name = "btnAddCopies";
            this.btnAddCopies.Size = new System.Drawing.Size(65, 65);
            this.btnAddCopies.TabIndex = 36;
            this.btnAddCopies.UseVisualStyleBackColor = false;
            this.btnAddCopies.Click += new System.EventHandler(this.btnAddCopies_Click_1);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::LIbraryManagmentSystem.Properties.Resources.Users_2_400;
            this.pbPersonImage.Location = new System.Drawing.Point(353, 14);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(219, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 22;
            this.pbPersonImage.TabStop = false;
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_repair_32;
            this.repairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(137, 38);
            this.repairToolStripMenuItem.Text = "Repair";
            this.repairToolStripMenuItem.Click += new System.EventHandler(this.repairToolStripMenuItem_Click);
            // 
            // frmListCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 768);
            this.Controls.Add(this.btnRepairCopy);
            this.Controls.Add(this.btnAddCopies);
            this.Controls.Add(this.cbIsDamaged);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBookCopies);
            this.Controls.Add(this.cbIsAvailable);
            this.Controls.Add(this.txtFilterValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListCopies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListCopies";
            this.Load += new System.EventHandler(this.frmListCopies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).EndInit();
            this.cmBookCopies.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBookCopies;
        private System.Windows.Forms.ContextMenuStrip cmBookCopies;
        private System.Windows.Forms.ComboBox cbIsAvailable;
        private System.Windows.Forms.ComboBox cbIsDamaged;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnAddCopies;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.Button btnRepairCopy;
    }
}