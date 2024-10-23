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

namespace _DVLD___Project.Applications.Local
{
    public partial class frmShowApplicationDetails : Form
    {
        public frmShowApplicationDetails(int LocalApplicationID)
        {
            InitializeComponent();
            cntrlApplicationBasicInfo1.FillApplicationInfo(clsLocalApplications.FindLocalApplication(LocalApplicationID).ApplicationID);
            cntrlLocalAppInfo1.FillCardInfo(LocalApplicationID);
        }

        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
