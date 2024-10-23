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
    
    public partial class frmApplicationTypes : Form
    {
        DataTable ApplicationTypesTable;
        public frmApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            ApplicationTypesTable = clsApplicationTypes.GetAllApplicationTypes();
            dataGridView1.DataSource = ApplicationTypesTable;
            lbCountTypes.Text = (dataGridView1.RowCount-1).ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm =new frmUpdateApplicationType((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmApplicationTypes_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
