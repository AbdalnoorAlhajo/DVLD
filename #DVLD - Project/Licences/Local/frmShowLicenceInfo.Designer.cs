namespace _DVLD___Project
{
    partial class frmShowLicenceInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cntrlDriverLicenceInfo1 = new _DVLD___Project.cntrlDriverLicenceInfo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cntrlDriverLicenceInfo1);
            this.groupBox1.Location = new System.Drawing.Point(4, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licence Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(331, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(294, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Driver Licence Info";
            // 
            // cntrlDriverLicenceInfo1
            // 
            this.cntrlDriverLicenceInfo1.Location = new System.Drawing.Point(8, 21);
            this.cntrlDriverLicenceInfo1.Name = "cntrlDriverLicenceInfo1";
            this.cntrlDriverLicenceInfo1.Size = new System.Drawing.Size(816, 388);
            this.cntrlDriverLicenceInfo1.TabIndex = 0;
            // 
            // frmShowLicenceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmShowLicenceInfo";
            this.Text = "frmShowLicenceInfo";
            this.Load += new System.EventHandler(this.frmShowLicenceInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private cntrlDriverLicenceInfo cntrlDriverLicenceInfo1;
    }
}