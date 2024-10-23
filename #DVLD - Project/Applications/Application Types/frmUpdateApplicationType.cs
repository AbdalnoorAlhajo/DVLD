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
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationTypes UpdatedApplicationType;
        public frmUpdateApplicationType(int ApplicationTypeId)
        {
            InitializeComponent();
            UpdatedApplicationType = 
                clsApplicationTypes.FindApplicationType(ApplicationTypeId);
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            lbID.Text = UpdatedApplicationType.ApplicationTypeID.ToString();
            txtTitle.Text = UpdatedApplicationType.ApplicationTypeTilte;
            txtFees.Text = UpdatedApplicationType.ApplicationTypeFees.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatedApplicationType.ApplicationTypeFees = decimal.Parse(txtFees.Text);
            UpdatedApplicationType.ApplicationTypeTilte = txtTitle.Text;

            if (UpdatedApplicationType.UpdateApplicationType())
            {
                MessageBox.Show("Application Type Updated Successfully");
            }
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != '.')
            {
                e.Handled = true;
            }
        }
    }
}
