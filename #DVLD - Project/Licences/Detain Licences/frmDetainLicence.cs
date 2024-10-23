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
    public partial class frmDetainLicence : Form
    {
        int _PersonID = -1, _LicneceID = -1;

        public frmDetainLicence()
        {
            InitializeComponent();
        }

        private void linklbShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLicenceInfo(_LicneceID);
            frm.ShowDialog();
        }

        private void linklbShowLicenceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmshowPersonLiceneceHistory(_PersonID);
            frm.ShowDialog();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        clsDetainedLicences GetDetainLicenceObj()
        {
            clsDetainedLicences DetainedLicence = new clsDetainedLicences();
            DetainedLicence.LicenseID = _LicneceID;

            DetainedLicence.CreatedByUserID = clsCurrentUser.CurrentUser.ID;
            DetainedLicence.IsReleased = false;
            DetainedLicence.DetainDate = DateTime.Now;
            DetainedLicence.FineFees = decimal.Parse(txtFineFees.Text);

            return (DetainedLicence.Save()) ? DetainedLicence : null;
        }

        bool AreAllChecksOK()
        {
            if(clsDetainedLicences.IsLicenseDetained(_LicneceID))
            {
                MessageBox.Show("License already was Detained");
                return false;
            }

            if(string.IsNullOrEmpty(txtFineFees.Text))
            {
                MessageBox.Show("Fine Fees Box should be filled");
                return false;
            }

            return true;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(!AreAllChecksOK())
                return;

            if(MessageBox.Show("Are you sure ?", "Detain Licence", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsDetainedLicences DetainedLicence = GetDetainLicenceObj();

                if (DetainedLicence != null)
                {
                    MessageBox.Show("Licence was Detained sucssefully.", "Done"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    lbDetainID.Text = DetainedLicence.DetainID.ToString();
                }
                else
                    MessageBox.Show("failed to detain licence.", "Error"
                     , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = (!char.IsDigit(c) && c != 8 && c != 46) ? true : false;
        }

        private void frmDetainLicence_Load(object sender, EventArgs e)
        {
            lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;
            lbDetainDate.Text = DateTime.Now.ToShortDateString();
        }

        private void cntrlDriverLicenceInfoWithFillter1_OnLicenceSelected(int obj)
        {
            _LicneceID = obj;

            linklbShowLicenceHistory.Enabled = true;
            linklbShowLicenceInfo.Enabled = true;
            btnDetain.Enabled = true;
            lbLicneceID.Text = _LicneceID.ToString();

            if (_LicneceID > 0)
                 this._PersonID = clsDrivers.FindDriverByDriverID
                        (clsLicenses.FindByLicenseID(_LicneceID).DriverID).PersonID;
        }

    }
}
