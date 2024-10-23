namespace _DVLD___Project
{
    partial class frmIssueDrivingLiceneceForFirstTime
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
            this.gbDrivingLicenecApplicationInfo = new System.Windows.Forms.GroupBox();
            this.gbApplicationBasicInfo = new System.Windows.Forms.GroupBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cntrlApplicationBasicInfo1 = new _DVLD___Project.cntrlApplicationBasicInfo();
            this.cntrlLocalAppInfo1 = new _DVLD___Project.cntrlLocalAppInfo();
            this.gbDrivingLicenecApplicationInfo.SuspendLayout();
            this.gbApplicationBasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDrivingLicenecApplicationInfo
            // 
            this.gbDrivingLicenecApplicationInfo.Controls.Add(this.cntrlLocalAppInfo1);
            this.gbDrivingLicenecApplicationInfo.Location = new System.Drawing.Point(12, 9);
            this.gbDrivingLicenecApplicationInfo.Name = "gbDrivingLicenecApplicationInfo";
            this.gbDrivingLicenecApplicationInfo.Size = new System.Drawing.Size(802, 125);
            this.gbDrivingLicenecApplicationInfo.TabIndex = 2;
            this.gbDrivingLicenecApplicationInfo.TabStop = false;
            this.gbDrivingLicenecApplicationInfo.Text = "Driving Licenec Application Info";
            // 
            // gbApplicationBasicInfo
            // 
            this.gbApplicationBasicInfo.Controls.Add(this.cntrlApplicationBasicInfo1);
            this.gbApplicationBasicInfo.Location = new System.Drawing.Point(12, 144);
            this.gbApplicationBasicInfo.Name = "gbApplicationBasicInfo";
            this.gbApplicationBasicInfo.Size = new System.Drawing.Size(796, 302);
            this.gbApplicationBasicInfo.TabIndex = 3;
            this.gbApplicationBasicInfo.TabStop = false;
            this.gbApplicationBasicInfo.Text = "Application Basic Info";
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(7, 449);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(75, 25);
            this.lbNotes.TabIndex = 4;
            this.lbNotes.Text = "Notes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 453);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(733, 118);
            this.textBox1.TabIndex = 5;
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(693, 577);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(115, 54);
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(526, 577);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 54);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cntrlApplicationBasicInfo1
            // 
            this.cntrlApplicationBasicInfo1.Location = new System.Drawing.Point(5, 38);
            this.cntrlApplicationBasicInfo1.Name = "cntrlApplicationBasicInfo1";
            this.cntrlApplicationBasicInfo1.Size = new System.Drawing.Size(791, 227);
            this.cntrlApplicationBasicInfo1.TabIndex = 1;
            // 
            // cntrlLocalAppInfo1
            // 
            this.cntrlLocalAppInfo1.Location = new System.Drawing.Point(6, 21);
            this.cntrlLocalAppInfo1.Name = "cntrlLocalAppInfo1";
            this.cntrlLocalAppInfo1.Size = new System.Drawing.Size(790, 91);
            this.cntrlLocalAppInfo1.TabIndex = 3;
            // 
            // frmIssueDrivingLiceneceForFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 634);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.gbApplicationBasicInfo);
            this.Controls.Add(this.gbDrivingLicenecApplicationInfo);
            this.Name = "frmIssueDrivingLiceneceForFirstTime";
            this.Text = "frmIssueDrivingLiceneceForFirstTime";
            this.Load += new System.EventHandler(this.frmIssueDrivingLiceneceForFirstTime_Load);
            this.gbDrivingLicenecApplicationInfo.ResumeLayout(false);
            this.gbApplicationBasicInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDrivingLicenecApplicationInfo;
        private cntrlLocalAppInfo cntrlLocalAppInfo1;
        private System.Windows.Forms.GroupBox gbApplicationBasicInfo;
        private cntrlApplicationBasicInfo cntrlApplicationBasicInfo1;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
    }
}