using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS.BAL;
using UMS.Entities;

namespace UserManagementSystem
{
    public partial class FrmExistingUser : Form
    {
        public FrmExistingUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainScreen = Application.OpenForms["frmMainScreen"];
            mainScreen.Show();
            this.Hide();
        }

        private Boolean isEmailValid(String email)
        {
            Regex check = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            bool valid = false;
            valid = check.IsMatch(email);
            if (valid)
                return true;
            return false;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(isEmailValid(txtEmail.Text.Trim()))
            {
                String userMail = txtEmail.Text.Trim();
                int uID = UsersBO.GetUserIdViaEmail(userMail);
                if(uID != -1)
                {
                    String subject = "UMS Reset Code";
                    String body = "Code is 12345";
                    if (EmailHandlerBO.SendEmail(userMail, subject, body))
                    {
                        ResetCode resetCode = new ResetCode(uID);
                        resetCode.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("An Error Occurred. Please Enter email again.");
            }
            else
            {
                lblEmail.Visible = true;
            }
        }

        private Boolean validateFields()
        {
            if (txtLogin.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                return true;
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                var login = txtLogin.Text.Trim();
                var password = txtPassword.Text.Trim();
                if (UsersBO.ValidateUser(login, password))
                {
                    // navigate to Home Screen for this user.
                    Home home = new Home(login, password);
                    home.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Login Or Password.");
            }
        }

        private void FrmExistingUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainScreen = Application.OpenForms["frmMainScreen"];
            mainScreen.Show();
            this.Hide();
        }
    }
}
