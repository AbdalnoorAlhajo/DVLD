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
    public partial class frmshowPersonLiceneceHistory : Form
    {
        int _PersonID;
        public frmshowPersonLiceneceHistory(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;
        }

        void FillLocalDataGridView()
        {
            DataTable LocalLiceneceTabel = clsLicenses.GetLocalLicensesView(_PersonID);
            dgvLocal.DataSource = LocalLiceneceTabel;

            int LocalRecords = dgvLocal.Rows.Count;

            lbCountLocalRecords.Text = LocalRecords.ToString();


            DataTable InternationalLicensesTabel = clsInternationalLicenses.
                GetInternationalLicenseView(_PersonID);
            dgvInternational.DataSource = InternationalLicensesTabel;

            int InternationalRecords = dgvInternational.Rows.Count;

            if (InternationalRecords > 0)
                lbCountInternationalRecords.Text = InternationalRecords.ToString();
        }


        private void frmshowPersonLiceneceHistory_Load(object sender, EventArgs e)
        {
            this.cntrlPersonlDetailsWithFillter1.FillCard(_PersonID);
            this.cntrlPersonlDetailsWithFillter1.FilterEnabled = false;

            FillLocalDataGridView();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenceInfo frm = new frmShowLicenceInfo(((int)dgvLocal.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void showDrivingLicenceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShowDriverInternationalLincenceInfo frm = new frmShowDriverInternationalLincenceInfo
                (((int)dgvInternational.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void dgvLocal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
