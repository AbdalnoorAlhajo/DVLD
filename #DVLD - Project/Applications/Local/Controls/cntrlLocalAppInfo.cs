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
    public partial class cntrlLocalAppInfo : UserControl
    {
        clsLocalApplications _LocalApplication;
        public cntrlLocalAppInfo()
        {
            InitializeComponent();
        }

        public void FillCardInfo(int LocalDrivingApplicationID)
        {   
            _LocalApplication = clsLocalApplications.FindLocalApplication(LocalDrivingApplicationID);

            lbLDAppID.Text = LocalDrivingApplicationID.ToString();

            lbPassedTests.Text = clsLocalApplications.GetPassedTests
                (LocalDrivingApplicationID).ToString();

            lbApplaiedForLicence.Text
                = clsLicenseClasses.GetLicenseClassName(_LocalApplication.LicenseClassID);

            linklbShowLicenceInfo.Enabled = clsLicenses.FindByApplicationID(_LocalApplication.ApplicationID) != null ?
                 true : false;
            

            lbPassedTests.Text = clsLocalApplications.GetPassedTests
                (LocalDrivingApplicationID).ToString() + "/3";
        }

        private void cntrlLocalAppInfo_Load(object sender, EventArgs e)
        {

        }

        private void linklbShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenceInfo frm = new frmShowLicenceInfo
                (clsLicenses.FindByApplicationID(_LocalApplication.ApplicationID).LicenseID);
            frm.ShowDialog();
        }
    }
}
