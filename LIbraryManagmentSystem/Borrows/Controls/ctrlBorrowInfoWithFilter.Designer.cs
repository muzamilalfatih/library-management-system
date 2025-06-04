namespace LIbraryManagmentSystem.Borrows.Controls
{
    partial class ctrlBorrowInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBorrowInfo1 = new LIbraryManagmentSystem.Borrows.Controls.ctrlBorrowInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.txtCopyID);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(4, 14);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilters.Size = new System.Drawing.Size(535, 78);
            this.gbFilters.TabIndex = 20;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::LIbraryManagmentSystem.Properties.Resources.icons8_find_32;
            this.btnFind.Location = new System.Drawing.Point(461, 20);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(59, 46);
            this.btnFind.TabIndex = 18;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtCopyID
            // 
            this.txtCopyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCopyID.Location = new System.Drawing.Point(151, 32);
            this.txtCopyID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.Size = new System.Drawing.Size(285, 22);
            this.txtCopyID.TabIndex = 17;
            this.txtCopyID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCopyID_KeyPress);
            this.txtCopyID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCopyID_KeyUp);
            this.txtCopyID.Validating += new System.ComponentModel.CancelEventHandler(this.txtCopyID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Copy ID:";
            // 
            // ctrlBorrowInfo1
            // 
            this.ctrlBorrowInfo1.Location = new System.Drawing.Point(4, 99);
            this.ctrlBorrowInfo1.Name = "ctrlBorrowInfo1";
            this.ctrlBorrowInfo1.Size = new System.Drawing.Size(862, 194);
            this.ctrlBorrowInfo1.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlBorrowInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlBorrowInfo1);
            this.Controls.Add(this.gbFilters);
            this.Name = "ctrlBorrowInfoWithFilter";
            this.Size = new System.Drawing.Size(866, 294);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.Label label1;
        private ctrlBorrowInfo ctrlBorrowInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
