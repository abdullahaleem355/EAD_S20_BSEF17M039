using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS.BAL;
using UMS.Entities;

namespace UserManagementSystem
{
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainScreen = Application.OpenForms["frmMainScreen"];
            this.Close();
            mainScreen.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var result = openFileForPic.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var filePath = openFileForPic.FileName;
                picBoxUser.Image = Image.FromFile(filePath);
            }
        }

        private Boolean checkEmptyFields()
        {
            if (txtName.Text.Trim() == "" || txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == ""
               || txtAddress.Text.Trim() == "" || txtNic.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }

        private Boolean isAgeValid()
        {
            if (numAge.Value < 18)
                return false;
            return true;
        }

        private Boolean isNicValid(String nic)
        {
            Regex check = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            bool valid = false;
            valid = check.IsMatch(nic);
            if (valid)
                return true;
            return false;
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

        private Boolean isPicEmptyOrNull(PictureBox pbUser)
        {
            return pbUser == null || pbUser.Image == null;
        }

        private Boolean isCheckBoxChecked()
        {
            if(checkCricket.Checked || checkChess.Checked || checkHockey.Checked)
                return true;
            return false;
        }

        private Boolean isGenderSelected()
        {
            if (dropGender.SelectedIndex > -1)
                return true;
            return false;
        }

        private void resetLabels()
        {
            lblChecked.Visible = false;
            lblAge.Visible = false;
            lblNic.Visible = false;
            lblPic.Visible = false;
            lblEmpty.Visible = false;
            lblGender.Visible = false;
            lblEmail.Visible = false;
        }

        private Boolean validateEntries()
        {
            bool valid = true;
            resetLabels();
            if (checkEmptyFields())
            {
                lblEmpty.Visible = true;
                valid = false;
            }
            if (!isAgeValid())
            {
                lblAge.Visible = true;
                valid = false;
            }
            if (!isNicValid(txtNic.Text.Trim()))
            {
                lblNic.Visible = true;
                valid = false;
            }
            if(!isEmailValid(txtEmail.Text.Trim()))
            {
                lblEmail.Visible = true;
                valid = false;
            }
            if (isPicEmptyOrNull(picBoxUser))
            {
                lblPic.Visible = true;
                valid = false;
            }
            if (!isCheckBoxChecked())
            {
                lblChecked.Visible = true;
                valid = false;
            }
            if (!isGenderSelected())
            {
                lblGender.Visible = true;
                valid = false;
            }
            return valid;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateEntries())
            {
                UsersDTO dto = new UsersDTO();
                dto.UserID = 0;  // Registration Of User.
                dto.Name = txtName.Text.Trim();
                dto.Login = txtLogin.Text.Trim();
                dto.Password = txtPassword.Text.Trim();
                dto.Address = txtAddress.Text.Trim();
                dto.Email = txtEmail.Text.Trim();
                dto.Age = Int32.Parse(numAge.Value.ToString());
                dto.Dob = dateTimeDob.Value;
                dto.Nic = txtNic.Text.Trim();
                dto.CreatedOn = DateTime.Now;
                if (checkCricket.Checked)
                    dto.IsCricket = true;
                else if (checkHockey.Checked)
                    dto.Hockey = true;
                else
                    dto.Chess = true;

                String gender = dropGender.SelectedItem.ToString();

                if (gender == "Male")
                    dto.Gender = "M";
                else
                    dto.Gender = "F";
                String uniqueName = "";
                String imgPath = "";
                if(picBoxUser.Image != null)
                {
                    String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    String pathToSaveImage = applicationBasePath + @"\images\";
                    uniqueName = Guid.NewGuid().ToString() + ".jpg";
                    imgPath = pathToSaveImage + uniqueName;
                }
                dto.ImageName = uniqueName;
                if (UsersBO.RegisterOrUpdateUser(dto) == 1)
                {
                    picBoxUser.Image.Save(imgPath);  // Once the User gets registered than save the image in images folder.
                    var homeSreen = new Home(dto.Login, dto.Password);
                    homeSreen.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("User Already Exists.");
            }
        }

        private void FrmNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainScreen = Application.OpenForms["frmMainScreen"];
            this.Hide();
            mainScreen.Show();
        }
    }
}
