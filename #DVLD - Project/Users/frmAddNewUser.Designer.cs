namespace _DVLD___Project
{
    partial class frmAddNewUser
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
            this.tbcAddForm = new System.Windows.Forms.TabControl();
            this.tbpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.cntrlPersonlDetailsWithFillter1 = new _DVLD___Project.cntrlPersonlDetailsWithFillter();
            this.tbpLoginInfo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAddNewPerson = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcAddForm.SuspendLayout();
            this.tbpPersonInfo.SuspendLayout();
            this.tbpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcAddForm
            // 
            this.tbcAddForm.Controls.Add(this.tbpPersonInfo);
            this.tbcAddForm.Controls.Add(this.tbpLoginInfo);
            this.tbcAddForm.Location = new System.Drawing.Point(3, 85);
            this.tbcAddForm.Name = "tbcAddForm";
            this.tbcAddForm.SelectedIndex = 0;
            this.tbcAddForm.Size = new System.Drawing.Size(806, 524);
            this.tbcAddForm.TabIndex = 0;
            this.tbcAddForm.TabStop = false;
            // 
            // tbpPersonInfo
            // 
            this.tbpPersonInfo.Controls.Add(this.btnNext);
            this.tbpPersonInfo.Controls.Add(this.cntrlPersonlDetailsWithFillter1);
            this.tbpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tbpPersonInfo.Name = "tbpPersonInfo";
            this.tbpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPersonInfo.Size = new System.Drawing.Size(798, 495);
            this.tbpPersonInfo.TabIndex = 0;
            this.tbpPersonInfo.Text = "Person Info";
            this.tbpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(590, 442);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 47);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cntrlPersonlDetailsWithFillter1
            // 
            this.cntrlPersonlDetailsWithFillter1.FilterEnabled = true;
            this.cntrlPersonlDetailsWithFillter1.Location = new System.Drawing.Point(-1, 6);
            this.cntrlPersonlDetailsWithFillter1.Name = "cntrlPersonlDetailsWithFillter1";
            this.cntrlPersonlDetailsWithFillter1.Size = new System.Drawing.Size(799, 433);
            this.cntrlPersonlDetailsWithFillter1.TabIndex = 0;
            this.cntrlPersonlDetailsWithFillter1.OnPersonSelected += new System.Action<int>(this.cntrlPersonlDetailsWithFillter1_OnPersonSelected);
            // 
            // tbpLoginInfo
            // 
            this.tbpLoginInfo.Controls.Add(this.label5);
            this.tbpLoginInfo.Controls.Add(this.checkBox1);
            this.tbpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tbpLoginInfo.Controls.Add(this.txtPassword);
            this.tbpLoginInfo.Controls.Add(this.txtUserName);
            this.tbpLoginInfo.Controls.Add(this.label4);
            this.tbpLoginInfo.Controls.Add(this.label3);
            this.tbpLoginInfo.Controls.Add(this.label2);
            this.tbpLoginInfo.Controls.Add(this.lbUserID);
            this.tbpLoginInfo.Controls.Add(this.label1);
            this.tbpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tbpLoginInfo.Name = "tbpLoginInfo";
            this.tbpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoginInfo.Size = new System.Drawing.Size(798, 495);
            this.tbpLoginInfo.TabIndex = 1;
            this.tbpLoginInfo.Text = "Login Info";
            this.tbpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 36);
            this.label5.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(392, 366);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Is Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(392, 296);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(175, 38);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(392, 222);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 38);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(392, 150);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(175, 38);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName:";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(304, 76);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(109, 36);
            this.lbUserID.TabIndex = 1;
            this.lbUserID.Text = "{????}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID:";
            // 
            // lbAddNewPerson
            // 
            this.lbAddNewPerson.AutoSize = true;
            this.lbAddNewPerson.Font = new System.Drawing.Font("Malgun Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddNewPerson.ForeColor = System.Drawing.Color.Red;
            this.lbAddNewPerson.Location = new System.Drawing.Point(192, 9);
            this.lbAddNewPerson.Name = "lbAddNewPerson";
            this.lbAddNewPerson.Size = new System.Drawing.Size(405, 62);
            this.lbAddNewPerson.TabIndex = 1;
            this.lbAddNewPerson.Text = "Add New Person";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(409, 638);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 53);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(619, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 53);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 703);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbAddNewPerson);
            this.Controls.Add(this.tbcAddForm);
            this.Name = "frmAddNewUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tbcAddForm.ResumeLayout(false);
            this.tbpPersonInfo.ResumeLayout(false);
            this.tbpLoginInfo.ResumeLayout(false);
            this.tbpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAddForm;
        private System.Windows.Forms.TabPage tbpPersonInfo;
        private System.Windows.Forms.TabPage tbpLoginInfo;
        private System.Windows.Forms.Label lbAddNewPerson;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private cntrlPersonlDetailsWithFillter cntrlPersonlDetailsWithFillter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}