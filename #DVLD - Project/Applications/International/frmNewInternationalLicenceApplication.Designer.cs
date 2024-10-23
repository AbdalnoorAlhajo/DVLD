namespace _DVLD___Project
{
    partial class frmNewInternationalLicenceApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cntrlInternationalApplicationInfo1 = new _DVLD___Project.cntrlInternationalApplicationInfo();
            this.cntrlDriverLicenceInfoWithFillter1 = new _DVLD___Project.cntrlDriverLicenceInfoWithFillter();
            this.btnIssue = new System.Windows.Forms.Button();
            this.linklbShowLicenceInfo = new System.Windows.Forms.LinkLabel();
            this.linklbShowLicenceHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "International Licence Application";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cntrlInternationalApplicationInfo1);
            this.groupBox1.Location = new System.Drawing.Point(-4, 541);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // cntrlInternationalApplicationInfo1
            // 
            this.cntrlInternationalApplicationInfo1.Location = new System.Drawing.Point(39, 21);
            this.cntrlInternationalApplicationInfo1.Name = "cntrlInternationalApplicationInfo1";
            this.cntrlInternationalApplicationInfo1.Size = new System.Drawing.Size(729, 129);
            this.cntrlInternationalApplicationInfo1.TabIndex = 3;
            // 
            // cntrlDriverLicenceInfoWithFillter1
            // 
            this.cntrlDriverLicenceInfoWithFillter1.LicenceID = -1;
            this.cntrlDriverLicenceInfoWithFillter1.Location = new System.Drawing.Point(2, 44);
            this.cntrlDriverLicenceInfoWithFillter1.Name = "cntrlDriverLicenceInfoWithFillter1";
            this.cntrlDriverLicenceInfoWithFillter1.Size = new System.Drawing.Size(867, 496);
            this.cntrlDriverLicenceInfoWithFillter1.TabIndex = 1;
            this.cntrlDriverLicenceInfoWithFillter1.OnLicenceSelected += new System.Action<int>(this.cntrlDriverLicenceInfoWithFillter1_OnLicenceSelected);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIssue.Enabled = false;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(733, 710);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(133, 47);
            this.btnIssue.TabIndex = 3;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // linklbShowLicenceInfo
            // 
            this.linklbShowLicenceInfo.AutoSize = true;
            this.linklbShowLicenceInfo.Enabled = false;
            this.linklbShowLicenceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceInfo.Location = new System.Drawing.Point(263, 722);
            this.linklbShowLicenceInfo.Name = "linklbShowLicenceInfo";
            this.linklbShowLicenceInfo.Size = new System.Drawing.Size(146, 20);
            this.linklbShowLicenceInfo.TabIndex = 4;
            this.linklbShowLicenceInfo.TabStop = true;
            this.linklbShowLicenceInfo.Text = "Show Licence Info";
            this.linklbShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceInfo_LinkClicked);
            // 
            // linklbShowLicenceHistory
            // 
            this.linklbShowLicenceHistory.AutoSize = true;
            this.linklbShowLicenceHistory.Enabled = false;
            this.linklbShowLicenceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceHistory.Location = new System.Drawing.Point(21, 722);
            this.linklbShowLicenceHistory.Name = "linklbShowLicenceHistory";
            this.linklbShowLicenceHistory.Size = new System.Drawing.Size(173, 20);
            this.linklbShowLicenceHistory.TabIndex = 5;
            this.linklbShowLicenceHistory.TabStop = true;
            this.linklbShowLicenceHistory.Text = "Show Licence History";
            this.linklbShowLicenceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(567, 710);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 47);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNewInternationalLicenceApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 761);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linklbShowLicenceHistory);
            this.Controls.Add(this.linklbShowLicenceInfo);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cntrlDriverLicenceInfoWithFillter1);
            this.Controls.Add(this.label1);
            this.Name = "frmNewInternationalLicenceApplication";
            this.Text = "New International Licence Application";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private cntrlDriverLicenceInfoWithFillter cntrlDriverLicenceInfoWithFillter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private cntrlInternationalApplicationInfo cntrlInternationalApplicationInfo1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.LinkLabel linklbShowLicenceInfo;
        private System.Windows.Forms.LinkLabel linklbShowLicenceHistory;
        private System.Windows.Forms.Button btnClose;
    }
}