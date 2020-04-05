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

namespace UserManagementSystem
{
    public partial class AdminLoginScreen : Form
    {
        public AdminLoginScreen()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainScreen = Application.OpenForms["frmMainScreen"];
            mainScreen.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                var login = txtLogin.Text.Trim();
                var password = txtPassword.Text.Trim();
                if(AdminBO.ValidateAdmin(login, password))
                {
                    // admin home screen.
                    var adminScreen = new FrmAdminHome();
                    adminScreen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Or Password!");
                }
            }
        }

        private void AdminLoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainScreen = Application.OpenForms["frmMainScreen"];
            mainScreen.Show();
            this.Hide();
        }
    }
}
