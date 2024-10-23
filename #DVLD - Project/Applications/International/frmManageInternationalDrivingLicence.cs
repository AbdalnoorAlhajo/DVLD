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
    public partial class frmManageInternationalDrivingLicence : Form
    {
        DataTable IntDrivingLicencesTable;
        public frmManageInternationalDrivingLicence()
        {
            InitializeComponent();
        }

        void RefreshPage()
        {
            IntDrivingLicencesTable
            = clsInternationalLicenses.GetAllInternationalLicensesView();
            dgvInternationalApplications.DataSource = IntDrivingLicencesTable;
        }

        void FillComboBox()
        {
            comboBox1.Items.Add("None");

            byte count = 0;
            foreach (DataColumn dataColumn in IntDrivingLicencesTable.Columns )
            {
                comboBox1.Items.Add(dataColumn.ToString());
                count++;
                if (count == 4)
                    break;
            }
            comboBox1.SelectedIndex = 0;

        }


        private void frmManageInternationalDrivingLicence_Load(object sender, EventArgs e)
        {
            RefreshPage();
            FillComboBox();

            lbCountRecord.Text = (dgvInternationalApplications.RowCount).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.Visible = false;
            else
                textBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = IntDrivingLicencesTable.DefaultView;


            if(comboBox1.SelectedIndex > 0)
            {
                int.TryParse(textBox1.Text, out int ID);
                 dataView.RowFilter = comboBox1.Text + "  = " + ID;
            }

            dgvInternationalApplications.DataSource = dataView;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = (char.IsDigit(c) || c == 8) ? false : true;
        }

        private void pbAddApplication_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewInternationalLicenceApplication();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void showLicenceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowDriverInternationalLincenceInfo
                ((int)dgvInternationalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers Driver = clsDrivers.FindDriverByDriverID
                ((int)dgvInternationalApplications.CurrentRow.Cells[2].Value);
            Form frm = new frmShowPersonDetails(Driver.PersonID);
            frm.ShowDialog();
        }

        private void showPersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers Driver = clsDrivers.FindDriverByDriverID
    ((int)dgvInternationalApplications.CurrentRow.Cells[2].Value);
            Form frm = new frmshowPersonLiceneceHistory(Driver.PersonID);
            frm.ShowDialog();
        }
    }
}
