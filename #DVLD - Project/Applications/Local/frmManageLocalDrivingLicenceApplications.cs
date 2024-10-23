using _DVLD___Project.Applications.Local;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DVLD___Project
{
    public partial class frmManageLocalDrivingLicenceApplications : Form
    {
        DataTable LDLApplicationsTable ;
        public frmManageLocalDrivingLicenceApplications()
        {
            InitializeComponent();
        }

        void RefreshPage()
        {
            LDLApplicationsTable
            = clsLocalApplications.GetAllDataForManageLocalApplications();
            dgvLocalApplications.DataSource = LDLApplicationsTable;
        }

        void FillComboBox()
        {
            comboBox1.Items.Add("None");

            foreach (DataColumn dataColumn in LDLApplicationsTable.Columns)
            {
                comboBox1.Items.Add(dataColumn.ToString());
            }
            comboBox1.SelectedIndex = 0;

            
            comboBox1.Items.Remove("ClassName");
            comboBox1.Items.Remove("ApplicationDate");
            comboBox1.Items.Remove("TestResult");
        }

        private void frmManageLocalDrivingLicenceApplications_Load(object sender, EventArgs e)
        {
            LDLApplicationsTable = clsLocalApplications.
                GetAllDataForManageLocalApplications();

            dgvLocalApplications.DataSource = LDLApplicationsTable;
            FillComboBox();

            lbCountRecord.Text = (dgvLocalApplications.RowCount).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.Visible = false;
            else
                textBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = LDLApplicationsTable.DefaultView;


            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 4)
            {
                int.TryParse(textBox1.Text, out int ID);
                dataView.RowFilter = comboBox1.Text + "  = " + ID;
            }
            else
            {
                dataView.RowFilter = comboBox1.Text.Trim() + " like '" + textBox1.Text.Trim() + "%'";
            }    

            dgvLocalApplications.DataSource = dataView;
        }

        private void pbAddApplication_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewLocalDrivingLicenceApplication();
            frm.ShowDialog();
            RefreshPage();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the application?", "Are you sure?",
    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsLocalApplications.DeleteApplication(
                    (int)dgvLocalApplications.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Done", "Application Deleted Successfully."
                        , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Falied to Delete Application."
    , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                RefreshPage();
            }
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalApplications Ap = clsLocalApplications.FindLocalApplication(
                (int)dgvLocalApplications.CurrentRow.Cells[0].Value);
            Form frm = new frmNewLocalDrivingLicenceApplication(Ap.ApplicationID);

            frm.ShowDialog();
            RefreshPage();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalApplications Ap = clsLocalApplications.FindLocalApplication(
                (int)dgvLocalApplications.CurrentRow.Cells[0].Value);

            if (clsApplications.UpdateApplicationStatus(Ap.ApplicationID, 2))
            {
                MessageBox.Show("Applciation Cancled successfully", "Done"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Cancle applciation", "Failed"
                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefreshPage();
        }


        private void sdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewScheduleTest
                ((int)dgvLocalApplications.CurrentRow.Cells[0].Value, 1);
            frm.ShowDialog();
            RefreshPage();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int ApplicationID = (int)dgvLocalApplications.CurrentRow.Cells[0].Value;
            int PassedTests = clsLocalApplications.GetPassedTests(ApplicationID);
            clsLocalApplications LApp = clsLocalApplications.FindLocalApplication
                (ApplicationID);

            bool IsLicenseExist = clsLicenses.IsLicenseExistByApplicationID
                (LApp.ApplicationID);

            string Status = (string)dgvLocalApplications.CurrentRow.Cells[6].Value;

            editApp_MenuItem.Enabled = (Status != "Cancelled" && !IsLicenseExist);
            deleteApp_MenuItem.Enabled = (PassedTests == 0 || Status == "Cancelled");
            cancelApp_MenuItem.Enabled = !(IsLicenseExist || Status == "Cancelled"
                || PassedTests == 3);

            schechelTests_MenuItem.Enabled = (PassedTests < 3 && Status != "Cancelled"
                && !IsLicenseExist);

            schechelVision_MenuItem.Enabled = (PassedTests == 0);
            schechelWritten_MenuItem.Enabled = (PassedTests == 1);
            schechelStreet_MenuItem.Enabled = (PassedTests == 2);

            issueDrivingLicenceFirstTime_MenuItem.Enabled = (PassedTests == 3
                && !IsLicenseExist);

            showIssue_MenuItem.Enabled = IsLicenseExist;
        }

        private void schechelWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewScheduleTest
                            ((int)dgvLocalApplications.CurrentRow.Cells[0].Value, 2);
            frm.ShowDialog();
            RefreshPage();

        }

        private void schechelStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewScheduleTest
                        ((int)dgvLocalApplications.CurrentRow.Cells[0].Value, 3);
            frm.ShowDialog();
            RefreshPage();

        }

        private void issueDrivingLicenceFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmIssueDrivingLiceneceForFirstTime
                          ((int)dgvLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalApplications LApp = clsLocalApplications.FindLocalApplication
                ((int)dgvLocalApplications.CurrentRow.Cells[0].Value);
            clsLicenses license = clsLicenses.FindByApplicationID(LApp.ApplicationID);

            Form frm = new frmShowLicenceInfo(license.LicenseID);
            frm.ShowDialog();
        }

        private void showPersonLicenceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalApplications LApp = clsLocalApplications.FindLocalApplication
                ((int)dgvLocalApplications.CurrentRow.Cells[0].Value);

            Form frm = new frmshowPersonLiceneceHistory(LApp.ApplicantID);
            frm.ShowDialog();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowApplicationDetails frm = new frmShowApplicationDetails
                ((int)dgvLocalApplications.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }
    }
}
