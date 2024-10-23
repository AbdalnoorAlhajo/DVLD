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
    public partial class cntrlInternationalDriverLicenceInfo : UserControl
    {
        public cntrlInternationalDriverLicenceInfo()
        {
            InitializeComponent();
        }
        public void FillCardWithInfoWithInternationaLicenseID(int InternationaLicenseID)
        {
            clsInternationalLicenses IntLicence = clsInternationalLicenses.Find
                (InternationaLicenseID);

            clsLicenses license = clsLicenses.FindByLicenseID
                (IntLicence.IssuedUsingLocalLicenseID);

            clsDrivers driver = clsDrivers.FindDriverByDriverID(license.DriverID);
            clsPeople Person = clsPeople.Find(driver.PersonID);

            lbName.Text = Person.FirstName + " " + Person.SecondName + " "
                + Person.ThirdName + " " + Person.LastName;

            lbInternationalLicenceID.Text = InternationaLicenseID.ToString();
            lbLicenceID.Text = license.LicenseID.ToString();
            lbNationalNo.Text = Person.NationalNo;
            lbGender.Text = (Person.Gender == clsPeople.enGender.Male) ? "Male" : "Female";
            lbIssueDate.Text = IntLicence.IssueDate.ToShortDateString();
            lbIsActive.Text = (IntLicence.IsActive) ? "Yes" : "No";
            lbDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            lbDriverID.Text = IntLicence.DriverID.ToString();
            lbExiprationDate.Text = IntLicence.ExpirationDate.ToShortDateString();
        }
        private void cntrlInternationalDriverLicenceInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
