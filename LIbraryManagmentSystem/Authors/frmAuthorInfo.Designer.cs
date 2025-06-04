namespace LIbraryManagmentSystem.Authors
{
    partial class frmAuthorInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlAuthorCard1 = new LIbraryManagmentSystem.Authors.controls.ctrlAuthorCard();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(751, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlAuthorCard1
            // 
            this.ctrlAuthorCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAuthorCard1.Name = "ctrlAuthorCard1";
            this.ctrlAuthorCard1.Size = new System.Drawing.Size(874, 398);
            this.ctrlAuthorCard1.TabIndex = 0;
            // 
            // frmAuthorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 470);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlAuthorCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAuthorInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Author Information";
            this.Load += new System.EventHandler(this.frmAuthorInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.ctrlAuthorCard ctrlAuthorCard1;
        private System.Windows.Forms.Button btnClose;
    }
}