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
    public partial class cntrlApplicationBasicInfo : UserControl
    {
        private int PersonID { get; set; }
        public cntrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private void cntrlApplicationBasicInfo_Load(object sender, EventArgs e)
        {

        }

        public void FillApplicationInfo(int ApplicationID)
        {
           clsApplications Application = clsApplications.FindApplication(ApplicationID);
            if (Application == null) return;

            clsPeople Person = clsPeople.Find(Application.ApplicantID);
            clsUsers CreatedByUser = clsUsers.FindByUserID(Application.CreatedByUserID);
            clsApplicationTypes Type 
                = clsApplicationTypes.FindApplicationType(Application.ApplicationTypeID);

            lbID.Text = Application.ApplicationID.ToString();
            lbFees.Text = Application.PaidFees.ToString();
            lbCreatedBy.Text = CreatedByUser.UserName;
            lbDate.Text = Application.ApplicationDate.ToShortDateString();
            lbStatusDate.Text = Application.ApplicationStatusDate.ToShortDateString();
            lbType.Text = Type.ApplicationTypeTilte.ToString();
            lbApplicant.Text = Person.FirstName + " " + Person.SecondName
              + " " + Person.ThirdName + " " + Person.LastName;

            switch(Application.ApplicationStatus)
            {
                case clsApplications.enApplicationStatuses.New:
                    lbStatus.Text = "New";
                    break;
                case clsApplications.enApplicationStatuses.Completed:
                    lbStatus.Text = "Completed";
                    break;
                case clsApplications.enApplicationStatuses.Canceled:
                    lbStatus.Text = "Canceled";
                    break;
                default:
                    lbStatus.Text = "{???}";
                    break;
            }

            PersonID = Application.ApplicantID;

        }

        private void lbLinkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowPersonDetails(PersonID);
            frm.ShowDialog();
        }
    }
}
