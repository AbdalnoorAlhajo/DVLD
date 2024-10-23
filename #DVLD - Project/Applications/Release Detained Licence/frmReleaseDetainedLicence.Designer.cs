namespace _DVLD___Project
{
    partial class frmReleaseDetainedLicence
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.linklbShowLicenceHistory = new System.Windows.Forms.LinkLabel();
            this.linklbShowLicenceInfo = new System.Windows.Forms.LinkLabel();
            this.btnRelease = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbLicneceID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cntrlDriverLicenceInfoWithFillter1 = new _DVLD___Project.cntrlDriverLicenceInfoWithFillter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 36);
            this.label1.TabIndex = 34;
            this.label1.Text = "Release Detain Licence";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(556, 672);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linklbShowLicenceHistory
            // 
            this.linklbShowLicenceHistory.AutoSize = true;
            this.linklbShowLicenceHistory.Enabled = false;
            this.linklbShowLicenceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceHistory.Location = new System.Drawing.Point(22, 687);
            this.linklbShowLicenceHistory.Name = "linklbShowLicenceHistory";
            this.linklbShowLicenceHistory.Size = new System.Drawing.Size(173, 20);
            this.linklbShowLicenceHistory.TabIndex = 32;
            this.linklbShowLicenceHistory.TabStop = true;
            this.linklbShowLicenceHistory.Text = "Show Licence History";
            this.linklbShowLicenceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceHistory_LinkClicked);
            // 
            // linklbShowLicenceInfo
            // 
            this.linklbShowLicenceInfo.AutoSize = true;
            this.linklbShowLicenceInfo.Enabled = false;
            this.linklbShowLicenceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceInfo.Location = new System.Drawing.Point(276, 687);
            this.linklbShowLicenceInfo.Name = "linklbShowLicenceInfo";
            this.linklbShowLicenceInfo.Size = new System.Drawing.Size(146, 20);
            this.linklbShowLicenceInfo.TabIndex = 31;
            this.linklbShowLicenceInfo.TabStop = true;
            this.linklbShowLicenceInfo.Text = "Show Licence Info";
            this.linklbShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceInfo_LinkClicked);
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRelease.Enabled = false;
            this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.Location = new System.Drawing.Point(736, 672);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(142, 41);
            this.btnRelease.TabIndex = 30;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.lbApplicationFees);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbApplicationID);
            this.groupBox1.Controls.Add(this.lbFineFees);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbLicneceID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbDetainDate);
            this.groupBox1.Controls.Add(this.lbDetainID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 139);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(187, 111);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(48, 20);
            this.lbTotalFees.TabIndex = 38;
            this.lbTotalFees.Text = "{???}";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(187, 80);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(48, 20);
            this.lbApplicationFees.TabIndex = 37;
            this.lbApplicationFees.Text = "{???}";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Total Fees:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Application Fees:";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(622, 111);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(48, 20);
            this.lbApplicationID.TabIndex = 34;
            this.lbApplicationID.Text = "{???}";
            // 
            // lbFineFees
            // 
            this.lbFineFees.AutoSize = true;
            this.lbFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineFees.Location = new System.Drawing.Point(622, 80);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(48, 20);
            this.lbFineFees.TabIndex = 33;
            this.lbFineFees.Text = "{???}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Application ID:";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(622, 49);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(48, 20);
            this.lbCreatedBy.TabIndex = 31;
            this.lbCreatedBy.Text = "{???}";
            // 
            // lbLicneceID
            // 
            this.lbLicneceID.AutoSize = true;
            this.lbLicneceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicneceID.Location = new System.Drawing.Point(622, 18);
            this.lbLicneceID.Name = "lbLicneceID";
            this.lbLicneceID.Size = new System.Drawing.Size(48, 20);
            this.lbLicneceID.TabIndex = 29;
            this.lbLicneceID.Text = "{???}";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Created By:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(422, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Licnece ID:";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(187, 49);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(48, 20);
            this.lbDetainDate.TabIndex = 21;
            this.lbDetainDate.Text = "{???}";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(187, 18);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(48, 20);
            this.lbDetainID.TabIndex = 20;
            this.lbDetainID.Text = "{???}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fine Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Detain Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Detain ID:";
            // 
            // cntrlDriverLicenceInfoWithFillter1
            // 
            this.cntrlDriverLicenceInfoWithFillter1.LicenceID = -1;
            this.cntrlDriverLicenceInfoWithFillter1.Location = new System.Drawing.Point(12, 57);
            this.cntrlDriverLicenceInfoWithFillter1.Name = "cntrlDriverLicenceInfoWithFillter1";
            this.cntrlDriverLicenceInfoWithFillter1.Size = new System.Drawing.Size(880, 461);
            this.cntrlDriverLicenceInfoWithFillter1.TabIndex = 28;
            this.cntrlDriverLicenceInfoWithFillter1.OnLicenceSelected += new System.Action<int>(this.cntrlDriverLicenceInfoWithFillter1_OnLicenceSelected);
            // 
            // frmReleaseDetainedLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linklbShowLicenceHistory);
            this.Controls.Add(this.linklbShowLicenceInfo);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cntrlDriverLicenceInfoWithFillter1);
            this.Name = "frmReleaseDetainedLicence";
            this.Text = "frmReleaseDetainedLicence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linklbShowLicenceHistory;
        private System.Windows.Forms.LinkLabel linklbShowLicenceInfo;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbLicneceID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private cntrlDriverLicenceInfoWithFillter cntrlDriverLicenceInfoWithFillter1;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.Label label4;
    }
}