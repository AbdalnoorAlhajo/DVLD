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
    public partial class frmManageTestTypes : Form
    {
        DataTable TestTypesTable;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            TestTypesTable = clsTestTypes.GetAllTestTypes();
            dataGridView1.DataSource = TestTypesTable;
            lbCountTypes.Text = (dataGridView1.RowCount - 1).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateTestType((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageTestTypes_Load(null, null);
        }
    }
}
