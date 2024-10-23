namespace _DVLD___Project
{
    partial class frmNewLocalDrivingLicenceApplication
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbcAddForm = new System.Windows.Forms.TabControl();
            this.tbpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.cntrlPersonlDetailsWithFillter1 = new _DVLD___Project.cntrlPersonlDetailsWithFillter();
            this.tbpLoginInfo = new System.Windows.Forms.TabPage();
            this.cbLicenceClass = new System.Windows.Forms.ComboBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLocalApplicationID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcAddForm.SuspendLayout();
            this.tbpPersonInfo.SuspendLayout();
            this.tbpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(633, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 53);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(423, 638);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 53);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Malgun Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(700, 50);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "New Local Driving Licence Application";
            // 
            // tbcAddForm
            // 
            this.tbcAddForm.Controls.Add(this.tbpPersonInfo);
            this.tbcAddForm.Controls.Add(this.tbpLoginInfo);
            this.tbcAddForm.Location = new System.Drawing.Point(17, 85);
            this.tbcAddForm.Name = "tbcAddForm";
            this.tbcAddForm.SelectedIndex = 0;
            this.tbcAddForm.Size = new System.Drawing.Size(806, 524);
            this.tbcAddForm.TabIndex = 4;
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
            this.cntrlPersonlDetailsWithFillter1.Location = new System.Drawing.Point(3, 6);
            this.cntrlPersonlDetailsWithFillter1.Name = "cntrlPersonlDetailsWithFillter1";
            this.cntrlPersonlDetailsWithFillter1.Size = new System.Drawing.Size(799, 433);
            this.cntrlPersonlDetailsWithFillter1.TabIndex = 0;
            this.cntrlPersonlDetailsWithFillter1.OnPersonSelected += new System.Action<int>(this.cntrlPersonlDetailsWithFillter1_OnPersonSelected);
            // 
            // tbpLoginInfo
            // 
            this.tbpLoginInfo.Controls.Add(this.cbLicenceClass);
            this.tbpLoginInfo.Controls.Add(this.lbCreatedBy);
            this.tbpLoginInfo.Controls.Add(this.label7);
            this.tbpLoginInfo.Controls.Add(this.lbApplicationFees);
            this.tbpLoginInfo.Controls.Add(this.lbApplicationDate);
            this.tbpLoginInfo.Controls.Add(this.label5);
            this.tbpLoginInfo.Controls.Add(this.label4);
            this.tbpLoginInfo.Controls.Add(this.label3);
            this.tbpLoginInfo.Controls.Add(this.label2);
            this.tbpLoginInfo.Controls.Add(this.lbLocalApplicationID);
            this.tbpLoginInfo.Controls.Add(this.label1);
            this.tbpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tbpLoginInfo.Name = "tbpLoginInfo";
            this.tbpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoginInfo.Size = new System.Drawing.Size(798, 495);
            this.tbpLoginInfo.TabIndex = 1;
            this.tbpLoginInfo.Text = "Application Info";
            this.tbpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenceClass
            // 
            this.cbLicenceClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenceClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenceClass.FormattingEnabled = true;
            this.cbLicenceClass.Location = new System.Drawing.Point(402, 228);
            this.cbLicenceClass.Name = "cbLicenceClass";
            this.cbLicenceClass.Size = new System.Drawing.Size(389, 28);
            this.cbLicenceClass.TabIndex = 14;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(397, 385);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(109, 36);
            this.lbCreatedBy.TabIndex = 13;
            this.lbCreatedBy.Text = "{????}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Created By:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(397, 294);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(109, 36);
            this.lbApplicationFees.TabIndex = 11;
            this.lbApplicationFees.Text = "{????}";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(396, 146);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(109, 36);
            this.lbApplicationDate.TabIndex = 10;
            this.lbApplicationDate.Text = "{????}";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "ApplicationFees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Licence Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application Date:";
            // 
            // lbLocalApplicationID
            // 
            this.lbLocalApplicationID.AutoSize = true;
            this.lbLocalApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalApplicationID.Location = new System.Drawing.Point(397, 72);
            this.lbLocalApplicationID.Name = "lbLocalApplicationID";
            this.lbLocalApplicationID.Size = new System.Drawing.Size(109, 36);
            this.lbLocalApplicationID.TabIndex = 1;
            this.lbLocalApplicationID.Text = "{????}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.ApplicationID:";
            // 
            // frmNewLocalDrivingLicenceApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 712);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbcAddForm);
            this.Name = "frmNewLocalDrivingLicenceApplication";
            this.Text = "New Local Driving Licence Application";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicenceApplication_Load);
            this.tbcAddForm.ResumeLayout(false);
            this.tbpPersonInfo.ResumeLayout(false);
            this.tbpLoginInfo.ResumeLayout(false);
            this.tbpLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tbcAddForm;
        private System.Windows.Forms.TabPage tbpPersonInfo;
        private System.Windows.Forms.Button btnNext;
        private cntrlPersonlDetailsWithFillter cntrlPersonlDetailsWithFillter1;
        private System.Windows.Forms.TabPage tbpLoginInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLocalApplicationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.ComboBox cbLicenceClass;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbApplicationFees;
    }
}