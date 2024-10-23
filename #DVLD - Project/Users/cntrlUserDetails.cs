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
    public partial class cntrlUserDetails : UserControl
    {
        public cntrlUserDetails()
        {
            InitializeComponent();
        }
          

        private void cntrlUserDetails_Load(object sender, EventArgs e)
        {

        }

        public void ChangeInfo(string UserName, int UserID, bool isActive,int PersonID)
        {
            this.cntrlPersonDetails1.FillCardWithInfo(PersonID);
            lbUserName.Text = UserName;
            lbUserID.Text = UserID.ToString();

            if (isActive)
                lbIsActive.Text = "yes";
            else
                lbIsActive.Text = "No";
        }

        private void cntrlPersonDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
