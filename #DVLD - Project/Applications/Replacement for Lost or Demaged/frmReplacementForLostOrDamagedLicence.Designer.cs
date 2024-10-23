namespace _DVLD___Project
{
    partial class frmReplacementForLostOrDamagedLicence
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
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbOldLicneceID = new System.Windows.Forms.Label();
            this.lbReplacedLicneceID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbLRApplicationID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.cntrlDriverLicenceInfoWithFillter1 = new _DVLD___Project.cntrlDriverLicenceInfoWithFillter();
            this.groupBox1.SuspendLayout();
            this.gbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(452, 636);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linklbShowLicenceHistory
            // 
            this.linklbShowLicenceHistory.AutoSize = true;
            this.linklbShowLicenceHistory.Enabled = false;
            this.linklbShowLicenceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceHistory.Location = new System.Drawing.Point(15, 647);
            this.linklbShowLicenceHistory.Name = "linklbShowLicenceHistory";
            this.linklbShowLicenceHistory.Size = new System.Drawing.Size(173, 20);
            this.linklbShowLicenceHistory.TabIndex = 19;
            this.linklbShowLicenceHistory.TabStop = true;
            this.linklbShowLicenceHistory.Text = "Show Licence History";
            this.linklbShowLicenceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceHistory_LinkClicked);
            // 
            // linklbShowLicenceInfo
            // 
            this.linklbShowLicenceInfo.AutoSize = true;
            this.linklbShowLicenceInfo.Enabled = false;
            this.linklbShowLicenceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceInfo.Location = new System.Drawing.Point(269, 647);
            this.linklbShowLicenceInfo.Name = "linklbShowLicenceInfo";
            this.linklbShowLicenceInfo.Size = new System.Drawing.Size(146, 20);
            this.linklbShowLicenceInfo.TabIndex = 18;
            this.linklbShowLicenceInfo.TabStop = true;
            this.linklbShowLicenceInfo.Text = "Show Licence Info";
            this.linklbShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceInfo_LinkClicked);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIssueReplacement.Enabled = false;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.Location = new System.Drawing.Point(626, 636);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(246, 41);
            this.btnIssueReplacement.TabIndex = 17;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.UseVisualStyleBackColor = false;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbOldLicneceID);
            this.groupBox1.Controls.Add(this.lbReplacedLicneceID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbApplicationFees);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.lbLRApplicationID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(-1, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(621, 89);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(48, 20);
            this.lbCreatedBy.TabIndex = 31;
            this.lbCreatedBy.Text = "{???}";
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
            // lbReplacedLicneceID
            // 
            this.lbReplacedLicneceID.AutoSize = true;
            this.lbReplacedLicneceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReplacedLicneceID.Location = new System.Drawing.Point(621, 18);
            this.lbReplacedLicneceID.Name = "lbReplacedLicneceID";
            this.lbReplacedLicneceID.Size = new System.Drawing.Size(48, 20);
            this.lbReplacedLicneceID.TabIndex = 28;
            this.lbReplacedLicneceID.Text = "{???}";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Created By:";
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
            this.label12.Size = new System.Drawing.Size(170, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Replaced Licnece ID:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(187, 89);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(48, 20);
            this.lbApplicationFees.TabIndex = 23;
            this.lbApplicationFees.Text = "{???}";
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
            // lbLRApplicationID
            // 
            this.lbLRApplicationID.AutoSize = true;
            this.lbLRApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLRApplicationID.Location = new System.Drawing.Point(187, 18);
            this.lbLRApplicationID.Name = "lbLRApplicationID";
            this.lbLRApplicationID.Size = new System.Drawing.Size(48, 20);
            this.lbLRApplicationID.TabIndex = 20;
            this.lbLRApplicationID.Text = "{???}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Application Fees:";
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
            this.label5.Text = "L.R Application ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = " Replacement For Lost Or Damaged Licence";
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLost);
            this.gbReplacementFor.Controls.Add(this.rbDamaged);
            this.gbReplacementFor.Location = new System.Drawing.Point(735, 37);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(150, 71);
            this.gbReplacementFor.TabIndex = 21;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement for:";
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Location = new System.Drawing.Point(6, 21);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(53, 20);
            this.rbLost.TabIndex = 1;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Location = new System.Drawing.Point(6, 45);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(89, 20);
            this.rbDamaged.TabIndex = 0;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "Damaged";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // cntrlDriverLicenceInfoWithFillter1
            // 
            this.cntrlDriverLicenceInfoWithFillter1.LicenceID = -1;
            this.cntrlDriverLicenceInfoWithFillter1.Location = new System.Drawing.Point(5, 33);
            this.cntrlDriverLicenceInfoWithFillter1.Name = "cntrlDriverLicenceInfoWithFillter1";
            this.cntrlDriverLicenceInfoWithFillter1.Size = new System.Drawing.Size(880, 461);
            this.cntrlDriverLicenceInfoWithFillter1.TabIndex = 15;
            this.cntrlDriverLicenceInfoWithFillter1.OnLicenceSelected += new System.Action<int>(this.cntrlDriverLicenceInfoWithFillter1_OnLicenceSelected);
            // 
            // frmReplacementForLostOrDamagedLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 684);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linklbShowLicenceHistory);
            this.Controls.Add(this.linklbShowLicenceInfo);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cntrlDriverLicenceInfoWithFillter1);
            this.Controls.Add(this.label1);
            this.Name = "frmReplacementForLostOrDamagedLicence";
            this.Text = "frmReplacementForLostOrDamagedLicence";
            this.Load += new System.EventHandler(this.frmReplacementForLostOrDamagedLicence_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linklbShowLicenceHistory;
        private System.Windows.Forms.LinkLabel linklbShowLicenceInfo;
        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbOldLicneceID;
        private System.Windows.Forms.Label lbReplacedLicneceID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbLRApplicationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private cntrlDriverLicenceInfoWithFillter cntrlDriverLicenceInfoWithFillter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamaged;
    }
}