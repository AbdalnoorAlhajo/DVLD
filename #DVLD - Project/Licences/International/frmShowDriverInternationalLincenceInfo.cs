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
    public partial class frmShowDriverInternationalLincenceInfo : Form
    {
        int InternationalLicenceID;
        public frmShowDriverInternationalLincenceInfo(int InternationalLicenceID)
        {
            InitializeComponent();
            this.InternationalLicenceID = InternationalLicenceID;
        }

        private void frmShowInternationalDriverLincenceInfo_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(
                @"C:\Users\Abdalrahman\Desktop\Programming Advaices\Level 19_Programming advices\#DVLD - Project\Images\Driver-Licence.png");

            cntrlInternationalDriverLicenceInfo1.FillCardWithInfoWithInternationaLicenseID
                (InternationalLicenceID);
        }
    }
}
