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
    public partial class UpdatePassword : Form
    {
        int userID;
        public UpdatePassword(int uID)
        {
            userID = uID;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != "")
            {
                String passwd = txtPassword.Text.Trim();
                if(UsersBO.UpdatePassword(userID, passwd) == 1)
                {
                    MessageBox.Show("Password Updated Successfully");
                    var loginScreen = Application.OpenForms["FrmExistingUser"];
                    loginScreen.Show();
                    this.Hide();
                }
            }
        }
    }
}
