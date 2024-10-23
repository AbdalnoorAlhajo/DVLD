
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
    public partial class frmMainScreen : Form
    {
        
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManagePeople = new frmManagePeople();
            frmManagePeople.MdiParent = this;
            frmManagePeople.Show();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin();
            this.Hide();
            frm.Show();
        }

        
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManageUsers = new frmManageUsers();
            frmManageUsers.MdiParent = this;
            frmManageUsers.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserDetails(clsCurrentUser.CurrentUser.PersonID);
            frm .ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangeUserPassword(clsCurrentUser.CurrentUser.PersonID);
            frm .ShowDialog();
        }

        private void applicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void drivingLicencesServiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewLocalDrivingLicenceApplication();
            frm.ShowDialog();
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localDrivingLicencesApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageLocalDrivingLicenceApplications();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDrivers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void internationalLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewInternationalLicenceApplication();
            frm.MdiParent = this;
            frm.Show();
        }

        private void globalDrivingLicencesApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageInternationalDrivingLicence();
            frm.MdiParent = this;
            frm.Show();
        }

        private void renewDrivingLicneceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmRenewDrivingLicence();
            frm.ShowDialog();
        }

        private void replacementForLostOrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReplacementForLostOrDamagedLicence();
            frm.MdiParent = this;
            frm.Show();
        }

        private void releaseLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageDetainedLicences();
            frm.ShowDialog();
        }

        private void detainLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainLicence();
            frm.ShowDialog();
        }

        private void releaseDetainedLicencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaseDetainedLicence();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaseDetainedLicence();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageLocalDrivingLicenceApplications();
            frm.ShowDialog();
        }
    }
}
