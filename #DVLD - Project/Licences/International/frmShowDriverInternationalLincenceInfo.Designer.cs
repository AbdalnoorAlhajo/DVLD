namespace _DVLD___Project
{
    partial class frmShowDriverInternationalLincenceInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cntrlInternationalDriverLicenceInfo1 = new _DVLD___Project.cntrlInternationalDriverLicenceInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(279, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(188, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "International Driver Licence";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cntrlInternationalDriverLicenceInfo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "International Driver Licence";
            // 
            // cntrlInternationalDriverLicenceInfo1
            // 
            this.cntrlInternationalDriverLicenceInfo1.Location = new System.Drawing.Point(6, 39);
            this.cntrlInternationalDriverLicenceInfo1.Name = "cntrlInternationalDriverLicenceInfo1";
            this.cntrlInternationalDriverLicenceInfo1.Size = new System.Drawing.Size(775, 279);
            this.cntrlInternationalDriverLicenceInfo1.TabIndex = 3;
            // 
            // frmShowDriverInternationalLincenceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmShowDriverInternationalLincenceInfo";
            this.Text = "frmShowInternationalDriverLincenceInfo";
            this.Load += new System.EventHandler(this.frmShowInternationalDriverLincenceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private cntrlInternationalDriverLicenceInfo cntrlInternationalDriverLicenceInfo1;
    }
}