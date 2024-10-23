using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _DVLD___Project
{
    public partial class frmNewInternationalLicenceApplication : Form
    {
        int _PersonID, _InternationalLicneceID, _LicneceID;
        public frmNewInternationalLicenceApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int AddNewApplication(int DriverID)
        {
            clsDrivers Driver = clsDrivers.FindDriverByDriverID(DriverID);
            clsApplicationTypes AppType = clsApplicationTypes.FindApplicationType
                ("New International License");

            clsApplications application = new clsApplications();
            application.ApplicantID = Driver.PersonID;
            this._PersonID = Driver.PersonID;

            application.ApplicationStatus = clsApplications.enApplicationStatuses.Completed;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatusDate = DateTime.Now;
            application.ApplicationTypeID = AppType.ApplicationTypeID;
            application.PaidFees = AppType.ApplicationTypeFees;
            if (clsCurrentUser.CurrentUser != null)
                application.CreatedByUserID = clsCurrentUser.CurrentUser.ID;

            return application.Save() ? application.ApplicationID : -1;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (clsInternationalLicenses.IsLicenseExistByLicenseID(_LicneceID))
            {
                MessageBox.Show("This License already a International License", "Process can not be done"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_LicneceID > 0)
            {
                clsLicenses LocalL = clsLicenses.FindByLicenseID(_LicneceID);
                
                if(LocalL.LicenseClassID != 3)
                {
                    MessageBox.Show("License Class should be type ordinary");
                    return;
                }

            clsInternationalLicenses InternationalL = new clsInternationalLicenses();
                InternationalL.ApplicationID = AddNewApplication(LocalL.DriverID);
                InternationalL.IssueDate = DateTime.Now;
                InternationalL.ExpirationDate = DateTime.Now.
                    AddYears(clsLicenseClasses.Find(3).DefaultValidityLength);

                if (clsCurrentUser.CurrentUser != null)
                    InternationalL.CreatedByUserID = clsCurrentUser.CurrentUser.ID;
                InternationalL.DriverID = LocalL.DriverID;
                InternationalL.IsActive = true;
                InternationalL.IssuedUsingLocalLicenseID = LocalL.LicenseID;
               
                if(InternationalL.AddLicense())
                {
                    MessageBox.Show("License added Successfully.");
                    btnIssue.Enabled = false;

                    this._InternationalLicneceID = InternationalL.InternationalLicenseID;
                    linklbShowLicenceInfo.Enabled = true;


                    this.cntrlInternationalApplicationInfo1.
                        FillCardWithInternationalLicenceInfo
                        (InternationalL.InternationalLicenseID);

                }    
            }

        }

        private void linklbShowLicenceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmshowPersonLiceneceHistory(_PersonID);
            frm.ShowDialog();
        }

        private void cntrlDriverLicenceInfoWithFillter1_OnLicenceSelected(int obj)
        {
            _LicneceID = obj;
            if (_LicneceID < 0)
                return;

            _PersonID = clsDrivers.FindDriverByDriverID
                    (clsLicenses.FindByLicenseID(_LicneceID).DriverID).PersonID;

            linklbShowLicenceHistory.Enabled = true;
            btnIssue.Enabled = true;

        }

        private void linklbShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverInternationalLincenceInfo
                (_InternationalLicneceID);
            frm.ShowDialog();
        }
    }
}
