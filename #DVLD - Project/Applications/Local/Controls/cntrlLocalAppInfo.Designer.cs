namespace _DVLD___Project
{
    partial class cntrlLocalAppInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linklbShowLicenceInfo = new System.Windows.Forms.LinkLabel();
            this.lbLDAppID = new System.Windows.Forms.Label();
            this.lbApplaiedForLicence = new System.Windows.Forms.Label();
            this.lbPassedTests = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "L.D.AppID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applaied for Licence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passed Tests:";
            // 
            // linklbShowLicenceInfo
            // 
            this.linklbShowLicenceInfo.AutoSize = true;
            this.linklbShowLicenceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbShowLicenceInfo.Location = new System.Drawing.Point(81, 50);
            this.linklbShowLicenceInfo.Name = "linklbShowLicenceInfo";
            this.linklbShowLicenceInfo.Size = new System.Drawing.Size(173, 22);
            this.linklbShowLicenceInfo.TabIndex = 3;
            this.linklbShowLicenceInfo.TabStop = true;
            this.linklbShowLicenceInfo.Text = "Show Licence Info";
            this.linklbShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShowLicenceInfo_LinkClicked);
            // 
            // lbLDAppID
            // 
            this.lbLDAppID.AutoSize = true;
            this.lbLDAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLDAppID.Location = new System.Drawing.Point(146, 13);
            this.lbLDAppID.Name = "lbLDAppID";
            this.lbLDAppID.Size = new System.Drawing.Size(57, 22);
            this.lbLDAppID.TabIndex = 4;
            this.lbLDAppID.Text = "{???}";
            // 
            // lbApplaiedForLicence
            // 
            this.lbApplaiedForLicence.AutoSize = true;
            this.lbApplaiedForLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplaiedForLicence.Location = new System.Drawing.Point(479, 19);
            this.lbApplaiedForLicence.Name = "lbApplaiedForLicence";
            this.lbApplaiedForLicence.Size = new System.Drawing.Size(43, 16);
            this.lbApplaiedForLicence.TabIndex = 5;
            this.lbApplaiedForLicence.Text = "{???}";
            // 
            // lbPassedTests
            // 
            this.lbPassedTests.AutoSize = true;
            this.lbPassedTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassedTests.Location = new System.Drawing.Point(512, 50);
            this.lbPassedTests.Name = "lbPassedTests";
            this.lbPassedTests.Size = new System.Drawing.Size(57, 22);
            this.lbPassedTests.TabIndex = 6;
            this.lbPassedTests.Text = "{???}";
            // 
            // cntrlLocalAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPassedTests);
            this.Controls.Add(this.lbApplaiedForLicence);
            this.Controls.Add(this.lbLDAppID);
            this.Controls.Add(this.linklbShowLicenceInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cntrlLocalAppInfo";
            this.Size = new System.Drawing.Size(759, 91);
            this.Load += new System.EventHandler(this.cntrlLocalAppInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linklbShowLicenceInfo;
        private System.Windows.Forms.Label lbLDAppID;
        private System.Windows.Forms.Label lbApplaiedForLicence;
        private System.Windows.Forms.Label lbPassedTests;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
