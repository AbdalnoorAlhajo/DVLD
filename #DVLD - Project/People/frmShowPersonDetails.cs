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
    public partial class frmShowPersonDetails : Form
    {
        private int _PersonID;
        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            cntrlPersonDetails1.FillCardWithInfo(_PersonID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
