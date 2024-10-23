namespace _DVLD___Project
{
    partial class cntrlDriverLicenceInfoWithFillter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cntrlDriverLicenceInfo1 = new _DVLD___Project.cntrlDriverLicenceInfo();
            this.gbFillter = new System.Windows.Forms.GroupBox();
            this.pbSerach = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-1, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenece Info";
            // 
            // cntrlDriverLicenceInfo1
            // 
            this.cntrlDriverLicenceInfo1.Location = new System.Drawing.Point(3, 90);
            this.cntrlDriverLicenceInfo1.Name = "cntrlDriverLicenceInfo1";
            this.cntrlDriverLicenceInfo1.Size = new System.Drawing.Size(862, 388);
            this.cntrlDriverLicenceInfo1.TabIndex = 0;
            // 
            // gbFillter
            // 
            this.gbFillter.Controls.Add(this.pbSerach);
            this.gbFillter.Controls.Add(this.textBox1);
            this.gbFillter.Controls.Add(this.label1);
            this.gbFillter.Location = new System.Drawing.Point(3, 10);
            this.gbFillter.Name = "gbFillter";
            this.gbFillter.Size = new System.Drawing.Size(721, 61);
            this.gbFillter.TabIndex = 1;
            this.gbFillter.TabStop = false;
            this.gbFillter.Text = "Fillter";
            // 
            // pbSerach
            // 
            this.pbSerach.Image = global::_DVLD___Project.Properties.Resources.Driver_Licence;
            this.pbSerach.Location = new System.Drawing.Point(641, 18);
            this.pbSerach.Name = "pbSerach";
            this.pbSerach.Size = new System.Drawing.Size(68, 37);
            this.pbSerach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSerach.TabIndex = 2;
            this.pbSerach.TabStop = false;
            this.pbSerach.Click += new System.EventHandler(this.pbSerach_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(177, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LicenceID:";
            // 
            // cntrlDriverLicenceInfoWithFillter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cntrlDriverLicenceInfo1);
            this.Controls.Add(this.gbFillter);
            this.Controls.Add(this.groupBox1);
            this.Name = "cntrlDriverLicenceInfoWithFillter";
            this.Size = new System.Drawing.Size(884, 496);
            this.gbFillter.ResumeLayout(false);
            this.gbFillter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private cntrlDriverLicenceInfo cntrlDriverLicenceInfo1;
        private System.Windows.Forms.GroupBox gbFillter;
        private System.Windows.Forms.PictureBox pbSerach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
