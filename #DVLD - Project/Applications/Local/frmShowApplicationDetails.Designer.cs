namespace _DVLD___Project.Applications.Local
{
    partial class frmShowApplicationDetails
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
            this.lbApplicationDetails = new System.Windows.Forms.Label();
            this.cntrlApplicationBasicInfo1 = new _DVLD___Project.cntrlApplicationBasicInfo();
            this.cntrlLocalAppInfo1 = new _DVLD___Project.cntrlLocalAppInfo();
            this.SuspendLayout();
            // 
            // lbApplicationDetails
            // 
            this.lbApplicationDetails.AutoSize = true;
            this.lbApplicationDetails.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDetails.ForeColor = System.Drawing.Color.Black;
            this.lbApplicationDetails.Location = new System.Drawing.Point(188, 9);
            this.lbApplicationDetails.Name = "lbApplicationDetails";
            this.lbApplicationDetails.Size = new System.Drawing.Size(342, 42);
            this.lbApplicationDetails.TabIndex = 0;
            this.lbApplicationDetails.Text = "Application Details";
            // 
            // cntrlApplicationBasicInfo1
            // 
            this.cntrlApplicationBasicInfo1.Location = new System.Drawing.Point(12, 71);
            this.cntrlApplicationBasicInfo1.Name = "cntrlApplicationBasicInfo1";
            this.cntrlApplicationBasicInfo1.Size = new System.Drawing.Size(775, 227);
            this.cntrlApplicationBasicInfo1.TabIndex = 1;
            // 
            // cntrlLocalAppInfo1
            // 
            this.cntrlLocalAppInfo1.Location = new System.Drawing.Point(12, 323);
            this.cntrlLocalAppInfo1.Name = "cntrlLocalAppInfo1";
            this.cntrlLocalAppInfo1.Size = new System.Drawing.Size(759, 91);
            this.cntrlLocalAppInfo1.TabIndex = 2;
            // 
            // frmShowApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cntrlLocalAppInfo1);
            this.Controls.Add(this.cntrlApplicationBasicInfo1);
            this.Controls.Add(this.lbApplicationDetails);
            this.Name = "frmShowApplicationDetails";
            this.Text = "frmShowApplicationDetails";
            this.Load += new System.EventHandler(this.frmShowApplicationDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApplicationDetails;
        private cntrlApplicationBasicInfo cntrlApplicationBasicInfo1;
        private cntrlLocalAppInfo cntrlLocalAppInfo1;
    }
}