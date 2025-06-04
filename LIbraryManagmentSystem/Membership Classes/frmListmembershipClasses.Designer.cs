namespace LIbraryManagmentSystem.Membership_Classes
{
    partial class frmListmembershipClasses
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMembershipClasses = new System.Windows.Forms.DataGridView();
            this.cmMembershipClass = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddMembershipClass = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipClasses)).BeginInit();
            this.cmMembershipClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(114, 216);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(616, 55);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "Manage Membership Classess";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(117, 690);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(34, 25);
            this.lblRecordsCount.TabIndex = 48;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 690);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "# Records:";
            // 
            // dgvMembershipClasses
            // 
            this.dgvMembershipClasses.AllowUserToAddRows = false;
            this.dgvMembershipClasses.AllowUserToDeleteRows = false;
            this.dgvMembershipClasses.AllowUserToOrderColumns = true;
            this.dgvMembershipClasses.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembershipClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembershipClasses.ContextMenuStrip = this.cmMembershipClass;
            this.dgvMembershipClasses.Location = new System.Drawing.Point(13, 303);
            this.dgvMembershipClasses.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMembershipClasses.Name = "dgvMembershipClasses";
            this.dgvMembershipClasses.ReadOnly = true;
            this.dgvMembershipClasses.RowHeadersWidth = 51;
            this.dgvMembershipClasses.RowTemplate.Height = 24;
            this.dgvMembershipClasses.Size = new System.Drawing.Size(866, 371);
            this.dgvMembershipClasses.TabIndex = 46;
            // 
            // cmMembershipClass
            // 
            this.cmMembershipClass.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmMembershipClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmMembershipClass.Name = "cmMembershipClass";
            this.cmMembershipClass.Size = new System.Drawing.Size(139, 118);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_add_properties_32;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 38);
            this.toolStripMenuItem1.Text = "Add";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(138, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::LIbraryManagmentSystem.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(744, 682);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddMembershipClass
            // 
            this.btnAddMembershipClass.BackColor = System.Drawing.Color.White;
            this.btnAddMembershipClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddMembershipClass.FlatAppearance.BorderSize = 0;
            this.btnAddMembershipClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddMembershipClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddMembershipClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMembershipClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddMembershipClass.Image = global::LIbraryManagmentSystem.Properties.Resources.Add_New_64;
            this.btnAddMembershipClass.Location = new System.Drawing.Point(814, 217);
            this.btnAddMembershipClass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddMembershipClass.Name = "btnAddMembershipClass";
            this.btnAddMembershipClass.Size = new System.Drawing.Size(65, 65);
            this.btnAddMembershipClass.TabIndex = 50;
            this.btnAddMembershipClass.UseVisualStyleBackColor = false;
            this.btnAddMembershipClass.Click += new System.EventHandler(this.btnAddMembershipClass_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::LIbraryManagmentSystem.Properties.Resources.books_512;
            this.pbPersonImage.Location = new System.Drawing.Point(281, 22);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(219, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 43;
            this.pbPersonImage.TabStop = false;
            // 
            // frmListmembershipClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 732);
            this.Controls.Add(this.btnAddMembershipClass);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMembershipClasses);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListmembershipClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Membership Classes";
            this.Load += new System.EventHandler(this.frmListmembershipClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipClasses)).EndInit();
            this.cmMembershipClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMembershipClasses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmMembershipClass;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnAddMembershipClass;
    }
}