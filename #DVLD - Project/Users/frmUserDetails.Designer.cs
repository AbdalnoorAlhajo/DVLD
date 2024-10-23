namespace _DVLD___Project
{
    partial class frmUserDetails
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
            this.cntrlUserDetails1 = new _DVLD___Project.cntrlUserDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntrlUserDetails1
            // 
            this.cntrlUserDetails1.Location = new System.Drawing.Point(3, 1);
            this.cntrlUserDetails1.Name = "cntrlUserDetails1";
            this.cntrlUserDetails1.Size = new System.Drawing.Size(818, 442);
            this.cntrlUserDetails1.TabIndex = 0;
            this.cntrlUserDetails1.Load += new System.EventHandler(this.cntrlUserDetails1_Load);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(603, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 70);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 530);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntrlUserDetails1);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private cntrlUserDetails cntrlUserDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}