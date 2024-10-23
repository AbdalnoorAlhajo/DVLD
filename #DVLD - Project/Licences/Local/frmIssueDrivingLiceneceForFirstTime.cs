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
    public partial class frmIssueDrivingLiceneceForFirstTime : Form
    {
        clsLocalApplications LApp;
        public frmIssueDrivingLiceneceForFirstTime(int LocalApplicationID)
        {
            InitializeComponent();
            LApp = clsLocalApplications.FindLocalApplication(LocalApplicationID);
        }
        void FillCardsWithInfo()
        {
            cntrlApplicationBasicInfo1.FillApplicationInfo(LApp.ApplicationID);
            cntrlLocalAppInfo1.FillCardInfo(LApp.LocalDrivingLicenseApplicationID);
        }

        private void frmIssueDrivingLiceneceForFirstTime_Load(object sender, EventArgs e)
        {
            FillCardsWithInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(clsLicenses.IsLicenseExistByApplicationID(LApp.ApplicationID))
            {
                MessageBox.Show("Licence already issued");
                btnIssue.Enabled = false;
                return;
            }


            clsDrivers Driver = clsDrivers.FindDriverByPersonID(LApp.ApplicantID);
            if (Driver == null)
            {
                Driver = new clsDrivers();
                Driver.PersonID = LApp.ApplicantID;
                Driver.CreatedByUserID = LApp.CreatedByUserID;
                if (!Driver.AddNewDriver())
                    return;
            }

            clsLicenseClasses licenseClasses 
                = clsLicenseClasses.Find(LApp.LicenseClassID);

            clsLicenses Licence = new clsLicenses();
            Licence.ApplicationID = LApp.ApplicationID;
            Licence.Notes = textBox1.Text;
            Licence.CreatedByUserID= LApp.CreatedByUserID;
            Licence.DriverID = Driver.DriverID;
            Licence.PaidFees = licenseClasses.ClassFees;
            Licence.IssueDate = DateTime.Now;
            Licence.LicenseClassID = licenseClasses.licenseClassID;
            Licence.ExpirationDate = DateTime.Now.AddYears
                (licenseClasses.DefaultValidityLength);   
            Licence.IsActive = true;
            Licence.IssueReason = 1;

            if(Licence.Save())
            {
                MessageBox.Show("Licence Add Successfully.");
                btnIssue.Enabled = false;
            }
            else
                MessageBox.Show("Failed to add Licence.");
        }
    }
}
