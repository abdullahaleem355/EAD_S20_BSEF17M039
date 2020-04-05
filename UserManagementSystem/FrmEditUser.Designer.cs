namespace UserManagementSystem
{
    partial class FrmEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dropGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.dateTimeDob = new System.Windows.Forms.DateTimePicker();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkChess = new System.Windows.Forms.CheckBox();
            this.checkHockey = new System.Windows.Forms.CheckBox();
            this.checkCricket = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblChecked = new System.Windows.Forms.Label();
            this.openFileImg = new System.Windows.Forms.OpenFileDialog();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(165, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(189, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(165, 56);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(189, 20);
            this.txtLogin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Login";
            // 
            // dropGender
            // 
            this.dropGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropGender.FormattingEnabled = true;
            this.dropGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.dropGender.Location = new System.Drawing.Point(165, 162);
            this.dropGender.Name = "dropGender";
            this.dropGender.Size = new System.Drawing.Size(189, 21);
            this.dropGender.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(165, 201);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(189, 79);
            this.txtAddress.TabIndex = 15;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(165, 314);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(132, 20);
            this.numAge.TabIndex = 16;
            this.numAge.ValueChanged += new System.EventHandler(this.numAge_ValueChanged);
            // 
            // dateTimeDob
            // 
            this.dateTimeDob.Location = new System.Drawing.Point(165, 388);
            this.dateTimeDob.Name = "dateTimeDob";
            this.dateTimeDob.Size = new System.Drawing.Size(218, 20);
            this.dateTimeDob.TabIndex = 18;
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(165, 349);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(156, 20);
            this.txtNic.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "NIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Gender";
            // 
            // checkChess
            // 
            this.checkChess.AutoSize = true;
            this.checkChess.Location = new System.Drawing.Point(328, 434);
            this.checkChess.Name = "checkChess";
            this.checkChess.Size = new System.Drawing.Size(55, 17);
            this.checkChess.TabIndex = 25;
            this.checkChess.Text = "Chess";
            this.checkChess.UseVisualStyleBackColor = true;
            // 
            // checkHockey
            // 
            this.checkHockey.AutoSize = true;
            this.checkHockey.Location = new System.Drawing.Point(248, 434);
            this.checkHockey.Name = "checkHockey";
            this.checkHockey.Size = new System.Drawing.Size(63, 17);
            this.checkHockey.TabIndex = 26;
            this.checkHockey.Text = "Hockey";
            this.checkHockey.UseVisualStyleBackColor = true;
            // 
            // checkCricket
            // 
            this.checkCricket.AutoSize = true;
            this.checkCricket.Location = new System.Drawing.Point(165, 434);
            this.checkCricket.Name = "checkCricket";
            this.checkCricket.Size = new System.Drawing.Size(59, 17);
            this.checkCricket.TabIndex = 27;
            this.checkCricket.Text = "Cricket";
            this.checkCricket.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Sports";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(248, 479);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 33);
            this.btnCreate.TabIndex = 29;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(425, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 33);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picBoxUser
            // 
            this.picBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxUser.Location = new System.Drawing.Point(538, 28);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(159, 116);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 31;
            this.picBoxUser.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(580, 162);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 36);
            this.btnUpload.TabIndex = 32;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGender.Location = new System.Drawing.Point(360, 163);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(169, 15);
            this.lblGender.TabIndex = 34;
            this.lblGender.Text = "Gender must be Selected";
            this.lblGender.Visible = false;
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPic.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPic.Location = new System.Drawing.Point(535, 201);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(186, 15);
            this.lblPic.TabIndex = 35;
            this.lblPic.Text = "Picture must be SELECTED!";
            this.lblPic.Visible = false;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmpty.Location = new System.Drawing.Point(535, 235);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(174, 15);
            this.lblEmpty.TabIndex = 36;
            this.lblEmpty.Text = "No Field must be EMPTY !";
            this.lblEmpty.Visible = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAge.Location = new System.Drawing.Point(535, 314);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(196, 15);
            this.lblAge.TabIndex = 37;
            this.lblAge.Text = "Age must be greater than 18 !";
            this.lblAge.Visible = false;
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNic.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNic.Location = new System.Drawing.Point(535, 349);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(236, 15);
            this.lblNic.TabIndex = 38;
            this.lblNic.Text = "NIC should be 13 characters (5-7-1)";
            this.lblNic.Visible = false;
            // 
            // lblChecked
            // 
            this.lblChecked.AutoSize = true;
            this.lblChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChecked.ForeColor = System.Drawing.Color.Firebrick;
            this.lblChecked.Location = new System.Drawing.Point(535, 433);
            this.lblChecked.Name = "lblChecked";
            this.lblChecked.Size = new System.Drawing.Size(235, 15);
            this.lblChecked.TabIndex = 39;
            this.lblChecked.Text = "One Check box must be CHECKED !";
            this.lblChecked.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmail.Location = new System.Drawing.Point(360, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 15);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "Email must be Valid";
            this.lblEmail.Visible = false;
            // 
            // FrmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblChecked);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.lblPic);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkCricket);
            this.Controls.Add(this.checkHockey);
            this.Controls.Add(this.checkChess);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.dateTimeDob);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dropGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "FrmEditUser";
            this.Text = "New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditUser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.DateTimePicker dateTimeDob;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkChess;
        private System.Windows.Forms.CheckBox checkHockey;
        private System.Windows.Forms.CheckBox checkCricket;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblChecked;
        private System.Windows.Forms.OpenFileDialog openFileImg;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
    }
}