using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS.BAL;
using UMS.Entities;

namespace UserManagementSystem
{
    public partial class FrmAdminHome : Form
    {
        public FrmAdminHome()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var adminLogin = Application.OpenForms["AdminLoginScreen"];
            adminLogin.Show();
            this.Hide();
        }

        private void FrmAdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            var adminLogin = Application.OpenForms["AdminLoginScreen"];
            adminLogin.Show();
            this.Hide();
        }

        private void FrmAdminHome_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AdminBO.GetUsers();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)  // Edit Col.
            {
                int userid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                UsersDTO dto = UsersBO.GetUserDTOById(userid);
                var homeScreen = new FrmEditUser(dto, true);
                homeScreen.Show();
                this.Hide();
            }
        }
    }
}
