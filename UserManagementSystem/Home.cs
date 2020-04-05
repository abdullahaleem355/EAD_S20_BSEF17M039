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
    public partial class Home : Form
    {
        UsersDTO user;
        public Home(String pLogin, String pPassword)
        {
            InitializeComponent();
            user = UsersBO.GetUsersDTO(pLogin, pPassword);
            lblUserName.Text = user.Name;
            String appBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            String filePath = appBasePath + @"\images\" + user.ImageName;
            imgProfile.Image = Image.FromFile(filePath);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // give parametrized dto in case of update to show current info.
            var EditScreen = new FrmEditUser(user, false);  // false in admin flag because user is editing.
            EditScreen.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var mainScreen = Application.OpenForms["FrmMainScreen"];
            mainScreen.Show();
            this.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainScreen = Application.OpenForms["FrmMainScreen"];
            mainScreen.Show();
            this.Hide();
        }
    }
}
