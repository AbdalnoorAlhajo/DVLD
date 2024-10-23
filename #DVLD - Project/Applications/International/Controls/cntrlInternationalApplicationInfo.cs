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
    public partial class cntrlInternationalApplicationInfo : UserControl
    {
        public cntrlInternationalApplicationInfo()
        {
            InitializeComponent();
        }

        void LoadFees()
        {
            clsApplicationTypes AppType = clsApplicationTypes.FindApplicationType
    ("New International License");

            lbFees.Text = AppType.ApplicationTypeFees.ToString();
        }

       void FillCardWithInitialInfo()
        {
            clsLicenseClasses licenseClass = clsLicenseClasses.Find(3);

            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            if (clsCurrentUser.CurrentUser != null
                && clsCurrentUser.CurrentUser.UserName != null)
            {
                lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;
            }
            lbIssueDate.Text = DateTime.Now.ToShortDateString();
            lbExpirationDate.Text = DateTime.Now.AddYears
                (licenseClass.DefaultValidityLength).ToShortDateString();  



        }

        public void FillCardWithInternationalLicenceInfo(int InternationalLicenseID)
        {
            clsInternationalLicenses LL = clsInternationalLicenses.
                Find(InternationalLicenseID);

            lbLLApplicationID.Text = LL.ApplicationID.ToString();
            lbLocalLicneceID.Text = LL.IssuedUsingLocalLicenseID.ToString();
            lbLicneceID.Text = LL.InternationalLicenseID.ToString();
        }
        private void cntrlInternationalApplicationInfo_Load(object sender, EventArgs e)
        {
            LoadFees();
            FillCardWithInitialInfo();

        }
    }
}
