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
    public partial class frmRenewDrivingLicence : Form
    {
        int PersonID, LicneceID;
        public frmRenewDrivingLicence()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklbShowLicenceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmshowPersonLiceneceHistory(PersonID);
            frm.ShowDialog();
        }

        private void linklbShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLicenceInfo(LicneceID);
            frm.ShowDialog();
        }

        void LoadInitialInfo()
        {
            clsApplicationTypes AppType = clsApplicationTypes.
                FindApplicationType("Retake Test");

            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbIssueDate.Text = DateTime.Now.ToShortDateString();
            lbApplicationFees.Text = AppType.ApplicationTypeFees.ToString();

            if(clsCurrentUser.CurrentUser !=null) 
                lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;

        }

        private void cntrlDriverLicenceInfoWithFillter1_Load(object sender, EventArgs e)
        {
            LoadInitialInfo();
        }

        void SetPersonID(int PersonID)
        {
            this.PersonID = PersonID;
        }

        void SetLicneceID(int LicneceID)
        {
            this.LicneceID = LicneceID;
        }

        clsApplications GetNewApplication(int DriverID)
        {
            clsDrivers Driver = clsDrivers.FindDriverByDriverID(DriverID);
            clsApplicationTypes AppType = clsApplicationTypes.
    FindApplicationType("Retake Test");

            clsApplications App = new clsApplications();
            App.ApplicantID = Driver.PersonID;
            SetPersonID(Driver.PersonID);

            App.ApplicationStatus = clsApplications.enApplicationStatuses.Completed;
            App.ApplicationStatusDate = DateTime.Now;
            App.PaidFees = decimal.Parse(lbApplicationFees.Text);
            App.ApplicationDate = DateTime.Now;
            App.ApplicationTypeID = AppType.ApplicationTypeID;
            App.CreatedByUserID = clsCurrentUser.CurrentUser.ID;


            return (App.Save()) ? App : null ;
        }

        clsLicenses AddNewLicence(clsLicenses OldLicense, clsApplications App)
        {
            clsLicenseClasses licenseClass = clsLicenseClasses.
                Find(OldLicense.LicenseClassID);

            clsLicenses NewLicence = new clsLicenses();
            NewLicence.DriverID = OldLicense.DriverID;
            NewLicence.Notes = textBox1.Text;
            NewLicence.IssueDate = DateTime.Now;
            NewLicence.PaidFees = OldLicense.PaidFees;
            NewLicence.ApplicationID = App.ApplicationID;
            NewLicence.CreatedByUserID = App.CreatedByUserID;
            NewLicence.ExpirationDate = DateTime.Now.
                AddYears(licenseClass.DefaultValidityLength);
            NewLicence.IsActive = true;
            NewLicence.IssueReason = 2;
            NewLicence.LicenseClassID = OldLicense.LicenseClassID;

            return (NewLicence.Save())? NewLicence : null ;
        }

        void Enabling()
        {
            linklbShowLicenceHistory.Enabled = true;
            linklbShowLicenceInfo.Enabled = true;
            btnRenew.Enabled = false;
            
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            int LocalLicenceID = this.cntrlDriverLicenceInfoWithFillter1.LicenceID;

            if (LocalLicenceID < 0)
            {
                MessageBox.Show("Please find local LicenceID first.");
                return;
            }


            clsLicenses OldLicense = clsLicenses.FindByLicenseID(LocalLicenceID);

            
            if (DateTime.Compare(OldLicense.ExpirationDate, DateTime.Now) > 0)
            {
                MessageBox.Show("This License have not ended yet", "License not expired"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplications App = GetNewApplication(OldLicense.DriverID);

            if (App != null)
            {
                clsLicenses NewLicence = AddNewLicence(OldLicense,  App);
                SetLicneceID(NewLicence.LicenseID);

                lbRenewedLicneceID.Text = NewLicence.LicenseID.ToString();
                lbRLApplicationID.Text = App.ApplicationID.ToString();
                lbOldLicneceID.Text = OldLicense.LicenseID.ToString();
                lbTotalFees.Text = (App.PaidFees + NewLicence.PaidFees).ToString();
                lbExpirationDate.Text = NewLicence.ExpirationDate.ToShortDateString();
                lbLicneceFees.Text = NewLicence.PaidFees.ToString();
                Enabling();

                OldLicense.IsActive = false;
                OldLicense.Save();
            }
            
        }
    }
}
