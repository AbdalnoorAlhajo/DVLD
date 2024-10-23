using _DVLD___Project.Properties;
using BusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace _DVLD___Project
{
    public partial class cntrlPerson : UserControl
    {
        int _PersonID  = -1 ;

        public clsPeople _Person = null;

        public cntrlPerson()
        {
            InitializeComponent();
        }


        public int PersonID { get { return _PersonID; } }

        public void LoadPersonInfo(int PersonID)
        {
            _PersonID = PersonID;
            _Person = clsPeople.Find(_PersonID);

            if (_Person != null)
            {
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName;
                txtLastName.Text = _Person.LastName;
                txtNationalNo.Text = _Person.NationalNo;
                txtEmail.Text = _Person.Email;
                txtAddress.Text = _Person.Address;
                cbCountries.SelectedIndex = _Person.NationalityCountryID - 1;
                txtPhone.Text = _Person.Phone;
                dtBirthOfDate.Text = _Person.DateOfBirth.ToString();
                lbID.Text = _Person.ID.ToString();

                if (_Person.Gender == clsPeople.enGender.Male)
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;

                try
                {
                    if (File.Exists(_Person.ImagePath))
                        pbPersonImage.ImageLocation = _Person.ImagePath;
                    else if (_Person.Gender == clsPeople.enGender.Male)
                        pbPersonImage.Image = Resources.person_boy;
                    else
                        pbPersonImage.Image = Resources.person_woman;
                }
                catch
                {
                    pbPersonImage.Image = Resources.person_boy;
                }
            }
            else
            {
                dtBirthOfDate.MaxDate = DateTime.Now.AddYears(-18);
                _Person = new clsPeople();
            }
        }

        void LoadCbCountries()
        {
            DataTable dt = clsCountries.GetAllCountriesName();

            foreach (DataRow dr in dt.Rows)
            {
                cbCountries.Items.Add(dr[0].ToString());
            }
            cbCountries.SelectedIndex = 0;
        }

        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = saveFileDialog1.FileName;
                pbPersonImage.Load(FileName);
            
                

            }
        }

        bool HandleImage()
        {
            if(pbPersonImage.ImageLocation != _Person.ImagePath)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException) { }
                }

                if(pbPersonImage.ImageLocation != null)
                {
                    string SourceFileName = pbPersonImage.ImageLocation.ToString();
                    if(clsUtil.CopyImageToProjectImagesFolder(ref SourceFileName))
                    {
                        pbPersonImage.ImageLocation = SourceFileName;
                        return true;
                    }
                    else
                        return false;
                }
            }
            return true;
        }


        public void Save()
        {
            if (IsThereSomethingEmpty())
            {
                MessageBox.Show("You Should fill the requared Filled", "Warning", MessageBoxButtons.OK
     , MessageBoxIcon.Warning);
                return;
            }

            if (!HandleImage())
                return;

            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.NationalityCountryID = cbCountries.SelectedIndex + 1;
            _Person.Phone = txtPhone.Text;
            _Person.DateOfBirth = DateTime.Parse(dtBirthOfDate.Text);

            if (rbMale.Checked)
                _Person.Gender = clsPeople.enGender.Male;
            else
                _Person.Gender = clsPeople.enGender.Female;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation.ToString();
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                MessageBox.Show("Done Successfully", "Done", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                _Person.Mode = clsPeople.enMode.Update;
                _PersonID = _Person.ID;
            }
            else
                MessageBox.Show("Something Went Wrong.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            lbID.Text = _Person.ID.ToString();
            LoadPersonInfo(_PersonID);
        }

        private bool IsThereSomethingEmpty()
        {
            return (string.IsNullOrEmpty(txtFirstName.Text)|| string.IsNullOrEmpty(txtSecondName.Text)
        || string.IsNullOrEmpty(txtThirdName.Text) || string.IsNullOrEmpty(txtLastName.Text)
        || string.IsNullOrEmpty(txtAddress.Text)
        || string.IsNullOrEmpty(txtNationalNo.Text) || string.IsNullOrEmpty(txtPhone.Text));
        }


        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPeople.IsPersonExists(txtNationalNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This NationalNo already Exist.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if(pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.person_woman;
        }

        private void rbMale_Click(object sender, EventArgs e) 
        {
            if(pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.person_boy;
        }

        private void cntrlPerson_Load(object sender, EventArgs e)
        {
            LoadCbCountries();

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                return;


            if (!txtEmail.Text.Contains("@gmail.com") )
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Email should have '@gmail.com'");
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
