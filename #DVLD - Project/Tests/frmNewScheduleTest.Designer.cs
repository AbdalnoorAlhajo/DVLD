namespace _DVLD___Project
{
    partial class frmNewScheduleTest
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
            this.components = new System.ComponentModel.Container();
            this.lbTestName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cntrlApplicationBasicInfo1 = new _DVLD___Project.cntrlApplicationBasicInfo();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cntrlLocalAppInfo1 = new _DVLD___Project.cntrlLocalAppInfo();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRecordCount = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Button();
            this.pbNewTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTestName
            // 
            this.lbTestName.AutoSize = true;
            this.lbTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestName.ForeColor = System.Drawing.Color.Red;
            this.lbTestName.Location = new System.Drawing.Point(266, 139);
            this.lbTestName.Name = "lbTestName";
            this.lbTestName.Size = new System.Drawing.Size(93, 32);
            this.lbTestName.TabIndex = 2;
            this.lbTestName.Text = " {???}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cntrlApplicationBasicInfo1);
            this.groupBox1.Location = new System.Drawing.Point(40, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 259);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Basic Info";
            // 
            // cntrlApplicationBasicInfo1
            // 
            this.cntrlApplicationBasicInfo1.Location = new System.Drawing.Point(23, 21);
            this.cntrlApplicationBasicInfo1.Name = "cntrlApplicationBasicInfo1";
            this.cntrlApplicationBasicInfo1.Size = new System.Drawing.Size(816, 227);
            this.cntrlApplicationBasicInfo1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cntrlLocalAppInfo1);
            this.groupBox2.Location = new System.Drawing.Point(40, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 121);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driving Licence Application Info";
            // 
            // cntrlLocalAppInfo1
            // 
            this.cntrlLocalAppInfo1.Location = new System.Drawing.Point(6, 21);
            this.cntrlLocalAppInfo1.Name = "cntrlLocalAppInfo1";
            this.cntrlLocalAppInfo1.Size = new System.Drawing.Size(832, 91);
            this.cntrlLocalAppInfo1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Appointments:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(39, 630);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 139);
            this.dataGridView1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 772);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "#Record: ";
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.AutoSize = true;
            this.lbRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordCount.ForeColor = System.Drawing.Color.Black;
            this.lbRecordCount.Location = new System.Drawing.Point(203, 772);
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Size = new System.Drawing.Size(31, 32);
            this.lbRecordCount.TabIndex = 9;
            this.lbRecordCount.Text = "0";
            // 
            // lbClose
            // 
            this.lbClose.BackColor = System.Drawing.Color.Red;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.Location = new System.Drawing.Point(722, 772);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(162, 40);
            this.lbClose.TabIndex = 10;
            this.lbClose.Text = "Close";
            this.lbClose.UseVisualStyleBackColor = false;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // pbNewTest
            // 
            this.pbNewTest.Location = new System.Drawing.Point(813, 570);
            this.pbNewTest.Name = "pbNewTest";
            this.pbNewTest.Size = new System.Drawing.Size(70, 56);
            this.pbNewTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewTest.TabIndex = 11;
            this.pbNewTest.TabStop = false;
            this.pbNewTest.Click += new System.EventHandler(this.pbNewTest_Click);
            // 
            // frmNewScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 813);
            this.Controls.Add(this.pbNewTest);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.lbRecordCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTestName);
            this.Name = "frmNewScheduleTest";
            this.Text = "frmNewScheduleTest";
            this.Load += new System.EventHandler(this.frmNewScheduleTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTestName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private cntrlLocalAppInfo cntrlLocalAppInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRecordCount;
        private System.Windows.Forms.Button lbClose;
        private cntrlApplicationBasicInfo cntrlApplicationBasicInfo1;
        private System.Windows.Forms.PictureBox pbNewTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}