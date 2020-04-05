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
    public partial class ResetCode : Form
    {
        int userId;
        public ResetCode(int uID)
        {
            userId = uID;
            InitializeComponent();
        }

        private void ResetCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            var loginForm = Application.OpenForms["FrmExistingUser"];
            loginForm.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtCode.Text.Trim() != "")
            {
                if(txtCode.Text.Trim() == "12345")
                {
                    var updatePwdScreen = new UpdatePassword(userId);
                    updatePwdScreen.Show();
                    this.Hide();
                }
            }
        }
    }
}
