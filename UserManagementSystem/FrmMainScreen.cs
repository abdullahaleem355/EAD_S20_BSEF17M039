using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementSystem
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmNewUser newUserForm = new FrmNewUser();
            newUserForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExistingUser_Click(object sender, EventArgs e)
        {
            FrmExistingUser existingUserForm = new FrmExistingUser();
            existingUserForm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginScreen adminLoginScreen = new AdminLoginScreen();
            adminLoginScreen.Show();
            this.Hide();
        }

        private void frmMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            System.IO.Directory.CreateDirectory(applicationBasePath + @"\images\");
        }
    }
}
