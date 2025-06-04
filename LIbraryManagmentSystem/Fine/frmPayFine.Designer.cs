namespace LIbraryManagmentSystem.Fine
{
    partial class frmPayFine
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
            this.ctrlFineInfo1 = new LIbraryManagmentSystem.Fine.ctrlFineInfo();
            this.gbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.lblPaidByUser = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.bnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(838, 52);
            this.lblTitle.TabIndex = 161;
            this.lblTitle.Text = "Pay Fine";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlFineInfo1
            // 
            this.ctrlFineInfo1.Location = new System.Drawing.Point(-2, 64);
            this.ctrlFineInfo1.Name = "ctrlFineInfo1";
            this.ctrlFineInfo1.Size = new System.Drawing.Size(861, 209);
            this.ctrlFineInfo1.TabIndex = 162;
            // 
            // gbPaymentInfo
            // 
            this.gbPaymentInfo.Controls.Add(this.txtPayAmount);
            this.gbPaymentInfo.Controls.Add(this.lblPaidByUser);
            this.gbPaymentInfo.Controls.Add(this.lblPaymentDate);
            this.gbPaymentInfo.Controls.Add(this.label3);
            this.gbPaymentInfo.Controls.Add(this.label2);
            this.gbPaymentInfo.Controls.Add(this.label1);
            this.gbPaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentInfo.Location = new System.Drawing.Point(12, 279);
            this.gbPaymentInfo.Name = "gbPaymentInfo";
            this.gbPaymentInfo.Size = new System.Drawing.Size(837, 158);
            this.gbPaymentInfo.TabIndex = 163;
            this.gbPaymentInfo.TabStop = false;
            this.gbPaymentInfo.Text = "Payment Info";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(168, 83);
            this.txtPayAmount.Multiline = true;
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(98, 34);
            this.txtPayAmount.TabIndex = 9;
            this.txtPayAmount.TextChanged += new System.EventHandler(this.txtPayAmount_TextChanged);
            this.txtPayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayAmount_KeyPress);
            this.txtPayAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtPayAmount_Validating);
            // 
            // lblPaidByUser
            // 
            this.lblPaidByUser.AutoSize = true;
            this.lblPaidByUser.Location = new System.Drawing.Point(723, 37);
            this.lblPaidByUser.Name = "lblPaidByUser";
            this.lblPaidByUser.Size = new System.Drawing.Size(56, 25);
            this.lblPaidByUser.TabIndex = 6;
            this.lblPaidByUser.Text = "????";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(163, 37);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(56, 25);
            this.lblPaymentDate.TabIndex = 8;
            this.lblPaymentDate.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Paid By User :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pay Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment Date :";
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(716, 454);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(133, 35);
            this.btnPay.TabIndex = 165;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // bnClose
            // 
            this.bnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(567, 454);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(125, 35);
            this.bnClose.TabIndex = 166;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 510);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.gbPaymentInfo);
            this.Controls.Add(this.ctrlFineInfo1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPayFine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPayFine";
            this.Activated += new System.EventHandler(this.frmPayFine_Activated);
            this.Load += new System.EventHandler(this.frmPayFine_Load);
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlFineInfo ctrlFineInfo1;
        private System.Windows.Forms.GroupBox gbPaymentInfo;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label lblPaidByUser;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}