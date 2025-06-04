namespace LIbraryManagmentSystem.Members.Controls
{
    partial class ctrlMemberInfoWithFilter
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
            this.ctrlMemberInfo1 = new LIbraryManagmentSystem.Members.Controls.ctrlMemberInfo();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlMemberInfo1
            // 
            this.ctrlMemberInfo1.Location = new System.Drawing.Point(19, 103);
            this.ctrlMemberInfo1.Name = "ctrlMemberInfo1";
            this.ctrlMemberInfo1.Size = new System.Drawing.Size(893, 642);
            this.ctrlMemberInfo1.TabIndex = 0;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.txtMemberID);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(19, 18);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilters.Size = new System.Drawing.Size(535, 78);
            this.gbFilters.TabIndex = 19;
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
            // txtMemberID
            // 
            this.txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberID.Location = new System.Drawing.Point(151, 32);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(285, 22);
            this.txtMemberID.TabIndex = 17;
            this.txtMemberID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberID_KeyPress_1);
            this.txtMemberID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemberID_KeyUp);
            this.txtMemberID.Validating += new System.ComponentModel.CancelEventHandler(this.txtMemberID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "MemberID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlMemberInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.ctrlMemberInfo1);
            this.Name = "ctrlMemberInfoWithFilter";
            this.Size = new System.Drawing.Size(910, 745);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMemberInfo ctrlMemberInfo1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
