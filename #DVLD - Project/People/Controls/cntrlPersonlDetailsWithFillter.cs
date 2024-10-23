using BusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _DVLD___Project
{
    public partial class cntrlPersonlDetailsWithFillter : UserControl
    {
        public event Action<int> OnPersonSelected;

        public clsPeople People;

        int _PersonID = -1;

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        { 
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFillter.Enabled = _FilterEnabled;
            }
        }

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if(Handler != null)
                Handler(PersonID);
        }

        public cntrlPersonlDetailsWithFillter()
        {
            InitializeComponent();
        }

        public void FillCard(int PersonID)
        {
            comboBox1.Text = "PersonID";
            txtFillter.Text = PersonID.ToString();
            comboBox1.Text = "PersonID";
            pbSearch_Click(null, null);
        }

        public void FillCard(string NationalNo)
        {
            comboBox1.Text = "NationalNo";
            txtFillter.Text = NationalNo;
            comboBox1.Text = "NationalNo";
            pbSearch_Click(null, null);
        }

        private void cntrlPersonlDetailsWithFillter_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("None");
            comboBox1.Text = "None";
            comboBox1.Items.Add("PersonID");
            comboBox1.Items.Add("NationalNo");
        }


        private void pbSearch_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Contains("PersonID"))
                People = clsPeople.Find( int.Parse(txtFillter.Text));
            else
                People = clsPeople.Find(txtFillter.Text);


            if (People == null)
             {
                txtFillter.Text = "";
                cntrlPersonDetails1.ResetPersonInfo();
                _PersonID = -1;
                MessageBox.Show("Person is not found", "Unfound"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            else
                _PersonID = People.ID;

            cntrlPersonDetails1.FillCardWithInfo(_PersonID);

            if (OnPersonSelected != null)
                OnPersonSelected(_PersonID);
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();

  
            pbSearch_Click(sender, e);
        }

        void DataBackEvent(object sender, int obj)
        {
            _PersonID = obj;

            if(_PersonID > 0)
            {
                comboBox1.Text = "PersonID";
                txtFillter.Text = _PersonID.ToString();
            }
        }

        private void txtFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if(comboBox1.Text.Equals("PersonID"))
                e.Handled = (!char.IsDigit(c) && c != 8);
            else if(comboBox1.Text.Equals("NationalNo"))
                e.Handled = (!char.IsDigit(c) && !char.IsLetter(c) && c != 8);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFillter.Visible = (!comboBox1.Text.Contains("None"));
            txtFillter.Text = "";
        }

    }
}
