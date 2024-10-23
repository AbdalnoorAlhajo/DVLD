using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DVLD___Project
{
    public partial class frmManageDetainedLicences : Form
    {
        DataTable DetainedLicencesTable;
        public frmManageDetainedLicences()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void RefreshPage()
        {
            DetainedLicencesTable = clsDetainedLicences.GetAllDetainedLicenses();
            dgvDetainedLicences.DataSource = DetainedLicencesTable;
            lbCountRecords.Text = dgvDetainedLicences.RowCount.ToString();
        }

        void FillComboBox()
        {
            comboBox1.Items.Add("None");

            foreach (DataColumn column in DetainedLicencesTable.Columns)
            {
                comboBox1.Items.Add(column.ColumnName);
            }

            comboBox1.Items.Remove("DetainDate");
            comboBox1.Items.Remove("ReleaseDate");
            comboBox1.Items.Remove("FineFees");

            comboBox1.SelectedIndex = 0;
        }


        private void frmManageDetainedLicences_Load(object sender, EventArgs e)
        {
            RefreshPage();
            FillComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           txtFilter.Visible = (comboBox1.SelectedIndex == 0) ? false : true;

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = DetainedLicencesTable.DefaultView;

            if(comboBox1.Text == "N.No" || comboBox1.Text == "FullName")
                dataView.RowFilter = comboBox1.Text + " like '" + txtFilter.Text + "%'";
            else
                if(int.TryParse(txtFilter.Text, out int Number))
                    dataView.RowFilter = comboBox1.Text + " = " + Number;

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!(comboBox1.Text == "N.No" ) || !(comboBox1.Text == "FullName"))
                e.Handled = (!char.IsDigit(c) && c != 8);
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainLicence();
            frm.ShowDialog();
            RefreshPage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaseDetainedLicence();
            frm.ShowDialog();
            RefreshPage();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenceID = (int)dgvDetainedLicences.CurrentRow.Cells[1].Value;
            int DriverID = clsLicenses.FindByLicenseID(LicenceID).DriverID;
            int PersonID = clsDrivers.FindDriverByDriverID(DriverID).PersonID;

            Form frm = new frmShowPersonDetails(PersonID);
            frm.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowLicenceInfo
                ((int)dgvDetainedLicences.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showPersonLicencesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenceID = (int)dgvDetainedLicences.CurrentRow.Cells[1].Value;
            int DriverID = clsLicenses.FindByLicenseID(LicenceID).DriverID;
            int PersonID = clsDrivers.FindDriverByDriverID(DriverID).PersonID;

            Form frm = new frmshowPersonLiceneceHistory(PersonID);
            frm.ShowDialog();
        }

        private void releaseDetainedLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaseDetainedLicence
                ((int)dgvDetainedLicences.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
                releaseDetainedLicenceToolStripMenuItem.Enabled = 
                !(bool)dgvDetainedLicences.CurrentRow.Cells[3].Value ;
        }
    }
}
