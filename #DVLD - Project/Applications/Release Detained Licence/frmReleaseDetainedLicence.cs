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
using static System.Net.Mime.MediaTypeNames;

namespace _DVLD___Project
{
    public partial class frmReleaseDetainedLicence : Form
    {
        int _PersonID = -1, _LicneceID = -1;

        public frmReleaseDetainedLicence()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicence(int LicenceID)
        {
            InitializeComponent();
            cntrlDriverLicenceInfoWithFillter1.LicenceID = LicenceID;
            cntrlDriverLicenceInfoWithFillter1.ChangeSerachText();
            cntrlDriverLicenceInfoWithFillter1.EnablingFillter(false);
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

        clsApplications GetNewApplication()
        {
            clsApplicationTypes AppType = clsApplicationTypes.
                    FindApplicationType("Release Detained Driving Licence");

            clsApplications App = new clsApplications();
            App.ApplicantID = _PersonID;
            App.ApplicationStatus = clsApplications.enApplicationStatuses.Completed;
            App.ApplicationStatusDate = DateTime.Now;
            App.ApplicationDate = DateTime.Now;
            App.CreatedByUserID = clsCurrentUser.CurrentUser.ID;

            App.PaidFees = AppType.ApplicationTypeFees;
            App.ApplicationTypeID = AppType.ApplicationTypeID;


            return (App.Save()) ? App : null;
        }

        bool ReleaseDetainedLicence(ref clsDetainedLicences DetainedLicenceToRelease)
        {
            DetainedLicenceToRelease.ReleaseApplicationID = int.Parse(lbApplicationID.Text);
            DetainedLicenceToRelease.ReleaseDate = DateTime.Now;
            DetainedLicenceToRelease.IsReleased = true;
            DetainedLicenceToRelease.ReleasedByUserID = clsCurrentUser.CurrentUser.ID;

            return DetainedLicenceToRelease.Save();
        }

        void FillDetainInfoCard()
        {
            clsDetainedLicences DetainedLicence = clsDetainedLicences.FindByLicenseID
                (_LicneceID);

            lbCreatedBy.Text = clsUsers.FindByUserID
                (DetainedLicence.CreatedByUserID).UserName;

            lbDetainDate.Text = DetainedLicence.DetainDate.ToShortDateString();
            lbDetainID.Text = DetainedLicence.DetainID.ToString();
            lbFineFees.Text = DetainedLicence.FineFees.ToString();
            lbLicneceID.Text = DetainedLicence.LicenseID.ToString();

            lbApplicationFees.Text = clsApplicationTypes.FindApplicationType
                ("Release Detained Driving Licsense").ApplicationTypeFees.ToString();

            lbTotalFees.Text = (decimal.Parse(lbApplicationFees.Text) 
                + DetainedLicence.FineFees).ToString();
                
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (!clsDetainedLicences.IsLicenseDetained(_LicneceID))
            {
                MessageBox.Show("License is not Detained");
                return;
            }

            clsApplications App = GetNewApplication();

            lbApplicationID.Text = App.ApplicationID.ToString();

            clsDetainedLicences DetainedLicenceToRelease = clsDetainedLicences.
                FindByLicenseID(_LicneceID);


            if (ReleaseDetainedLicence(ref DetainedLicenceToRelease))
                MessageBox.Show("License is Released", "Done", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

        }

        private void cntrlDriverLicenceInfoWithFillter1_OnLicenceSelected(int obj)
        {
            _LicneceID = obj;

            if (_LicneceID < 0)
                return;

            this._PersonID = clsDrivers.FindDriverByDriverID
                     (clsLicenses.FindByLicenseID(_LicneceID).DriverID).PersonID;

            linklbShowLicenceHistory.Enabled = true;
            linklbShowLicenceInfo.Enabled = true;

            if (!clsDetainedLicences.IsLicenseDetained(_LicneceID))
            {
                MessageBox.Show("License is not Detained");
                btnRelease.Enabled = false;
                return;
            }

            FillDetainInfoCard();
            btnRelease.Enabled = true;

        }

    }
}
