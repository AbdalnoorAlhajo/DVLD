namespace _DVLD___Project
{
    partial class frmshowPersonLiceneceHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpLocal = new System.Windows.Forms.TabPage();
            this.lbCountLocalRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.cmsLocalLicence = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDrivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpInternational = new System.Windows.Forms.TabPage();
            this.lbCountInternationalRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.cmsInternationalLicence = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDrivingLicenceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cntrlPersonlDetailsWithFillter1 = new _DVLD___Project.cntrlPersonlDetailsWithFillter();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.cmsLocalLicence.SuspendLayout();
            this.tbpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.cmsInternationalLicence.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licenece History";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(0, 517);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenece";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpLocal);
            this.tabControl1.Controls.Add(this.tbpInternational);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 189);
            this.tabControl1.TabIndex = 3;
            // 
            // tbpLocal
            // 
            this.tbpLocal.Controls.Add(this.lbCountLocalRecords);
            this.tbpLocal.Controls.Add(this.label3);
            this.tbpLocal.Controls.Add(this.dgvLocal);
            this.tbpLocal.Controls.Add(this.label2);
            this.tbpLocal.Location = new System.Drawing.Point(4, 25);
            this.tbpLocal.Name = "tbpLocal";
            this.tbpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLocal.Size = new System.Drawing.Size(793, 160);
            this.tbpLocal.TabIndex = 0;
            this.tbpLocal.Text = "Local";
            this.tbpLocal.UseVisualStyleBackColor = true;
            // 
            // lbCountLocalRecords
            // 
            this.lbCountLocalRecords.AutoSize = true;
            this.lbCountLocalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountLocalRecords.Location = new System.Drawing.Point(139, 129);
            this.lbCountLocalRecords.Name = "lbCountLocalRecords";
            this.lbCountLocalRecords.Size = new System.Drawing.Size(24, 25);
            this.lbCountLocalRecords.TabIndex = 3;
            this.lbCountLocalRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = " #Record:";
            // 
            // dgvLocal
            // 
            this.dgvLocal.AllowUserToAddRows = false;
            this.dgvLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLocal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.ContextMenuStrip = this.cmsLocalLicence;
            this.dgvLocal.Location = new System.Drawing.Point(0, 22);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.RowHeadersWidth = 51;
            this.dgvLocal.RowTemplate.Height = 24;
            this.dgvLocal.Size = new System.Drawing.Size(790, 104);
            this.dgvLocal.TabIndex = 1;
            this.dgvLocal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocal_CellContentClick);
            // 
            // cmsLocalLicence
            // 
            this.cmsLocalLicence.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalLicence.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDrivingLicenceToolStripMenuItem});
            this.cmsLocalLicence.Name = "cmsLocalLicence";
            this.cmsLocalLicence.Size = new System.Drawing.Size(220, 28);
            // 
            // showDrivingLicenceToolStripMenuItem
            // 
            this.showDrivingLicenceToolStripMenuItem.Name = "showDrivingLicenceToolStripMenuItem";
            this.showDrivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.showDrivingLicenceToolStripMenuItem.Text = "Show Driving Licence";
            this.showDrivingLicenceToolStripMenuItem.Click += new System.EventHandler(this.showDrivingLicenceToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Local Licenece History:";
            // 
            // tbpInternational
            // 
            this.tbpInternational.Controls.Add(this.lbCountInternationalRecords);
            this.tbpInternational.Controls.Add(this.label5);
            this.tbpInternational.Controls.Add(this.dgvInternational);
            this.tbpInternational.Controls.Add(this.label6);
            this.tbpInternational.Location = new System.Drawing.Point(4, 25);
            this.tbpInternational.Name = "tbpInternational";
            this.tbpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInternational.Size = new System.Drawing.Size(793, 160);
            this.tbpInternational.TabIndex = 1;
            this.tbpInternational.Text = "International";
            this.tbpInternational.UseVisualStyleBackColor = true;
            // 
            // lbCountInternationalRecords
            // 
            this.lbCountInternationalRecords.AutoSize = true;
            this.lbCountInternationalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountInternationalRecords.Location = new System.Drawing.Point(140, 131);
            this.lbCountInternationalRecords.Name = "lbCountInternationalRecords";
            this.lbCountInternationalRecords.Size = new System.Drawing.Size(24, 25);
            this.lbCountInternationalRecords.TabIndex = 7;
            this.lbCountInternationalRecords.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = " #Record:";
            // 
            // dgvInternational
            // 
            this.dgvInternational.AllowUserToAddRows = false;
            this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternational.ContextMenuStrip = this.cmsInternationalLicence;
            this.dgvInternational.Location = new System.Drawing.Point(1, 24);
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.RowHeadersWidth = 51;
            this.dgvInternational.RowTemplate.Height = 24;
            this.dgvInternational.Size = new System.Drawing.Size(790, 104);
            this.dgvInternational.TabIndex = 5;
            // 
            // cmsInternationalLicence
            // 
            this.cmsInternationalLicence.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInternationalLicence.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDrivingLicenceToolStripMenuItem1});
            this.cmsInternationalLicence.Name = "cmsInternationalLicence";
            this.cmsInternationalLicence.Size = new System.Drawing.Size(220, 28);
            // 
            // showDrivingLicenceToolStripMenuItem1
            // 
            this.showDrivingLicenceToolStripMenuItem1.Name = "showDrivingLicenceToolStripMenuItem1";
            this.showDrivingLicenceToolStripMenuItem1.Size = new System.Drawing.Size(219, 24);
            this.showDrivingLicenceToolStripMenuItem1.Text = "Show Driving Licence";
            this.showDrivingLicenceToolStripMenuItem1.Click += new System.EventHandler(this.showDrivingLicenceToolStripMenuItem1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "International Licenece History:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(654, 721);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cntrlPersonlDetailsWithFillter1
            // 
            this.cntrlPersonlDetailsWithFillter1.FilterEnabled = true;
            this.cntrlPersonlDetailsWithFillter1.Location = new System.Drawing.Point(-5, 50);
            this.cntrlPersonlDetailsWithFillter1.Name = "cntrlPersonlDetailsWithFillter1";
            this.cntrlPersonlDetailsWithFillter1.Size = new System.Drawing.Size(813, 468);
            this.cntrlPersonlDetailsWithFillter1.TabIndex = 1;
            // 
            // frmshowPersonLiceneceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 772);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cntrlPersonlDetailsWithFillter1);
            this.Controls.Add(this.label1);
            this.Name = "frmshowPersonLiceneceHistory";
            this.Text = "frmshowPersonLiceneceHistory";
            this.Load += new System.EventHandler(this.frmshowPersonLiceneceHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpLocal.ResumeLayout(false);
            this.tbpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.cmsLocalLicence.ResumeLayout(false);
            this.tbpInternational.ResumeLayout(false);
            this.tbpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.cmsInternationalLicence.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private cntrlPersonlDetailsWithFillter cntrlPersonlDetailsWithFillter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpLocal;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpInternational;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbCountLocalRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCountInternationalRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInternational;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicence;
        private System.Windows.Forms.ToolStripMenuItem showDrivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicence;
        private System.Windows.Forms.ToolStripMenuItem showDrivingLicenceToolStripMenuItem1;
    }
}