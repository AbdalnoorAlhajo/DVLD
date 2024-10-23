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
    public partial class frmUserDetails : Form
    {
        clsUsers User = null;
        public frmUserDetails(int PersonID)
        {
            User = clsUsers.FindByID(PersonID);
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cntrlUserDetails1_Load(object sender, EventArgs e)
        {

        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            this.cntrlUserDetails1.ChangeInfo(User.UserName, User.ID, User.IsActive, User.PersonID);
        }
    }
}
