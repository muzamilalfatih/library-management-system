namespace LIbraryManagmentSystem.Users
{
    partial class frmAddNewUpdateUser
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
            LIbraryManagmentSystem_Business.clsPerson clsPerson1 = new LIbraryManagmentSystem_Business.clsPerson();
            LIbraryManagmentSystem_Business.clsPerson clsPerson2 = new LIbraryManagmentSystem_Business.clsPerson();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAdim = new System.Windows.Forms.RadioButton();
            this.rbLibrarain = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.ctrlPersonInfo1 = new LIbraryManagmentSystem.People.Controls.ctrlPersonInfo();
            this.ctrlPersonInfo2 = new LIbraryManagmentSystem.People.Controls.ctrlPersonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(203, 41);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 25);
            this.lblUserID.TabIndex = 142;
            this.lblUserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 141;
            this.label4.Text = "UserID:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkIsActive.Location = new System.Drawing.Point(655, 128);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(108, 29);
            this.chkIsActive.TabIndex = 140;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(693, 76);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(167, 30);
            this.txtConfirmPassword.TabIndex = 137;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 133;
            this.label1.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 138;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 134;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(693, 40);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 30);
            this.txtPassword.TabIndex = 132;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 146;
            this.label5.Text = "Role:";
            // 
            // rbAdim
            // 
            this.rbAdim.AutoSize = true;
            this.rbAdim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAdim.Location = new System.Drawing.Point(190, 142);
            this.rbAdim.Name = "rbAdim";
            this.rbAdim.Size = new System.Drawing.Size(89, 29);
            this.rbAdim.TabIndex = 147;
            this.rbAdim.Text = "Admin";
            this.rbAdim.UseVisualStyleBackColor = true;
            // 
            // rbLibrarain
            // 
            this.rbLibrarain.AutoSize = true;
            this.rbLibrarain.Checked = true;
            this.rbLibrarain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbLibrarain.Location = new System.Drawing.Point(319, 142);
            this.rbLibrarain.Name = "rbLibrarain";
            this.rbLibrarain.Size = new System.Drawing.Size(108, 29);
            this.rbLibrarain.TabIndex = 148;
            this.rbLibrarain.TabStop = true;
            this.rbLibrarain.Text = "Librarian";
            this.rbLibrarain.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(208, 76);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(167, 30);
            this.txtUserName.TabIndex = 150;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating_1);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::LIbraryManagmentSystem.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(640, 645);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 37);
            this.btnClose.TabIndex = 145;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddUpdate.Image = global::LIbraryManagmentSystem.Properties.Resources.Add_32;
            this.btnAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUpdate.Location = new System.Drawing.Point(802, 645);
            this.btnAddUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(148, 37);
            this.btnAddUpdate.TabIndex = 144;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LIbraryManagmentSystem.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(163, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 143;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIbraryManagmentSystem.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(655, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::LIbraryManagmentSystem.Properties.Resources.User_32__2;
            this.pictureBox8.Location = new System.Drawing.Point(163, 77);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 136;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LIbraryManagmentSystem.Properties.Resources.Password_322;
            this.pictureBox3.Location = new System.Drawing.Point(655, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 135;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LIbraryManagmentSystem.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(145, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 151;
            this.pictureBox4.TabStop = false;
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.label3);
            this.gbUserInfo.Controls.Add(this.pictureBox4);
            this.gbUserInfo.Controls.Add(this.pictureBox3);
            this.gbUserInfo.Controls.Add(this.txtUserName);
            this.gbUserInfo.Controls.Add(this.pictureBox8);
            this.gbUserInfo.Controls.Add(this.pictureBox2);
            this.gbUserInfo.Controls.Add(this.rbLibrarain);
            this.gbUserInfo.Controls.Add(this.pictureBox1);
            this.gbUserInfo.Controls.Add(this.rbAdim);
            this.gbUserInfo.Controls.Add(this.txtPassword);
            this.gbUserInfo.Controls.Add(this.label5);
            this.gbUserInfo.Controls.Add(this.label2);
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Controls.Add(this.txtConfirmPassword);
            this.gbUserInfo.Controls.Add(this.chkIsActive);
            this.gbUserInfo.Controls.Add(this.lblUserID);
            this.gbUserInfo.Controls.Add(this.label4);
            this.gbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserInfo.Location = new System.Drawing.Point(5, 442);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(951, 195);
            this.gbUserInfo.TabIndex = 152;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfo1.Mode = 0;
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            clsPerson1.Address = "";
            clsPerson1.Email = "";
            clsPerson1.FirstName = "";
            clsPerson1.Gender = LIbraryManagmentSystem_Business.clsPerson.enGender.Male;
            clsPerson1.LastName = "";
            clsPerson1.NationalNo = "";
            clsPerson1.PersonID = -1;
            clsPerson1.Phone = "";
            clsPerson1.SecondName = "";
            clsPerson1.ThirdName = "";
            this.ctrlPersonInfo1.PersonInfo = clsPerson1;
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(956, 436);
            this.ctrlPersonInfo1.TabIndex = 149;
            // 
            // ctrlPersonInfo2
            // 
            this.ctrlPersonInfo2.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfo2.Mode = 0;
            this.ctrlPersonInfo2.Name = "ctrlPersonInfo2";
            clsPerson2.Address = "";
            clsPerson2.Email = "";
            clsPerson2.FirstName = "";
            clsPerson2.Gender = LIbraryManagmentSystem_Business.clsPerson.enGender.Male;
            clsPerson2.LastName = "";
            clsPerson2.NationalNo = "";
            clsPerson2.PersonID = -1;
            clsPerson2.Phone = "";
            clsPerson2.SecondName = "";
            clsPerson2.ThirdName = "";
            this.ctrlPersonInfo2.PersonInfo = clsPerson2;
            this.ctrlPersonInfo2.Size = new System.Drawing.Size(956, 436);
            this.ctrlPersonInfo2.TabIndex = 0;
            // 
            // frmAddNewUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 705);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New User";
            this.Activated += new System.EventHandler(this.frmAddNewUpdateUser_Activated);
            this.Load += new System.EventHandler(this.frmAddNewUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonInfo ctrlPersonInfo2;
        private People.Controls.ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbAdim;
        private System.Windows.Forms.RadioButton rbLibrarain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox gbUserInfo;
    }
}