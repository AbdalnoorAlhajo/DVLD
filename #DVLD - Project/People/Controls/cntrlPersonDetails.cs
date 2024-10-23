using _DVLD___Project.Properties;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _DVLD___Project
{
    public partial class cntrlPersonDetails : UserControl
    {
        clsPeople _Person;

        public int PersonID = -1;
        public cntrlPersonDetails()
        {
            InitializeComponent();
        }

        void _LoadImage()
        {
            if (_Person.Gender == clsPeople.enGender.Female)
                pbPersonImage.Image = Resources.person_woman;
            else
                pbPersonImage.Image = Resources.person_boy;

            if(!string.IsNullOrEmpty(_Person.ImagePath))
            {
                if (File.Exists(_Person.ImagePath))
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + _Person.ImagePath
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void FillCardWithInfo(int PersonID)
        {
            _Person = clsPeople.Find(PersonID);

            if (_Person == null)
            {
                ResetPersonInfo();
                return;
            }

            this.PersonID = PersonID;
            lbName.Text = _Person.FullName;
            lbNationalNo.Text = _Person.NationalNo;
            lbGender.Text = _Person.Gender == clsPeople.enGender.Male ? "Male" : "Female";
            lbEmail.Text = _Person.Email;
            lbDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lbPhone.Text = _Person.Phone;
            lbCountry.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName;
            lbAddress.Text = _Person.Address;
            lbPersonID.Text = PersonID.ToString();

            _LoadImage();

            lbEditInfo.Enabled = true;

        }

        public void ResetPersonInfo()
        {
            PersonID = -1;
            lbPersonID.Text = "[????]";
            lbNationalNo.Text = "[????]";
            lbName.Text = "[????]";
            pbPersonImage.Image = Resources.person_boy;
            lbGender.Text = "[????]";
            lbEmail.Text = "[????]";
            lbPhone.Text = "[????]";
            lbDateOfBirth.Text = "[????]";
            lbCountry.Text = "[????]";
            lbAddress.Text = "[????]";

        }

        private void lbEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(PersonID);
            frm.ShowDialog();

            // Refresh
            FillCardWithInfo(PersonID);
        }

        private void cntrlPersonDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
