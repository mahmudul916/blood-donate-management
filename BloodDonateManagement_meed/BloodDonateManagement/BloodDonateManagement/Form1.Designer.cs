namespace BloodDonateManagement
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.Admin_btn = new MetroFramework.Controls.MetroButton();
            this.NameTxt = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTxt = new MetroFramework.Controls.MetroTextBox();
            this.username = new MetroFramework.Controls.MetroLabel();
            this.password = new MetroFramework.Controls.MetroLabel();
            this.AdminPanal = new MetroFramework.Controls.MetroPanel();
            this.Sign_btn = new MetroFramework.Controls.MetroButton();
            this.login_btn = new MetroFramework.Controls.MetroButton();
            this.user_btn = new MetroFramework.Controls.MetroButton();
            this.userTxt = new MetroFramework.Components.MetroStyleManager(this.components);
            this.PasswordUserTxt = new MetroFramework.Components.MetroStyleManager(this.components);
            this.AdminPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordUserTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_btn
            // 
            this.Admin_btn.Location = new System.Drawing.Point(56, 130);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(75, 23);
            this.Admin_btn.TabIndex = 0;
            this.Admin_btn.Text = "Admin";
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(91, 50);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(115, 23);
            this.NameTxt.TabIndex = 1;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(91, 114);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(115, 23);
            this.PasswordTxt.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(10, 50);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(75, 19);
            this.username.TabIndex = 3;
            this.username.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(10, 114);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(63, 19);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // AdminPanal
            // 
            this.AdminPanal.Controls.Add(this.Sign_btn);
            this.AdminPanal.Controls.Add(this.login_btn);
            this.AdminPanal.Controls.Add(this.password);
            this.AdminPanal.Controls.Add(this.username);
            this.AdminPanal.Controls.Add(this.PasswordTxt);
            this.AdminPanal.Controls.Add(this.NameTxt);
            this.AdminPanal.HorizontalScrollbarBarColor = true;
            this.AdminPanal.HorizontalScrollbarHighlightOnWheel = false;
            this.AdminPanal.HorizontalScrollbarSize = 10;
            this.AdminPanal.Location = new System.Drawing.Point(181, 53);
            this.AdminPanal.Name = "AdminPanal";
            this.AdminPanal.Size = new System.Drawing.Size(232, 235);
            this.AdminPanal.TabIndex = 5;
            this.AdminPanal.VerticalScrollbarBarColor = true;
            this.AdminPanal.VerticalScrollbarHighlightOnWheel = false;
            this.AdminPanal.VerticalScrollbarSize = 10;
            this.AdminPanal.Visible = false;
            // 
            // Sign_btn
            // 
            this.Sign_btn.Location = new System.Drawing.Point(131, 181);
            this.Sign_btn.Name = "Sign_btn";
            this.Sign_btn.Size = new System.Drawing.Size(75, 23);
            this.Sign_btn.TabIndex = 6;
            this.Sign_btn.Text = "Sign Up";
            this.Sign_btn.Click += new System.EventHandler(this.Sign_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(10, 181);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.Location = new System.Drawing.Point(56, 199);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(75, 23);
            this.user_btn.TabIndex = 6;
            this.user_btn.Text = "User";
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // userTxt
            // 
            this.userTxt.Owner = null;
            // 
            // PasswordUserTxt
            // 
            this.PasswordUserTxt.Owner = null;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 331);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.AdminPanal);
            this.Controls.Add(this.Admin_btn);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.AdminPanal.ResumeLayout(false);
            this.AdminPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordUserTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Admin_btn;
        private MetroFramework.Controls.MetroTextBox NameTxt;
        private MetroFramework.Controls.MetroTextBox PasswordTxt;
        private MetroFramework.Controls.MetroLabel username;
        private MetroFramework.Controls.MetroLabel password;
        private MetroFramework.Controls.MetroPanel AdminPanal;
        private MetroFramework.Controls.MetroButton login_btn;
        private MetroFramework.Controls.MetroButton user_btn;
        private MetroFramework.Controls.MetroButton Sign_btn;
        private MetroFramework.Components.MetroStyleManager userTxt;
        private MetroFramework.Components.MetroStyleManager PasswordUserTxt;
    }
}

