namespace LIbraryManagmentSystem.Fine
{
    partial class frmListFines
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
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.cmFines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbIsPaid = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.cmFines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(221, 308);
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
            "Fine ID",
            "Member ID",
            "Borrow ID",
            "Fine Amount",
            "Is Paid",
            "Fine Reason"});
            this.cbFilterBy.Location = new System.Drawing.Point(5, 308);
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
            this.label1.Location = new System.Drawing.Point(2, 272);
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
            this.lblTitle.Location = new System.Drawing.Point(11, 208);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1266, 54);
            this.lblTitle.TabIndex = 48;
            this.lblTitle.Text = "Manage Fines\r\n\r\n\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(123, 731);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(34, 25);
            this.lblRecordsCount.TabIndex = 54;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 731);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "# Records:";
            // 
            // dgvFines
            // 
            this.dgvFines.AllowUserToAddRows = false;
            this.dgvFines.AllowUserToDeleteRows = false;
            this.dgvFines.AllowUserToOrderColumns = true;
            this.dgvFines.BackgroundColor = System.Drawing.Color.White;
            this.dgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFines.ContextMenuStrip = this.cmFines;
            this.dgvFines.Location = new System.Drawing.Point(5, 349);
            this.dgvFines.Margin = new System.Windows.Forms.Padding(5);
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.ReadOnly = true;
            this.dgvFines.RowHeadersWidth = 51;
            this.dgvFines.RowTemplate.Height = 24;
            this.dgvFines.Size = new System.Drawing.Size(1278, 371);
            this.dgvFines.TabIndex = 52;
            // 
            // cmFines
            // 
            this.cmFines.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmFines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payToolStripMenuItem});
            this.cmFines.Name = "cmFines";
            this.cmFines.Size = new System.Drawing.Size(117, 42);
            this.cmFines.Opening += new System.ComponentModel.CancelEventHandler(this.cmFines_Opening);
            // 
            // cbIsPaid
            // 
            this.cbIsPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsPaid.FormattingEnabled = true;
            this.cbIsPaid.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsPaid.Location = new System.Drawing.Point(221, 308);
            this.cbIsPaid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIsPaid.Name = "cbIsPaid";
            this.cbIsPaid.Size = new System.Drawing.Size(122, 33);
            this.cbIsPaid.TabIndex = 56;
            this.cbIsPaid.SelectedIndexChanged += new System.EventHandler(this.cbIsPaid_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1139, 725);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 36);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_pay_32;
            this.payToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(116, 38);
            this.payToolStripMenuItem.Text = "Pay";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.payToolStripMenuItem_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::LIbraryManagmentSystem.Properties.Resources.Fine___512;
            this.pbPersonImage.Location = new System.Drawing.Point(563, 14);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(228, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 47;
            this.pbPersonImage.TabStop = false;
            // 
            // frmListFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 778);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFines);
            this.Controls.Add(this.cbIsPaid);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFilterValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListFines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Fines";
            this.Load += new System.EventHandler(this.frmListFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.cmFines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.ComboBox cbIsPaid;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmFines;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
    }
}