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
    public partial class frmNewScheduleTest : Form
    {
        clsLocalApplications LApp;
        int TestTypeID = -1;

        DataTable TestAppointmentsTable;

        public frmNewScheduleTest(int LocalApplicationID, int TestTypeID)
        {
            InitializeComponent();
            LApp = clsLocalApplications.FindLocalApplication(LocalApplicationID);
            this.TestTypeID = TestTypeID;
        }

        void RefreshPage()
        {
            TestAppointmentsTable = clsTestAppointments.GetAllTestAppointmentsView
                (LApp.LocalDrivingLicenseApplicationID, TestTypeID);

            dataGridView1.DataSource = TestAppointmentsTable;

            if (dataGridView1.RowCount > 0)
                lbRecordCount.Text = (dataGridView1.RowCount - 1).ToString();
        }

        void FillPictureBoxes()
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

            pbNewTest.Image = Image.FromFile
(@"C:\Users\Abdalrahman\Desktop\Programming Advaices\Level 19_Programming advices\#DVLD - Project\Images\Add_Schedule.png");
        }

        void FillCardsWithInfo()
        {
            cntrlApplicationBasicInfo1.FillApplicationInfo(LApp.ApplicationID);
            cntrlLocalAppInfo1.FillCardInfo(LApp.LocalDrivingLicenseApplicationID);
        }

        void AdjustTestTitleAccordingToID()
        {
            switch(TestTypeID)
            {
                case 1:
                    lbTestName.Text = "Vision" + " Test Appointments";
                    break;
                case 2:
                    lbTestName.Text = "Written" + " Test Appointments";
                    break;
                case 3:
                    lbTestName.Text = "Street" + " Test Appointments";
                    break;
            }
                
        }

        private void frmNewScheduleTest_Load(object sender, EventArgs e)
        {
            FillCardsWithInfo();
            FillPictureBoxes();
            AdjustTestTitleAccordingToID();

            if (dataGridView1.RowCount > 0)
                lbRecordCount.Text = (dataGridView1.RowCount-1).ToString();

            TestAppointmentsTable = clsTestAppointments.GetAllTestAppointmentsView
                (LApp.LocalDrivingLicenseApplicationID, TestTypeID);

            dataGridView1.DataSource = TestAppointmentsTable;

       
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNewTest_Click(object sender, EventArgs e)
        {
            if(clsLocalApplications.IsDriverPassedTest(LApp.LocalDrivingLicenseApplicationID
                , TestTypeID))
            {
                MessageBox.Show("This Person Passed the Test");
                return;
            }

            if (clsTestAppointments.IsTestAppointmentExist(TestTypeID
    , LApp.LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("This Person Already have an active Appointment .");
                return;
            }
            Form frm = new frmNewAppointment(LApp, TestTypeID);
            frm.ShowDialog();

            RefreshPage();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewAppointment(LApp, TestTypeID,
                (int)dataGridView1.CurrentRow.Cells[0].Value, true);
            frm.ShowDialog();
            RefreshPage();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTakeTest(LApp, TestTypeID
    , (int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
