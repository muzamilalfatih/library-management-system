namespace LIbraryManagmentSystem.BookCopies
{
    partial class frmRepairBookCopy
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMaintenaceInfo = new System.Windows.Forms.GroupBox();
            this.txtMaintenanceFees = new System.Windows.Forms.TextBox();
            this.dtpRepaidDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnClose = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.ctrlBookCopyInfoWithFilter1 = new LIbraryManagmentSystem.BookCopies.Controls.ctrlBookCopyInfoWithFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbMaintenaceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(27, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(836, 65);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Repaid Copy";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(147, 92);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(648, 98);
            this.txtDescription.TabIndex = 48;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Description :";
            // 
            // gbMaintenaceInfo
            // 
            this.gbMaintenaceInfo.Controls.Add(this.txtMaintenanceFees);
            this.gbMaintenaceInfo.Controls.Add(this.dtpRepaidDate);
            this.gbMaintenaceInfo.Controls.Add(this.label3);
            this.gbMaintenaceInfo.Controls.Add(this.label1);
            this.gbMaintenaceInfo.Controls.Add(this.txtDescription);
            this.gbMaintenaceInfo.Controls.Add(this.label5);
            this.gbMaintenaceInfo.Enabled = false;
            this.gbMaintenaceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMaintenaceInfo.Location = new System.Drawing.Point(12, 587);
            this.gbMaintenaceInfo.Name = "gbMaintenaceInfo";
            this.gbMaintenaceInfo.Size = new System.Drawing.Size(869, 211);
            this.gbMaintenaceInfo.TabIndex = 49;
            this.gbMaintenaceInfo.TabStop = false;
            this.gbMaintenaceInfo.Text = "Maintenace Info";
            // 
            // txtMaintenanceFees
            // 
            this.txtMaintenanceFees.Location = new System.Drawing.Point(690, 26);
            this.txtMaintenanceFees.Name = "txtMaintenanceFees";
            this.txtMaintenanceFees.Size = new System.Drawing.Size(116, 30);
            this.txtMaintenanceFees.TabIndex = 54;
            this.txtMaintenanceFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintenanceFees_KeyPress);
            this.txtMaintenanceFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaintenanceFees_Validating);
            // 
            // dtpRepaidDate
            // 
            this.dtpRepaidDate.CustomFormat = "dd/M/yyyy";
            this.dtpRepaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRepaidDate.Location = new System.Drawing.Point(147, 39);
            this.dtpRepaidDate.Name = "dtpRepaidDate";
            this.dtpRepaidDate.Size = new System.Drawing.Size(167, 30);
            this.dtpRepaidDate.TabIndex = 53;
            this.dtpRepaidDate.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Maintenance Fees:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "RepairDate :";
            // 
            // bnClose
            // 
            this.bnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(587, 804);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(125, 35);
            this.bnClose.TabIndex = 51;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Enabled = false;
            this.btnRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair.Location = new System.Drawing.Point(749, 804);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(133, 35);
            this.btnRepair.TabIndex = 50;
            this.btnRepair.Text = "Repair";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // ctrlBookCopyInfoWithFilter1
            // 
            this.ctrlBookCopyInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCopyInfoWithFilter1.Location = new System.Drawing.Point(12, 82);
            this.ctrlBookCopyInfoWithFilter1.Name = "ctrlBookCopyInfoWithFilter1";
            this.ctrlBookCopyInfoWithFilter1.Size = new System.Drawing.Size(872, 499);
            this.ctrlBookCopyInfoWithFilter1.TabIndex = 52;
            this.ctrlBookCopyInfoWithFilter1.OnCopySelected += new System.Action<int>(this.ctrlBookCopyInfoWithFilter1_OnCopySelected);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmRepairBookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 851);
            this.Controls.Add(this.ctrlBookCopyInfoWithFilter1);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.gbMaintenaceInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRepairBookCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repair Book Copy";
            this.Activated += new System.EventHandler(this.frmRepairBookCopy_Activated);
            this.Load += new System.EventHandler(this.frmRepairBookCopy_Load);
            this.gbMaintenaceInfo.ResumeLayout(false);
            this.gbMaintenaceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbMaintenaceInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.TextBox txtMaintenanceFees;
        private System.Windows.Forms.DateTimePicker dtpRepaidDate;
        private Controls.ctrlBookCopyInfoWithFilter ctrlBookCopyInfoWithFilter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}