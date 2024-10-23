namespace _DVLD___Project
{
    partial class frmManageLocalDrivingLicenceApplications
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
            this.dgvLocalApplications = new System.Windows.Forms.DataGridView();
            this.cmsLocalApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetails_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApp_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApp_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApp_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.schechelTests_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schechelVision_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schechelWritten_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schechelStreet_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenceFirstTime_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.showIssue_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenceHistory_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountRecord = new System.Windows.Forms.Label();
            this.pbAddApplication = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalApplications)).BeginInit();
            this.cmsLocalApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocalApplications
            // 
            this.dgvLocalApplications.AllowUserToAddRows = false;
            this.dgvLocalApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLocalApplications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvLocalApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalApplications.ContextMenuStrip = this.cmsLocalApplications;
            this.dgvLocalApplications.Location = new System.Drawing.Point(12, 335);
            this.dgvLocalApplications.Name = "dgvLocalApplications";
            this.dgvLocalApplications.RowHeadersWidth = 51;
            this.dgvLocalApplications.RowTemplate.Height = 24;
            this.dgvLocalApplications.Size = new System.Drawing.Size(1191, 326);
            this.dgvLocalApplications.TabIndex = 0;
            // 
            // cmsLocalApplications
            // 
            this.cmsLocalApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetails_MenuItem,
            this.toolStripMenuItem1,
            this.editApp_MenuItem,
            this.deleteApp_MenuItem,
            this.cancelApp_MenuItem,
            this.toolStripMenuItem2,
            this.schechelTests_MenuItem,
            this.issueDrivingLicenceFirstTime_MenuItem,
            this.toolStripMenuItem4,
            this.showIssue_MenuItem,
            this.toolStripMenuItem3,
            this.showPersonLicenceHistory_MenuItem});
            this.cmsLocalApplications.Name = "contextMenuStrip1";
            this.cmsLocalApplications.Size = new System.Drawing.Size(290, 220);
            this.cmsLocalApplications.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetails_MenuItem
            // 
            this.showApplicationDetails_MenuItem.Name = "showApplicationDetails_MenuItem";
            this.showApplicationDetails_MenuItem.Size = new System.Drawing.Size(289, 24);
            this.showApplicationDetails_MenuItem.Text = "Show Application Details";
            this.showApplicationDetails_MenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(286, 6);
            // 
            // editApp_MenuItem
            // 
            this.editApp_MenuItem.Name = "editApp_MenuItem";
            this.editApp_MenuItem.Size = new System.Drawing.Size(289, 24);
            this.editApp_MenuItem.Text = "Edit Application";
            this.editApp_MenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApp_MenuItem
            // 
            this.deleteApp_MenuItem.Name = "deleteApp_MenuItem";
            this.deleteApp_MenuItem.Size = new System.Drawing.Size(289, 24);
            this.deleteApp_MenuItem.Text = "Delete Application";
            this.deleteApp_MenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApp_MenuItem
            // 
            this.cancelApp_MenuItem.Name = "cancelApp_MenuItem";
            this.cancelApp_MenuItem.Size = new System.Drawing.Size(289, 24);
            this.cancelApp_MenuItem.Text = "Cancel Application";
            this.cancelApp_MenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(286, 6);
            // 
            // schechelTests_MenuItem
            // 
            this.schechelTests_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schechelVision_MenuItem,
            this.schechelWritten_MenuItem,
            this.schechelStreet_MenuItem});
            this.schechelTests_MenuItem.Name = "schechelTests_MenuItem";
            this.schechelTests_MenuItem.Size = new System.Drawing.Size(289, 24);
            this.schechelTests_MenuItem.Text = "Schechel Tests";
            // 
            // schechelVision_MenuItem
            // 
            this.schechelVision_MenuItem.Name = "schechelVision_MenuItem";
            this.schechelVision_MenuItem.Size = new System.Drawing.Size(229, 26);
            this.schechelVision_MenuItem.Text = "Schechel Vision Test";
            this.schechelVision_MenuItem.Click += new System.EventHandler(this.sdfToolStripMenuItem_Click);
            // 
            // schechelWritten_MenuItem
            // 
            this.schechelWritten_MenuItem.Name = "schechelWritten_MenuItem";
            this.schechelWritten_MenuItem.Size = new System.Drawing.Size(229, 26);
            this.schechelWritten_MenuItem.Text = "Schechel WrittenTest";
            this.schechelWritten_MenuItem.Click += new System.EventHandler(this.schechelWrittenTestToolStripMenuItem_Click);
            // 
            // schechelStreet_MenuItem
            // 
            this.schechelStreet_MenuItem.Name = "schechelStreet_MenuItem";
            this.schechelStreet_MenuItem.Size = new System.Drawing.Size(229, 26);
            this.schechelStreet_MenuItem.Text = "Schechel Street Test";
            this.schechelStreet_MenuItem.Click += new System.EventHandler(this.schechelStreetTestToolStripMenuItem_Click);
            // 
            // issueDrivingLicenceFirstTime_MenuItem
            // 
            this.issueDrivingLicenceFirstTime_MenuItem.Name = "issueDrivingLicenceFirstTime_MenuItem";
            this.issueDrivingLicenceFirstTime_MenuItem.Size = new System.Drawing.Size(289, 24);
            this.issueDrivingLicenceFirstTime_MenuItem.Text = "Issue Driving Licence(First Time)";
            this.issueDrivingLicenceFirstTime_MenuItem.Click += new System.EventHandler(this.issueDrivingLicenceFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(286, 6);
            // 
            // showIssue_MenuItem
            // 
            this.showIssue_MenuItem.Name = "showIssue_MenuItem";
            this.showIssue_MenuItem.Size = new System.Drawing.Size(289, 24);
            this.showIssue_MenuItem.Text = "Show Licence";
            this.showIssue_MenuItem.Click += new System.EventHandler(this.showIssueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(286, 6);
            // 
            // showPersonLicenceHistory_MenuItem
            // 
            this.showPersonLicenceHistory_MenuItem.Name = "showPersonLicenceHistory_MenuItem";
            this.showPersonLicenceHistory_MenuItem.Size = new System.Drawing.Size(289, 24);
            this.showPersonLicenceHistory_MenuItem.Text = "Show Person Licence History";
            this.showPersonLicenceHistory_MenuItem.Click += new System.EventHandler(this.showPersonLicenceHistoryToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Record:";
            // 
            // lbCountRecord
            // 
            this.lbCountRecord.AutoSize = true;
            this.lbCountRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountRecord.Location = new System.Drawing.Point(205, 649);
            this.lbCountRecord.Name = "lbCountRecord";
            this.lbCountRecord.Size = new System.Drawing.Size(74, 38);
            this.lbCountRecord.TabIndex = 2;
            this.lbCountRecord.Text = "???";
            // 
            // pbAddApplication
            // 
            this.pbAddApplication.Image = global::_DVLD___Project.Properties.Resources.Add_Document;
            this.pbAddApplication.Location = new System.Drawing.Point(1086, 232);
            this.pbAddApplication.Name = "pbAddApplication";
            this.pbAddApplication.Size = new System.Drawing.Size(93, 82);
            this.pbAddApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddApplication.TabIndex = 3;
            this.pbAddApplication.TabStop = false;
            this.pbAddApplication.Click += new System.EventHandler(this.pbAddApplication_Click);
            // 
            // pbMain
            // 
            this.pbMain.Image = global::_DVLD___Project.Properties.Resources.document;
            this.pbMain.Location = new System.Drawing.Point(516, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(201, 192);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 4;
            this.pbMain.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(363, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Local Driving Licences Applications";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter By:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 26);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(478, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 24);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmManageLocalDrivingLicenceApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 692);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.pbAddApplication);
            this.Controls.Add(this.lbCountRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLocalApplications);
            this.Name = "frmManageLocalDrivingLicenceApplications";
            this.Text = "frmManageLocalDrivingLicenceApplications";
            this.Load += new System.EventHandler(this.frmManageLocalDrivingLicenceApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalApplications)).EndInit();
            this.cmsLocalApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocalApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountRecord;
        private System.Windows.Forms.PictureBox pbAddApplication;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip cmsLocalApplications;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetails_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editApp_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApp_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApp_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem schechelTests_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem schechelVision_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenceFirstTime_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem showIssue_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenceHistory_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem schechelWritten_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem schechelStreet_MenuItem;
    }
}