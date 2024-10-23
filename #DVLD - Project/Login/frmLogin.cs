using _DVLD___Project.Global_Classes;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsCurrentUser.CurrentUser = clsUsers.Find(txtUserName.Text, txtPassword.Text);

            if (clsCurrentUser.CurrentUser != null)
            {
                if (checkBRememberMe.Checked)
                    clsGlobal.RememberUserNameAndPassword(
                        clsCurrentUser.CurrentUser.UserName
                            , clsCurrentUser.CurrentUser.Password);
                else
                    clsGlobal.RememberUserNameAndPassword("", "");

                if (clsCurrentUser.CurrentUser.IsActive)
                {
                    Form frm = new frmMainScreen();
                    this.Hide();
                    frm.Show();
                }
                else
                    MessageBox.Show("User is not Active");

            }
            else
            {
                MessageBox.Show("wrong username/password");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string userName = "", password = "";
            if(clsGlobal.GetStoredCredential(ref userName,ref password))
            {
                txtUserName.Text = userName;
                txtPassword.Text = password;
                checkBRememberMe.Checked = true;
            }
            else
                checkBRememberMe.Checked = false;
        }
    }
}
