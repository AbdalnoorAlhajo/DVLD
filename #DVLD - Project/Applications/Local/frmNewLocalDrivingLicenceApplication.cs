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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _DVLD___Project
{
    public partial class frmNewLocalDrivingLicenceApplication : Form
    {
        int _ApplicationID = -1;

        bool _IsPersonSelected = false;

        int _PersonID = -1;

        clsLocalApplications _Application;

        public frmNewLocalDrivingLicenceApplication()
        {
            InitializeComponent();
        }

        public frmNewLocalDrivingLicenceApplication(int ApplicationID)
        {
            InitializeComponent();
            this._ApplicationID = ApplicationID;
       
        }

        void LoadInfoIfExists(int ApplicationID)
        {
            _Application = clsLocalApplications.FindApplication(ApplicationID);
            lbTitle.Text = "Update Local Driving Licence Application";
            lbApplicationDate.Text = _Application.ApplicationDate.ToShortDateString();
            lbApplicationFees.Text = _Application.PaidFees.ToString();
            lbLocalApplicationID.Text = _Application.LocalDrivingLicenseApplicationID.ToString();
            cbLicenceClass.SelectedIndex = (_Application.LicenseClassID - 1);

            this.cntrlPersonlDetailsWithFillter1.FillCard(_Application.Person.ID);
            this.cntrlPersonlDetailsWithFillter1.FilterEnabled = false;
        }

        void SetComboBox()
        {
            DataTable LicenseClassesTable = clsLicenseClasses.GetAllLicenseClassesName();

            foreach (DataRow row in LicenseClassesTable.Rows)
            {
                cbLicenceClass.Items.Add(row[0].ToString());
            }

            cbLicenceClass.SelectedIndex = 0;
        }

        private void frmNewLocalDrivingLicenceApplication_Load(object sender, EventArgs e)
        {
            SetComboBox();
            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;

            lbApplicationFees.Text = clsApplicationTypes.FindApplicationType
             ("New Local Driving License Service").ApplicationTypeFees.ToString();
            
            if(_ApplicationID > 0)
                LoadInfoIfExists(_ApplicationID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsPersonSelected)
            {
                MessageBox.Show("You have to selecte a person First");
                return;
            }

            if (clsLocalApplications.IsNewApplication(_PersonID, 1)
                  && clsLocalApplications.IsPersonWithLicenseClassIDExists
                        (_PersonID,  cbLicenceClass.SelectedIndex + 1))
            {
                MessageBox.Show("This Person already have application");
                    return;
            }

            clsLocalApplications NewApplication = new clsLocalApplications();
            NewApplication.ApplicantID = _PersonID;
            NewApplication.PaidFees = decimal.Parse(lbApplicationFees.Text);
            NewApplication.ApplicationStatusDate = DateTime.Now;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.ApplicationTypeID = 1;
            NewApplication.CreatedByUserID = clsCurrentUser.CurrentUser.ID;
            NewApplication.LicenseClassID = cbLicenceClass.SelectedIndex + 1;


            if(NewApplication.Save())
            {
                MessageBox.Show("Application Added Successfully.");
                lbLocalApplicationID.Text
                    = NewApplication.LocalDrivingLicenseApplicationID.ToString();

                lbTitle.Text = "Update Local Driving Licence Application";
            }
            else
            {
                MessageBox.Show("Falied to Add Application");
             
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbcAddForm.SelectedIndex = 1;
        }

        private void cntrlPersonlDetailsWithFillter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;

            if (_PersonID > 0)
            {
                _IsPersonSelected = true;
                btnSave.Enabled = true;
            }
            else
            {
                _IsPersonSelected = false;
                btnSave.Enabled = false;
            }
        }
    }
}
