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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _DVLD___Project
{
    public partial class frmManageUsers : Form
    {
        DataTable UsersTable;
        public frmManageUsers()
        {
            InitializeComponent();
        }

        void RefrechManageUsers()
        {
            UsersTable = clsUsers.GetAllUsers();
            dataGridView1.DataSource = UsersTable.DefaultView.ToTable(false, "UserID"
     , "PersonID", "UserName", "IsActive");
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            RefrechManageUsers();

            lbCountRecords.Text = (dataGridView1.RowCount).ToString();
            pbAddUser.Image = Image.FromFile(@"C:\Users\Abdalrahman\Desktop\Programming Advaices\Level 19_Programming advices\#DVLD - Project\Images\Add_User.png");

            foreach (DataColumn Column in UsersTable.Columns)
            {
                comboBox1.Items.Add(Column.ToString());
            }
            comboBox1.SelectedIndex = 0;

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(UsersTable);

            if (txtFilter.Text.Trim() == "")
                dataGridView1.DataSource = UsersTable.DefaultView.ToTable(false
                    , "UserID", "PersonID", "UserName", "IsActive");

            else if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1
                || comboBox1.SelectedIndex == 4)
            {
                int.TryParse(txtFilter.Text, out int ID);
                dataView.RowFilter = comboBox1.Text + "  = " + ID;
            }
            else
                dataView.RowFilter = comboBox1.Text.Trim() + " like '" + txtFilter.Text.Trim() + "%'";


            dataGridView1.DataSource = dataView.ToTable(false
                    , "UserID", "PersonID", "UserName", "IsActive"); ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            Form frm  = new frmAddNewUser();
            frm.ShowDialog();
            RefrechManageUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbAddUser_Click( sender,  e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsUsers.DeleteUser((int)dataGridView1.CurrentRow.Cells[0].Value))
                MessageBox.Show("User Deleted Successfully");
            else
                MessageBox.Show("Failed to Delete User Successfully");
            RefrechManageUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewUser((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            RefrechManageUsers();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangeUserPassword((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            RefrechManageUsers();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserDetails((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature has not implemented yet", "try later"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature has not implemented yet", "try later"
    , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
