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
    public partial class cntrlDriverLicenceInfoWithFillter : UserControl
    {
        public event Action<int> OnLicenceSelected;

        public int LicenceID { get; set; } = -1;

        public cntrlDriverLicenceInfoWithFillter()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            e.Handled = (!char.IsDigit(c) && c != 8) ? true : false;
        }

        public void EnablingFillter(bool EnableFillter)
        {
            
            gbFillter.Enabled = EnableFillter;
        }

        public void ChangeSerachText()
        {
            textBox1.Text = LicenceID.ToString();
            pbSerach_Click(null, null);
        }

        private void pbSerach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int LicenceID))
            {
                if (clsLicenses.IsLicenseExistByLicenseID(LicenceID))
                {
                    cntrlDriverLicenceInfo1.FillCardWithInfo(LicenceID);
                    this.LicenceID = LicenceID;


                    if (OnLicenceSelected != null)
                        OnLicenceSelected(LicenceID);
                }
                else
                    MessageBox.Show("This License dose not exist.");
            }
            else
                MessageBox.Show("Something went wrong");

        }
    }
}
