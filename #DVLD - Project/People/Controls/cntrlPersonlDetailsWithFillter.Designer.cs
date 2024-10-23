namespace _DVLD___Project
{
    partial class cntrlPersonlDetailsWithFillter
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFillter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbFillter = new System.Windows.Forms.GroupBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbAddUser = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.gbFillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // cntrlPersonDetails1
            // 
            this.cntrlPersonDetails1.Location = new System.Drawing.Point(6, 21);
            this.cntrlPersonDetails1.Name = "cntrlPersonDetails1";
            this.cntrlPersonDetails1.Size = new System.Drawing.Size(810, 334);
            this.cntrlPersonDetails1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter By: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFillter
            // 
            this.txtFillter.Location = new System.Drawing.Point(298, 34);
            this.txtFillter.Name = "txtFillter";
            this.txtFillter.Size = new System.Drawing.Size(138, 22);
            this.txtFillter.TabIndex = 4;
            this.txtFillter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFillter_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cntrlPersonDetails1);
            this.groupBox1.Location = new System.Drawing.Point(3, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 376);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Info";
            // 
            // gbFillter
            // 
            this.gbFillter.Controls.Add(this.pbSearch);
            this.gbFillter.Controls.Add(this.pbAddUser);
            this.gbFillter.Controls.Add(this.txtFillter);
            this.gbFillter.Controls.Add(this.comboBox1);
            this.gbFillter.Location = new System.Drawing.Point(0, 3);
            this.gbFillter.Name = "gbFillter";
            this.gbFillter.Size = new System.Drawing.Size(819, 88);
            this.gbFillter.TabIndex = 8;
            this.gbFillter.TabStop = false;
            this.gbFillter.Text = "Fillter";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::_DVLD___Project.Properties.Resources.Person_Search;
            this.pbSearch.Location = new System.Drawing.Point(628, 21);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(67, 59);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 6;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbAddUser
            // 
            this.pbAddUser.Image = global::_DVLD___Project.Properties.Resources.Add_Person;
            this.pbAddUser.Location = new System.Drawing.Point(713, 21);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Size = new System.Drawing.Size(67, 59);
            this.pbAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddUser.TabIndex = 5;
            this.pbAddUser.TabStop = false;
            this.pbAddUser.Click += new System.EventHandler(this.pbAddUser_Click);
            // 
            // cntrlPersonlDetailsWithFillter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFillter);
            this.Name = "cntrlPersonlDetailsWithFillter";
            this.Size = new System.Drawing.Size(822, 467);
            this.Load += new System.EventHandler(this.cntrlPersonlDetailsWithFillter_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbFillter.ResumeLayout(false);
            this.gbFillter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cntrlPersonDetails cntrlPersonDetails1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFillter;
        private System.Windows.Forms.PictureBox pbAddUser;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFillter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
