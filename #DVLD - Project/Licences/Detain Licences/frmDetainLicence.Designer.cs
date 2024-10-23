namespace _DVLD___Project
{
    partial class frmDetainLicence
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
            this.btnDetain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbLicneceID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cntrlDriverLicenceInfoWithFillter1 = new _DVLD___Project.cntrlDriverLicenceInfoWithFillter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(574, 651);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linklbShowLicenceHistory
            // 
            this.linklbShowLicenceHistory.AutoSize = true;
            this.linklbShowLicenceHistory.Enabled = false;
            this.linklbShowLicenceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceHistory.Location = new System.Drawing.Point(19, 655);
            this.linklbShowLicenceHistory.Name = "linklbShowLicenceHistory";
            this.linklbShowLicenceHistory.Size = new System.Drawing.Size(173, 20);
            this.linklbShowLicenceHistory.TabIndex = 25;
            this.linklbShowLicenceHistory.TabStop = true;
            this.linklbShowLicenceHistory.Text = "Show Licence History";
            this.linklbShowLicenceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceHistory_LinkClicked);
            // 
            // linklbShowLicenceInfo
            // 
            this.linklbShowLicenceInfo.AutoSize = true;
            this.linklbShowLicenceInfo.Enabled = false;
            this.linklbShowLicenceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceInfo.Location = new System.Drawing.Point(273, 655);
            this.linklbShowLicenceInfo.Name = "linklbShowLicenceInfo";
            this.linklbShowLicenceInfo.Size = new System.Drawing.Size(146, 20);
            this.linklbShowLicenceInfo.TabIndex = 24;
            this.linklbShowLicenceInfo.TabStop = true;
            this.linklbShowLicenceInfo.Text = "Show Licence Info";
            this.linklbShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceInfo_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDetain.Enabled = false;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Location = new System.Drawing.Point(748, 651);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(127, 41);
            this.btnDetain.TabIndex = 23;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFineFees);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbLicneceID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbDetainDate);
            this.groupBox1.Controls.Add(this.lbDetainID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 132);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(191, 89);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(206, 22);
            this.txtFineFees.TabIndex = 32;
            this.txtFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineFees_KeyPress);
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(622, 56);
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
            this.label9.Location = new System.Drawing.Point(419, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Created By:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(419, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Licnece ID:";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(187, 51);
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
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fine Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 51);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Detain Licence";
            // 
            // cntrlDriverLicenceInfoWithFillter1
            // 
            this.cntrlDriverLicenceInfoWithFillter1.LicenceID = -1;
            this.cntrlDriverLicenceInfoWithFillter1.Location = new System.Drawing.Point(9, 41);
            this.cntrlDriverLicenceInfoWithFillter1.Name = "cntrlDriverLicenceInfoWithFillter1";
            this.cntrlDriverLicenceInfoWithFillter1.Size = new System.Drawing.Size(880, 461);
            this.cntrlDriverLicenceInfoWithFillter1.TabIndex = 21;
            this.cntrlDriverLicenceInfoWithFillter1.OnLicenceSelected += new System.Action<int>(this.cntrlDriverLicenceInfoWithFillter1_OnLicenceSelected);
            // 
            // frmDetainLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linklbShowLicenceHistory);
            this.Controls.Add(this.linklbShowLicenceInfo);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cntrlDriverLicenceInfoWithFillter1);
            this.Name = "frmDetainLicence";
            this.Text = "frmDetainLicence";
            this.Load += new System.EventHandler(this.frmDetainLicence_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linklbShowLicenceHistory;
        private System.Windows.Forms.LinkLabel linklbShowLicenceInfo;
        private System.Windows.Forms.Button btnDetain;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFineFees;
    }
}