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
    public partial class frmShowLicenceInfo : Form
    {
        int LicenceID;
        public frmShowLicenceInfo(int LicenceID)
        {
            InitializeComponent();
            this.LicenceID = LicenceID;
        }

        private void frmShowLicenceInfo_Load(object sender, EventArgs e)
        {
            this.cntrlDriverLicenceInfo1.FillCardWithInfo(LicenceID);
            pictureBox1.Image = Image.FromFile
(@"C:\Users\Abdalrahman\Desktop\Programming Advaices\Level 19_Programming advices\#DVLD - Project\Images\Driver-Licence.png");
        }
    }
}
