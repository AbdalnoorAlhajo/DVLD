using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DVLD___Project
{
    public partial class frmNewAppointment : Form
    {
        clsLocalApplications LApp;
        int TestTypeID = -1, TestAppointmentID = -1;
        bool IsUpdate = false;

        public frmNewAppointment(clsLocalApplications LApp, int TestType
            , int AppointmentID = -1, bool IsUpdate = false)
        {
            InitializeComponent();
            this.TestTypeID = TestType;
            this.LApp = LApp;
            this.TestAppointmentID = AppointmentID;
            this.IsUpdate = IsUpdate;
        }


        private void gbMain_Enter(object sender, EventArgs e)
        {
             
        }

        void LoadRetakeInfo(int Trails)
        {
            if(Trails > 0)
            {
                gbRetakeTestInfo.Enabled = true;
                lbRAppFees.Text = (5).ToString();
                lbTotalFees.Text = ( 5 + decimal.Parse(lbFees.Text)).ToString();
        
                if(IsUpdate )
                    lbRTestAppID.Text = clsTestAppointments.GetLastTestAppointmentID
    (LApp.LocalDrivingLicenseApplicationID, TestTypeID).ToString();

            }
        }

        void IsTestAppointmentExist()
        {
            if (clsTestAppointments.IsTestAppointmentTaken(TestAppointmentID))
            {
                lbPersonHaveAppointment.Visible = true;
                btnSave.Enabled = false;
                dateTimePicker1.Enabled = false;    
            }
        }

        void LoadPageInfo()
        {
            dateTimePicker1.MinDate = DateTime.Now;
            lbFees.Text = clsTestTypes.GetTestTypeFees(TestTypeID).ToString();
            lbTotalFees.Text = lbFees.Text;
            lbLDAppID.Text = LApp.LocalDrivingLicenseApplicationID.ToString();

            clsPeople Person = clsPeople.Find(LApp.ApplicantID);
            lbName.Text = Person.FirstName + " " + Person.SecondName
  + " " + Person.ThirdName + " " + Person.LastName;

            lbClass.Text = clsLicenseClasses.GetLicenseClassName(LApp.LicenseClassID);

            int Trails = clsTestAppointments.GetTrails(
                LApp.LocalDrivingLicenseApplicationID, TestTypeID);

            LoadRetakeInfo(Trails);

            lbTrail.Text = Trails.ToString();

            IsTestAppointmentExist();
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

        private void frmNewAppointment_Load(object sender, EventArgs e)
        {
            LoadPageInfo();
            LoadImage();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool SaveNewAppointment()
        {
            clsTestAppointments TAppointment = new clsTestAppointments();
            TAppointment.TestTypeID = TestTypeID;
            TAppointment.LocalDrivingLicenseApplicationID = int.Parse(lbLDAppID.Text);
            TAppointment.AppointmentDate = dateTimePicker1.Value;
            TAppointment.CreateByUserID = LApp.CreatedByUserID;
            TAppointment.PaidFees = decimal.Parse(lbTotalFees.Text);

            if (TAppointment.Save())
            {
                MessageBox.Show("Test Appoitment added Successfully.");
                TestAppointmentID = TAppointment.TestAppointmentID;
                return true;
            }

            else
                MessageBox.Show("failed to add Test Appoitment.");

            return false;
        }

        bool UpdateAppointment()
        {
            clsTestAppointments TAppointment 
                = clsTestAppointments.Find(TestAppointmentID);

            TAppointment.TestTypeID = TestTypeID;
            TAppointment.LocalDrivingLicenseApplicationID = int.Parse(lbLDAppID.Text);
            TAppointment.AppointmentDate = dateTimePicker1.Value;
            TAppointment.CreateByUserID = LApp.CreatedByUserID;
            TAppointment.PaidFees = decimal.Parse(lbFees.Text);

            if (TAppointment.Save())
            {
                MessageBox.Show("Test Appoitment Updated Successfully.");
                return true;
            }

            else
                MessageBox.Show("failed to Update Test Appoitment.");

            return false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TestAppointmentID <= 0)
                SaveNewAppointment();
            else
                UpdateAppointment();

        }

    }
}
