namespace _DVLD___Project
{
    partial class frmShowPersonDetails
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
            this.ShowDetails = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cntrlPerson1 = new _DVLD___Project.cntrlPerson();
            this.cntrlPersonDetails1 = new _DVLD___Project.cntrlPersonDetails();
            this.SuspendLayout();
            // 
            // ShowDetails
            // 
            this.ShowDetails.AutoSize = true;
            this.ShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDetails.ForeColor = System.Drawing.Color.Red;
            this.ShowDetails.Location = new System.Drawing.Point(286, 9);
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(303, 51);
            this.ShowDetails.TabIndex = 1;
            this.ShowDetails.Text = "Person Details";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(664, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cntrlPerson1
            // 
            this.cntrlPerson1.Location = new System.Drawing.Point(490, 179);
            this.cntrlPerson1.Name = "cntrlPerson1";
            this.cntrlPerson1.Size = new System.Drawing.Size(8, 8);
            this.cntrlPerson1.TabIndex = 2;
            // 
            // cntrlPersonDetails1
            // 
            this.cntrlPersonDetails1.Location = new System.Drawing.Point(5, 89);
            this.cntrlPersonDetails1.Name = "cntrlPersonDetails1";
            this.cntrlPersonDetails1.Size = new System.Drawing.Size(810, 334);
            this.cntrlPersonDetails1.TabIndex = 5;
            // 
            // frmShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 425);
            this.Controls.Add(this.cntrlPersonDetails1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntrlPerson1);
            this.Controls.Add(this.ShowDetails);
            this.Name = "frmShowPersonDetails";
            this.Text = "frmShowPersonDetails";
            this.Load += new System.EventHandler(this.frmShowPersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ShowDetails;
        private cntrlPerson cntrlPerson1;
        private System.Windows.Forms.Button btnClose;
        private cntrlPersonDetails cntrlPersonDetails1;
    }
}