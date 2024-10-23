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
    public partial class cntrlDriverLicenceInfo : UserControl
    {
        public cntrlDriverLicenceInfo()
        {
            InitializeComponent();
        }

        public void FillCardWithInfo(int LicenseID)
        {
            clsLicenses license = clsLicenses.FindByLicenseID(LicenseID);

            clsLicenseClasses licenseClass = clsLicenseClasses.Find(license.LicenseClassID);
            clsDrivers driver = clsDrivers.FindDriverByDriverID(license.DriverID);
            clsPeople Person = clsPeople.Find(driver.PersonID);
            

            lbClass.Text = licenseClass.ClassName;
            lbName.Text = Person.FirstName + " " + Person.SecondName+ " " 
                + Person.ThirdName+ " " + Person.LastName;

            lbLicenceID.Text = license.LicenseID.ToString();
            lbNationalNo.Text = Person.NationalNo;
            lbGender.Text =(Person.Gender == clsPeople.enGender.Male) ?"Male":"Female";
            lbIssueDate.Text = license.IssueDate.ToShortDateString();
            lbIssueReason.Text = license.IssueReason.ToString();
            lbIsActive.Text = (license.IsActive) ? "Yes" : "No";
            lbDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            lbDriverID.Text = license.DriverID.ToString();
            lbExiprationDate.Text = license.ExpirationDate.ToShortDateString();

            lbNotes.Text = (string.IsNullOrEmpty(license.Notes))
                     ? "No Notes" : license.Notes;

            lbIsDetained.Text = (clsDetainedLicences.IsLicenseDetained(LicenseID))
                     ? "Yes" : "No";
        }

        private void cntrlDriverLicenceInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
