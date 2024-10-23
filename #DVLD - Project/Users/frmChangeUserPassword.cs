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
    public partial class frmChangeUserPassword : Form
    {
        clsUsers User = null;
        public frmChangeUserPassword(int PersonID)
        {
            User = clsUsers.FindByID(PersonID);

            InitializeComponent();
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            this.cntrlUserDetails1.ChangeInfo(User.UserName, User.ID, User.IsActive, User.PersonID);
            
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!clsUtil.ComputeHash(txtCurrentPassword.Text).Equals( User.Password))
            {
                errorProvider1.SetError(txtCurrentPassword, "Wrong Password");
            }
            else
                errorProvider1.Clear();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!txtConfirmPassword.Text.Equals(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords not match");
            }
            else
                errorProvider1.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsUtil.ComputeHash(txtCurrentPassword.Text).Equals(User.Password))
            {
                MessageBox.Show("Current Password does not match the user's.", "Wrong Password"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtCurrentPassword, "Wrong Password");
                return;
            }
            else
                errorProvider1.Clear();

            if (!txtConfirmPassword.Text.Equals(txtNewPassword.Text))
            {
                MessageBox.Show("New Password does not match the confirmation's.", "Wrong Password"
       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtConfirmPassword, "Passwords not match");
                return;
            }
            else
                errorProvider1.Clear();

            User.Password = txtConfirmPassword.Text;

            if(User.Save())
            {
                MessageBox.Show("Password Changed succesfully", "Done"
       , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to change password.", "Failed"
       , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
