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
    public partial class frmUpdateTestType : Form
    {
        clsTestTypes TestType;
        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            TestType = clsTestTypes.FindTestType(TestTypeID);
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            lbID.Text = TestType.TestTypeID.ToString();
            txtTitle.Text = TestType.TestTypeTilte;
            txtDescription.Text = TestType.TestTypeDescription;
            txtFees.Text = TestType.TestTypeFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TestType.TestTypeFees = decimal.Parse(txtFees.Text);
            TestType.TestTypeTilte = txtTitle.Text;
            TestType.TestTypeDescription = txtDescription.Text;

            if (TestType.UpdateTestType())
            {
                MessageBox.Show("Test Type Updated Successfully");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != '.')
            {
                e.Handled = true;
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


    }
}
