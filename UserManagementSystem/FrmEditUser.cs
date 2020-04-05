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
    public partial class FrmEditUser : Form
    {
        Boolean admin;
        UsersDTO userDto;
        public FrmEditUser(UsersDTO dto, Boolean pAdmin)
        {
            admin = pAdmin;
            userDto = dto;
            InitializeComponent();
            // Show data of user in all fields here.
            txtName.Text = userDto.Name;
            txtLogin.Text = userDto.Login;
            txtPassword.Text = userDto.Password;
            if(admin) // if admin is editing than show other fields as well.
            {
                txtAddress.Text = userDto.Address;
                txtEmail.Text = userDto.Email;
                txtNic.Text = userDto.Nic;
                numAge.Value = userDto.Age;
                dateTimeDob.Value = userDto.Dob;
                if (userDto.Gender == "F")
                    dropGender.SelectedIndex = 0;
                else
                    dropGender.SelectedIndex = 1;
                if (userDto.IsCricket == true)  // handle this issue.
                    checkCricket.Checked = true;
                if (userDto.Hockey == true)
                    checkHockey.Checked = true;
                if(userDto.Chess == true)
                    checkChess.Checked = true;
                String appBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                String filePath = appBasePath + @"\images\" + dto.ImageName;
                picBoxUser.Image = Image.FromFile(filePath);
            }
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
            if (checkCricket.Checked || checkChess.Checked || checkHockey.Checked)
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            resetLabels();
            if (txtLogin.Text.Trim() != "")
                userDto.Login = txtLogin.Text.Trim();
            if (txtName.Text.Trim() != "")
                userDto.Name = txtName.Text.Trim();
            if (txtPassword.Text.Trim() != "")
                userDto.Password = txtPassword.Text.Trim();
            if (txtAddress.Text.Trim() != "")
                userDto.Address = txtAddress.Text.Trim();
            if (dropGender.SelectedIndex == 0)
                userDto.Gender = "F";
            else
                userDto.Gender = "M";
            userDto.Dob = dateTimeDob.Value;
            if (checkCricket.Checked)
                userDto.IsCricket = true;
            else
                userDto.IsCricket = false;
            if (checkHockey.Checked)
                userDto.Hockey = true;
            else
                userDto.Hockey = false;
            if (checkChess.Checked)
                userDto.Chess = true;
            else
                userDto.Chess = false;
            if(txtNic.Text.Trim() != "")
            {
                String nic = txtNic.Text.Trim();
                if (isNicValid(nic))
                    userDto.Nic = nic;
                else
                {
                    lblNic.Visible = true;
                    return;
                }
            }
            if(txtEmail.Text.Trim() != "")
            {
                String email = txtEmail.Text.Trim();
                if (isEmailValid(email))
                    userDto.Email = email;
                else
                {
                    lblEmail.Visible = true;
                    return;
                }
            }
            String imgPath = null;
            if (!isPicEmptyOrNull(picBoxUser))
            {
                String uniqueName = "";
                if (picBoxUser.Image != null)
                {
                    String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    String pathToSaveImage = applicationBasePath + @"\images\";
                    uniqueName = Guid.NewGuid().ToString() + ".jpg";
                    imgPath = pathToSaveImage + uniqueName;
                }
                userDto.ImageName = uniqueName;
            }
            if (UsersBO.RegisterOrUpdateUser(userDto) == 1)
            {
                if(imgPath != null)
                    picBoxUser.Image.Save(imgPath);  // Once the User gets updated than save the image in images folder.
            }
            if(admin)
            {
                var adminHome = new FrmAdminHome();
                adminHome.Show();
                this.Hide();
            }
            else
            {
                var homeSreen = new Home(userDto.Login, userDto.Password);
                homeSreen.Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                //go back to admin form.
                var adminHome = Application.OpenForms["FrmAdminHome"];
                adminHome.Show();
                this.Hide();
            }
            else
            {
                // go back to user screen.
                var userScreen = new Home(userDto.Login, userDto.Password);
                userScreen.Show();
                this.Hide();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
                var result = openFileImg.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    var filePath = openFileImg.FileName;
                    picBoxUser.Image = Image.FromFile(filePath);
                }
        }

        private void FrmEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(admin)
            {
                // go back to admin screen.
                var adminHome = Application.OpenForms["FrmAdminHome"];
                adminHome.Show();
                this.Hide();
            }
            else
            {
                // go back to user screen.
                var userScreen = new Home(userDto.Login, userDto.Password);
                userScreen.Show();
                this.Hide();
            }
        }

        private void numAge_ValueChanged(object sender, EventArgs e)
        {
            if (isAgeValid())
            {
                userDto.Age = Int32.Parse(numAge.Value.ToString());
                lblAge.Visible = false;
            }
            else
            {
                lblAge.Visible = true;
                return;
            }
        }
    }
}