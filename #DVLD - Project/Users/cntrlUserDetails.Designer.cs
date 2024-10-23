namespace _DVLD___Project
{
    partial class cntrlUserDetails
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
            this.cntrlPersonDetails1 = new _DVLD___Project.cntrlPersonDetails();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cntrlPersonDetails1
            // 
            this.cntrlPersonDetails1.Location = new System.Drawing.Point(3, 3);
            this.cntrlPersonDetails1.Name = "cntrlPersonDetails1";
            this.cntrlPersonDetails1.Size = new System.Drawing.Size(801, 353);
            this.cntrlPersonDetails1.TabIndex = 1;
            this.cntrlPersonDetails1.Load += new System.EventHandler(this.cntrlPersonDetails1_Load);
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(675, 389);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(43, 22);
            this.lbIsActive.TabIndex = 12;
            this.lbIsActive.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Is Active:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(415, 389);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(43, 22);
            this.lbUserName.TabIndex = 10;
            this.lbUserName.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "UserName: ";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(150, 389);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(43, 22);
            this.lbUserID.TabIndex = 8;
            this.lbUserID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "UserID: ";
            // 
            // cntrlUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbIsActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cntrlPersonDetails1);
            this.Name = "cntrlUserDetails";
            this.Size = new System.Drawing.Size(818, 442);
            this.Load += new System.EventHandler(this.cntrlUserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cntrlPersonDetails cntrlPersonDetails1;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label1;
    }
}
