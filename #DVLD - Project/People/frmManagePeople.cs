using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace _DVLD___Project
{
    public partial class frmManagePeople : Form
    {
        DataTable PeopleTable;

        public frmManagePeople()
        {
            InitializeComponent();

            
        }

        void RefreshDataGridView()
        {
            PeopleTable = clsPeople.GetAllPeople();
            dataGridView1.DataSource = PeopleTable;
            lbNumberOfRecods.Text = dataGridView1.RowCount.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);// -1

            frm.ShowDialog();
            RefreshDataGridView();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            PeopleTable = clsPeople.GetAllPeople();

            dataGridView1.DataSource = PeopleTable;
            lbNumberOfRecods.Text = dataGridView1.RowCount.ToString();

            cbPeopleColumns.Items.Add("None");

            foreach (DataColumn column in PeopleTable.Columns)
            {
                cbPeopleColumns.Items.Add(column.ToString());
            }
            cbPeopleColumns.Items.Remove("DateOfBirth");
            cbPeopleColumns.Items.Remove("ImagePath");

            cbPeopleColumns.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(PeopleTable);

            if (textBox1.Text.Trim() == "")
                dataGridView1.DataSource = PeopleTable;
            else if (cbPeopleColumns.Text.Contains("PersonID"))
            {
                if(int.TryParse(textBox1.Text, out int ID))
                    dataView.RowFilter = cbPeopleColumns.Text + "  = " + ID;
            }
            else
                dataView.RowFilter = cbPeopleColumns.Text.Trim() + " like '" + textBox1.Text.Trim() + "%'";
           

            dataGridView1.DataSource = dataView;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2_Click( null, null);
            RefreshDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dataGridView1.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            RefreshDataGridView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsPeople.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Person Deleted Successfully.", "Delete", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to delete Person Because it linked with other info"
                 , "Error"   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshDataGridView();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshDataGridView();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature not implemented yet", "Sorry"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature not implemented yet", "Sorry"
            , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbPeopleColumns.Text.Contains("PersonID"))
                e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8);
        }

        private void cbPeopleColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = (!cbPeopleColumns.Text.Contains("None"));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
