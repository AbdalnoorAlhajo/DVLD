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
    public partial class frmAddEditPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;


        int _PersonID = -1;

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
           
            this._PersonID = PersonID;
        }


        private void frmAddEditPerson_Load_1(object sender, EventArgs e)
        {
            if (clsPeople.IsPersonExists(_PersonID))
                this.lbAddEditForm.Text = "Update Person";

                cntrlPerson1.LoadPersonInfo(_PersonID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cntrlPerson1.Save();
            _PersonID = cntrlPerson1.PersonID;
            
            DataBack?.Invoke(this, _PersonID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
