using _DVLD___Project;
using System;
using System.Windows.Forms;
namespace _DVLD___Project
{
    partial class frmAddEditPerson
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
            this.lbAddEditForm = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cntrlPerson1 = new _DVLD___Project.cntrlPerson();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddEditForm
            // 
            this.lbAddEditForm.AutoSize = true;
            this.lbAddEditForm.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEditForm.ForeColor = System.Drawing.Color.Red;
            this.lbAddEditForm.Location = new System.Drawing.Point(299, 9);
            this.lbAddEditForm.Name = "lbAddEditForm";
            this.lbAddEditForm.Size = new System.Drawing.Size(253, 55);
            this.lbAddEditForm.TabIndex = 1;
            this.lbAddEditForm.Text = "Add Person";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(590, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::_DVLD___Project.Properties.Resources.diskette;
            this.pictureBox6.Location = new System.Drawing.Point(605, 531);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(353, 519);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 45);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cntrlPerson1
            // 
            this.cntrlPerson1.Location = new System.Drawing.Point(10, 67);
            this.cntrlPerson1.Name = "cntrlPerson1";
            this.cntrlPerson1.Size = new System.Drawing.Size(811, 446);
            this.cntrlPerson1.TabIndex = 39;
            // 
            // frmAddEditPerson
            // 
            this.ClientSize = new System.Drawing.Size(833, 575);
            this.Controls.Add(this.cntrlPerson1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbAddEditForm);
            this.Name = "frmAddEditPerson";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label lbAddEditForm;
        private Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox6;
        private Button btnClose;
        private cntrlPerson cntrlPerson1;
    }
}
