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
    public partial class frmDrivers : Form
    {
        DataTable DriversTable;
        public frmDrivers()
        {
            InitializeComponent();
        }
        
        void FillComboBox()
        {
            comboBox1.Items.Add("None");
            comboBox1.Items.Add("DriverID");
            comboBox1.Items.Add("PersonID");
            comboBox1.Items.Add("NationalNo");
            comboBox1.Items.Add("fullName");
            comboBox1.SelectedIndex = 0;
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            DriversTable = clsDrivers.GetAllDrivers();
            dataGridView1.DataSource = DriversTable;

            lbCountRecords.Text = DriversTable.Rows.Count.ToString();

           
            FillComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(DriversTable);

            if(comboBox1.Text.Contains("DriverID") || comboBox1.Text.Contains("PersonID"))
            {
                if(int.TryParse(textBox1.Text, out int ID))
                    dataView.RowFilter = comboBox1.Text + "  = " + ID;
            }
            else
                dataView.RowFilter = comboBox1.Text + "  like '" + textBox1.Text + "%'" ;

            dataGridView1.DataSource = dataView;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
                textBox1.Visible = false;
            else
                textBox1.Visible = true;
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showPersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmshowPersonLiceneceHistory frm = new frmshowPersonLiceneceHistory
                ((int)dataGridView1.CurrentRow.Cells[1].Value);

            frm.ShowDialog();
        }
    }
}
