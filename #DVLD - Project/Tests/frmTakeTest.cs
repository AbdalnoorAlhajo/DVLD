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
    public partial class frmTakeTest : Form
    {
        clsLocalApplications LApp;
        int TestTypeID = -1, TestAppointmentID = -1;
        public frmTakeTest(clsLocalApplications LApp, int TestType
            , int AppointmentID = -1)
        {
            InitializeComponent();
            this.TestTypeID = TestType;
            this.LApp = LApp;
            this.TestAppointmentID = AppointmentID;
        }


        bool IsTestAlreadyTaken()
        {
            int TestID = clsTests.GetTestID(TestAppointmentID);
            if (TestID > 0)
            {
                btnSave.Enabled = false;
                txtNotes.Enabled = false;
                lbTestID.Text = TestID.ToString();
     
                return true;
            }
            else
                return false;
        }

        void LoadPageInfo()
        {
            if (clsTests.IsTestExistAndPass(TestAppointmentID))
            {
                btnSave.Enabled = false;
            }

            lbDateTime.Text = clsTestAppointments.GetDateTime(TestAppointmentID).ToShortDateString();
            lbFees.Text = (clsTestTypes.GetTestTypeFees(TestTypeID) ).ToString();
            lbLDAppID.Text = LApp.LocalDrivingLicenseApplicationID.ToString();

            clsPeople Person = clsPeople.Find(LApp.ApplicantID);
            lbName.Text = Person.FirstName + " " + Person.SecondName
  + " " + Person.ThirdName + " " + Person.LastName;

            lbClass.Text = clsLicenseClasses.GetLicenseClassName(LApp.LicenseClassID);

            int Trails = clsTestAppointments.GetTrails(
                LApp.LocalDrivingLicenseApplicationID, TestTypeID);

            lbTrail.Text = Trails.ToString();
            if(Trails > 0)
                lbFees.Text = (clsTestTypes.GetTestTypeFees(TestTypeID) + 5).ToString();

            IsTestAlreadyTaken();
        }

        void LoadImage()
        {
            switch (TestTypeID)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile
 (@"C:\Users\Abdalrahman\Desktop\Programming Advaices\Level 19_Programming advices\#DVLD - Project\Images\eye_open.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile
(@"C:\Users\Abdalrahman\Desktop\Programming Advaices\Level 19_Programming advices\#DVLD - Project\Images\Exam.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile
(@"C:\Users\Abdalrahman\Desktop\Programming Advaices\Level 19_Programming advices\#DVLD - Project\Images\Car.png");

                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTests Test = new clsTests();
            Test.TestAppointmentID = TestAppointmentID;
            Test.CreatedByUserID = LApp.CreatedByUserID;
            Test.Notes = txtNotes.Text;

            if (rbPass.Checked)
                Test.TestResult = 1;
            else if (rbFail.Checked)
                Test.TestResult = 0;
            else
                return;


            if (Test.AddNewTest())
            {
                MessageBox.Show("Test Added Successfully");
                if (rbPass.Checked && TestTypeID == 3)
                    clsApplications.UpdateApplicationStatus(LApp.ApplicationID, 3);
            }
            else
                MessageBox.Show("Failed to add Test");

            this.Close();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadPageInfo();
            LoadImage();
        }
    }
}
