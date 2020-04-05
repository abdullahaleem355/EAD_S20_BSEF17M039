namespace UserManagementSystem
{
    partial class frmMainScreen
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
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnExistingUser = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Location = new System.Drawing.Point(138, 56);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(168, 42);
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnExistingUser
            // 
            this.btnExistingUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingUser.Location = new System.Drawing.Point(138, 133);
            this.btnExistingUser.Name = "btnExistingUser";
            this.btnExistingUser.Size = new System.Drawing.Size(168, 45);
            this.btnExistingUser.TabIndex = 1;
            this.btnExistingUser.Text = "Existing User";
            this.btnExistingUser.UseVisualStyleBackColor = true;
            this.btnExistingUser.Click += new System.EventHandler(this.btnExistingUser_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(138, 219);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(168, 42);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(138, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExistingUser);
            this.Controls.Add(this.btnNewUser);
            this.Name = "frmMainScreen";
            this.Text = "Main Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainScreen_FormClosing);
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnExistingUser;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnExit;
    }
}

