namespace _DVLD___Project
{
    partial class frmRenewDrivingLicence
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
            this.linklbShowLicenceHistory = new System.Windows.Forms.LinkLabel();
            this.linklbShowLicenceInfo = new System.Windows.Forms.LinkLabel();
            this.btnRenew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.lbOldLicneceID = new System.Windows.Forms.Label();
            this.lbRenewedLicneceID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbRLApplicationID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLicneceFees = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cntrlDriverLicenceInfoWithFillter1 = new _DVLD___Project.cntrlDriverLicenceInfoWithFillter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(563, 720);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linklbShowLicenceHistory
            // 
            this.linklbShowLicenceHistory.AutoSize = true;
            this.linklbShowLicenceHistory.Enabled = false;
            this.linklbShowLicenceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceHistory.Location = new System.Drawing.Point(12, 731);
            this.linklbShowLicenceHistory.Name = "linklbShowLicenceHistory";
            this.linklbShowLicenceHistory.Size = new System.Drawing.Size(173, 20);
            this.linklbShowLicenceHistory.TabIndex = 12;
            this.linklbShowLicenceHistory.TabStop = true;
            this.linklbShowLicenceHistory.Text = "Show Licence History";
            this.linklbShowLicenceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceHistory_LinkClicked);
            // 
            // linklbShowLicenceInfo
            // 
            this.linklbShowLicenceInfo.AutoSize = true;
            this.linklbShowLicenceInfo.Enabled = false;
            this.linklbShowLicenceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceInfo.Location = new System.Drawing.Point(266, 731);
            this.linklbShowLicenceInfo.Name = "linklbShowLicenceInfo";
            this.linklbShowLicenceInfo.Size = new System.Drawing.Size(146, 20);
            this.linklbShowLicenceInfo.TabIndex = 11;
            this.linklbShowLicenceInfo.TabStop = true;
            this.linklbShowLicenceInfo.Text = "Show Licence Info";
            this.linklbShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceInfo_LinkClicked);
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(736, 720);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(133, 41);
            this.btnRenew.TabIndex = 10;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbLicneceFees);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbExpirationDate);
            this.groupBox1.Controls.Add(this.lbOldLicneceID);
            this.groupBox1.Controls.Add(this.lbRenewedLicneceID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbApplicationFees);
            this.groupBox1.Controls.Add(this.lbIssueDate);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.lbRLApplicationID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(-4, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 216);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Renew Driving Licence";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(621, 117);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(48, 20);
            this.lbCreatedBy.TabIndex = 31;
            this.lbCreatedBy.Text = "{???}";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDate.Location = new System.Drawing.Point(621, 84);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(48, 20);
            this.lbExpirationDate.TabIndex = 30;
            this.lbExpirationDate.Text = "{???}";
            // 
            // lbOldLicneceID
            // 
            this.lbOldLicneceID.AutoSize = true;
            this.lbOldLicneceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicneceID.Location = new System.Drawing.Point(621, 51);
            this.lbOldLicneceID.Name = "lbOldLicneceID";
            this.lbOldLicneceID.Size = new System.Drawing.Size(48, 20);
            this.lbOldLicneceID.TabIndex = 29;
            this.lbOldLicneceID.Text = "{???}";
            // 
            // lbRenewedLicneceID
            // 
            this.lbRenewedLicneceID.AutoSize = true;
            this.lbRenewedLicneceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewedLicneceID.Location = new System.Drawing.Point(621, 18);
            this.lbRenewedLicneceID.Name = "lbRenewedLicneceID";
            this.lbRenewedLicneceID.Size = new System.Drawing.Size(48, 20);
            this.lbRenewedLicneceID.TabIndex = 28;
            this.lbRenewedLicneceID.Text = "{???}";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Created By:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(418, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Expiration Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(418, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Old Licnece ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Renewed Licnece ID:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(187, 117);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(48, 20);
            this.lbApplicationFees.TabIndex = 23;
            this.lbApplicationFees.Text = "{???}";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDate.Location = new System.Drawing.Point(187, 84);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(48, 20);
            this.lbIssueDate.TabIndex = 22;
            this.lbIssueDate.Text = "{???}";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(187, 51);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(48, 20);
            this.lbApplicationDate.TabIndex = 21;
            this.lbApplicationDate.Text = "{???}";
            // 
            // lbRLApplicationID
            // 
            this.lbRLApplicationID.AutoSize = true;
            this.lbRLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLApplicationID.Location = new System.Drawing.Point(187, 18);
            this.lbRLApplicationID.Name = "lbRLApplicationID";
            this.lbRLApplicationID.Size = new System.Drawing.Size(48, 20);
            this.lbRLApplicationID.TabIndex = 20;
            this.lbRLApplicationID.Text = "{???}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Application Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Issue Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Application Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "R.L Application ID:";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(621, 150);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(48, 20);
            this.lbTotalFees.TabIndex = 35;
            this.lbTotalFees.Text = "{???}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total Fees:";
            // 
            // lbLicneceFees
            // 
            this.lbLicneceFees.AutoSize = true;
            this.lbLicneceFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicneceFees.Location = new System.Drawing.Point(187, 150);
            this.lbLicneceFees.Name = "lbLicneceFees";
            this.lbLicneceFees.Size = new System.Drawing.Size(48, 20);
            this.lbLicneceFees.TabIndex = 33;
            this.lbLicneceFees.Text = "{???}";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Licnece Fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Notes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(749, 32);
            this.textBox1.TabIndex = 37;
            // 
            // cntrlDriverLicenceInfoWithFillter1
            // 
            this.cntrlDriverLicenceInfoWithFillter1.LicenceID = -1;
            this.cntrlDriverLicenceInfoWithFillter1.Location = new System.Drawing.Point(2, 31);
            this.cntrlDriverLicenceInfoWithFillter1.Name = "cntrlDriverLicenceInfoWithFillter1";
            this.cntrlDriverLicenceInfoWithFillter1.Size = new System.Drawing.Size(867, 461);
            this.cntrlDriverLicenceInfoWithFillter1.TabIndex = 8;
            this.cntrlDriverLicenceInfoWithFillter1.Load += new System.EventHandler(this.cntrlDriverLicenceInfoWithFillter1_Load);
            // 
            // frmRenewDrivingLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 760);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linklbShowLicenceHistory);
            this.Controls.Add(this.linklbShowLicenceInfo);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cntrlDriverLicenceInfoWithFillter1);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewDrivingLicence";
            this.Text = "frmRenewDrivingLicence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linklbShowLicenceHistory;
        private System.Windows.Forms.LinkLabel linklbShowLicenceInfo;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.GroupBox groupBox1;
        private cntrlDriverLicenceInfoWithFillter cntrlDriverLicenceInfoWithFillter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLicneceFees;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label lbOldLicneceID;
        private System.Windows.Forms.Label lbRenewedLicneceID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbRLApplicationID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}