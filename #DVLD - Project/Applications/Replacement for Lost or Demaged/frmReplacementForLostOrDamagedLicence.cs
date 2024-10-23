using BusinessLayer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _DVLD___Project
{
    public partial class frmReplacementForLostOrDamagedLicence : Form
    {
        int _PersonID = -1, _LicneceID = -1;
        public frmReplacementForLostOrDamagedLicence()
        {
            InitializeComponent();
        }

        private void linklbShowLicenceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmshowPersonLiceneceHistory(_PersonID);
            frm.ShowDialog();
        }

        private void linklbShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLicenceInfo(_LicneceID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        clsApplicationTypes GetApplicationType()
        {
            if (rbLost.Checked)
                return clsApplicationTypes.FindApplicationType
                    ("Replacement for a Lost Driving License");
            else if (rbDamaged.Checked)
                return clsApplicationTypes.FindApplicationType
                    ("Replacement for a Damaged Driving License");
            else 
                return null;
        }

        clsApplications GetNewApplication()
        {
            clsApplications App = new clsApplications();
            App.ApplicantID = _PersonID;

            App.ApplicationStatus = clsApplications.enApplicationStatuses.Completed;
            App.ApplicationStatusDate = DateTime.Now;
            App.PaidFees = decimal.Parse(lbApplicationFees.Text);
            App.ApplicationDate = DateTime.Now;
            App.ApplicationTypeID = GetApplicationType().ApplicationTypeID;
            App.CreatedByUserID = clsCurrentUser.CurrentUser.ID;


            return (App.Save()) ? App : null;
        }

        clsLicenses AddNewLicence(clsLicenses OldLicense, clsApplications App)
        {
            clsLicenseClasses licenseClass = clsLicenseClasses.
                Find(OldLicense.LicenseClassID);

            clsLicenses NewLicence = new clsLicenses();
            NewLicence.DriverID = OldLicense.DriverID;
            NewLicence.Notes = OldLicense.Notes;
            NewLicence.IssueDate = DateTime.Now;
            NewLicence.PaidFees = OldLicense.PaidFees;
            NewLicence.ApplicationID = App.ApplicationID;
            NewLicence.CreatedByUserID = App.CreatedByUserID;
            NewLicence.ExpirationDate = DateTime.Now.
                AddYears(licenseClass.DefaultValidityLength);
            NewLicence.IsActive = true;
            NewLicence.IssueReason = (rbLost.Checked) ? 3 : 4;
            NewLicence.LicenseClassID = OldLicense.LicenseClassID;

            return (NewLicence.Save()) ? NewLicence : null;
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {

            clsLicenses OldLicense = clsLicenses.FindByLicenseID(_LicneceID);

            if(!OldLicense.IsActive)
            {
                MessageBox.Show("Sorry, License is not active", "Unactive License", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

                btnIssueReplacement.Enabled = false;

                return;
            }

            clsApplications App = GetNewApplication();

            if (App != null)
            {
                clsLicenses NewLicence = AddNewLicence(OldLicense, App);

                lbReplacedLicneceID.Text = NewLicence.LicenseID.ToString();
                lbLRApplicationID.Text = App.ApplicationID.ToString();

                cntrlDriverLicenceInfoWithFillter1.EnablingFillter(false);         
                
                OldLicense.IsActive = false;
                OldLicense.Save();

                btnIssueReplacement.Enabled = false;
            }
        }

        void LoadInitialInfo()
        {
            clsApplicationTypes AppType = GetApplicationType();

            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbApplicationFees.Text = AppType.ApplicationTypeFees.ToString();
            lbOldLicneceID.Text = _LicneceID.ToString();

            if (clsCurrentUser.CurrentUser != null)
                lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;

        }

        private void frmReplacementForLostOrDamagedLicence_Load(object sender, EventArgs e)
        {
            rbLost.Checked = true;
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lbApplicationFees.Text = GetApplicationType().ApplicationTypeFees.ToString();
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lbApplicationFees.Text = GetApplicationType().ApplicationTypeFees.ToString();
        }

        private void cntrlDriverLicenceInfoWithFillter1_OnLicenceSelected(int obj)
        {
            if (obj < 0)
                return;

            _LicneceID = obj;
            linklbShowLicenceHistory.Enabled = true;
            linklbShowLicenceInfo.Enabled = true;            
  
            this._PersonID = clsDrivers.FindDriverByDriverID
                     (clsLicenses.FindByLicenseID(_LicneceID).DriverID).PersonID;

            LoadInitialInfo();

            btnIssueReplacement.Enabled = true;
        }
    }
}
