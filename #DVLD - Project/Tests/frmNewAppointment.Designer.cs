namespace _DVLD___Project
{
    partial class frmNewAppointment
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.lbPersonHaveAppointment = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbTrail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbLDAppID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTestName = new System.Windows.Forms.Label();
            this.gbRetakeTestInfo = new System.Windows.Forms.GroupBox();
            this.lbRTestAppID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbRAppFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbRetakeTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lbPersonHaveAppointment);
            this.gbMain.Controls.Add(this.dateTimePicker1);
            this.gbMain.Controls.Add(this.btnSave);
            this.gbMain.Controls.Add(this.lbFees);
            this.gbMain.Controls.Add(this.lbTrail);
            this.gbMain.Controls.Add(this.lbName);
            this.gbMain.Controls.Add(this.lbClass);
            this.gbMain.Controls.Add(this.lbLDAppID);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.label5);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.pictureBox1);
            this.gbMain.Controls.Add(this.lbTestName);
            this.gbMain.Controls.Add(this.gbRetakeTestInfo);
            this.gbMain.Location = new System.Drawing.Point(10, 10);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(568, 648);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Vision Test";
            this.gbMain.Enter += new System.EventHandler(this.gbMain_Enter);
            // 
            // lbPersonHaveAppointment
            // 
            this.lbPersonHaveAppointment.AutoSize = true;
            this.lbPersonHaveAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonHaveAppointment.ForeColor = System.Drawing.Color.Red;
            this.lbPersonHaveAppointment.Location = new System.Drawing.Point(130, 150);
            this.lbPersonHaveAppointment.Name = "lbPersonHaveAppointment";
            this.lbPersonHaveAppointment.Size = new System.Drawing.Size(287, 18);
            this.lbPersonHaveAppointment.TabIndex = 20;
            this.lbPersonHaveAppointment.Text = "Person Already took the Appointment";
            this.lbPersonHaveAppointment.Visible = false;
            this.lbPersonHaveAppointment.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 371);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 24);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(440, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 52);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(158, 419);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(57, 22);
            this.lbFees.TabIndex = 17;
            this.lbFees.Text = "{???}";
            // 
            // lbTrail
            // 
            this.lbTrail.AutoSize = true;
            this.lbTrail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrail.Location = new System.Drawing.Point(158, 327);
            this.lbTrail.Name = "lbTrail";
            this.lbTrail.Size = new System.Drawing.Size(57, 22);
            this.lbTrail.TabIndex = 15;
            this.lbTrail.Text = "{???}";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(158, 281);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(57, 22);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "{???}";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(158, 235);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(57, 22);
            this.lbClass.TabIndex = 13;
            this.lbClass.Text = "{???}";
            // 
            // lbLDAppID
            // 
            this.lbLDAppID.AutoSize = true;
            this.lbLDAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLDAppID.Location = new System.Drawing.Point(158, 189);
            this.lbLDAppID.Name = "lbLDAppID";
            this.lbLDAppID.Size = new System.Drawing.Size(57, 22);
            this.lbLDAppID.TabIndex = 12;
            this.lbLDAppID.Text = "{???}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "L.D.App.ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbTestName
            // 
            this.lbTestName.AutoSize = true;
            this.lbTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestName.ForeColor = System.Drawing.Color.Red;
            this.lbTestName.Location = new System.Drawing.Point(156, 104);
            this.lbTestName.Name = "lbTestName";
            this.lbTestName.Size = new System.Drawing.Size(217, 32);
            this.lbTestName.TabIndex = 4;
            this.lbTestName.Text = " Schedule Test";
            // 
            // gbRetakeTestInfo
            // 
            this.gbRetakeTestInfo.Controls.Add(this.lbRTestAppID);
            this.gbRetakeTestInfo.Controls.Add(this.label14);
            this.gbRetakeTestInfo.Controls.Add(this.lbTotalFees);
            this.gbRetakeTestInfo.Controls.Add(this.label10);
            this.gbRetakeTestInfo.Controls.Add(this.lbRAppFees);
            this.gbRetakeTestInfo.Controls.Add(this.label8);
            this.gbRetakeTestInfo.Enabled = false;
            this.gbRetakeTestInfo.Location = new System.Drawing.Point(6, 455);
            this.gbRetakeTestInfo.Name = "gbRetakeTestInfo";
            this.gbRetakeTestInfo.Size = new System.Drawing.Size(564, 125);
            this.gbRetakeTestInfo.TabIndex = 0;
            this.gbRetakeTestInfo.TabStop = false;
            this.gbRetakeTestInfo.Text = "RetakeTestInfo";
            // 
            // lbRTestAppID
            // 
            this.lbRTestAppID.AutoSize = true;
            this.lbRTestAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRTestAppID.Location = new System.Drawing.Point(196, 78);
            this.lbRTestAppID.Name = "lbRTestAppID";
            this.lbRTestAppID.Size = new System.Drawing.Size(43, 22);
            this.lbRTestAppID.TabIndex = 19;
            this.lbRTestAppID.Text = "N/A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 22);
            this.label14.TabIndex = 18;
            this.label14.Text = "R.Test.App.ID:";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(440, 31);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(21, 22);
            this.lbTotalFees.TabIndex = 21;
            this.lbTotalFees.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(300, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total Fees:";
            // 
            // lbRAppFees
            // 
            this.lbRAppFees.AutoSize = true;
            this.lbRAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRAppFees.Location = new System.Drawing.Point(171, 31);
            this.lbRAppFees.Name = "lbRAppFees";
            this.lbRAppFees.Size = new System.Drawing.Size(21, 22);
            this.lbRAppFees.TabIndex = 19;
            this.lbRAppFees.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "R.App.Fees:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(230, 664);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 52);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 719);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbMain);
            this.Name = "frmNewAppointment";
            this.Text = "frmNewAppointment";
            this.Load += new System.EventHandler(this.frmNewAppointment_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbRetakeTestInfo.ResumeLayout(false);
            this.gbRetakeTestInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbRetakeTestInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbTrail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbLDAppID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRTestAppID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbRAppFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbPersonHaveAppointment;
    }
}