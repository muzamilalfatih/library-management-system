namespace LIbraryManagmentSystem.Books
{
    partial class frmInsertCopies
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNumberOfCopies = new System.Windows.Forms.TextBox();
            this.ctrlBookInfo1 = new LIbraryManagmentSystem.Books.ctrlBookInfo();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(774, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNumberOfCopies
            // 
            this.txtNumberOfCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumberOfCopies.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfCopies.Location = new System.Drawing.Point(616, 290);
            this.txtNumberOfCopies.Name = "txtNumberOfCopies";
            this.txtNumberOfCopies.Size = new System.Drawing.Size(131, 30);
            this.txtNumberOfCopies.TabIndex = 3;
            this.txtNumberOfCopies.TextChanged += new System.EventHandler(this.txtNumberOfCopies_TextChanged);
            this.txtNumberOfCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfCopies_KeyPress);
            // 
            // ctrlBookInfo1
            // 
            this.ctrlBookInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlBookInfo1.Name = "ctrlBookInfo1";
            this.ctrlBookInfo1.Size = new System.Drawing.Size(867, 267);
            this.ctrlBookInfo1.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmInsertCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 339);
            this.Controls.Add(this.ctrlBookInfo1);
            this.Controls.Add(this.txtNumberOfCopies);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInsertCopies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert Copies";
            this.Load += new System.EventHandler(this.frmInsertCopies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNumberOfCopies;
        private ctrlBookInfo ctrlBookInfo1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}