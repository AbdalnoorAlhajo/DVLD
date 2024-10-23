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
using System.Windows.Forms.VisualStyles;

namespace _DVLD___Project
{
    public partial class frmAddNewUser : Form
    {
        bool _IsPersonSelected = false;

        clsUsers _User;

        int _PersonID = -1;

        enum enMode { Add =  0, Update = 1 }
        enMode _Mode = enMode.Add;

        public frmAddNewUser(int ID = -1)
        {
            InitializeComponent();
            _PersonID = ID;
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            _User = clsUsers.FindByID(_PersonID);

            if (_User == null)
            {
                tbpLoginInfo.Enabled = false;
                _User = new clsUsers();
                return;
            }

            lbUserID.Text = _User.ID.ToString();
            txtUserName.Text = _User.UserName;
            if (_User.IsActive)
                checkBox1.Checked = true;

            _Mode = enMode.Update;
            lbAddNewPerson.Text = "Update User";

            tbpLoginInfo.Enabled = true;
            cntrlPersonlDetailsWithFillter1.FilterEnabled = false;
            cntrlPersonlDetailsWithFillter1.FillCard(_PersonID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text)
              || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please make sure to fill all Fields.", "Empty Fields"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            } 

            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Passwords do not match.", "Unmatch Passwords"
            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _User.PersonID = _PersonID;
            _User.Password = txtPassword.Text;
            _User.UserName = txtUserName.Text;
            _User.IsActive = checkBox1.Checked;

            if (_Mode == enMode.Add && _User.Save())
            {
                MessageBox.Show("User added successfully", "Done", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                lbUserID.Text = _User.PersonID.ToString();

                lbAddNewPerson.Text = "Update User";
                _Mode = enMode.Update;
                tbpLoginInfo.Enabled = false;
            }
            else if(_Mode == enMode.Update && _User.Save())
            {
                MessageBox.Show("User Updated successfully", "Done", MessageBoxButtons.OK
               , MessageBoxIcon.Information);
            }
             else
            {
                MessageBox.Show("failed to add user", "Error"
              , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!_IsPersonSelected)
            {
                MessageBox.Show("You have to find a Person record before creating a user"
                    , "Person is not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_Mode == enMode.Add && clsUsers.IsUserExists(_PersonID))
            {
                MessageBox.Show("This Person is already a user.", "Person reserved."
, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            tbpLoginInfo.Enabled = true;
            tbcAddForm.SelectTab(1);
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (clsUsers.IsUserExists(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This NationalNo already Exist.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password Sholud Be filled Before Confirmation.");
            }
            if (!txtConfirmPassword.Text.Equals(txtPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match");
            }
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
