namespace BloodDonateManagement
{
    partial class Sign_Up_Form
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
            this.NamePart1Txt = new MetroFramework.Controls.MetroTextBox();
            this.SignEmailTxt = new MetroFramework.Controls.MetroTextBox();
            this.SignPassTxt = new MetroFramework.Controls.MetroTextBox();
            this.SignAreaTxt = new MetroFramework.Controls.MetroTextBox();
            this.SignAgeTxt = new MetroFramework.Controls.MetroTextBox();
            this.SexCombo = new MetroFramework.Controls.MetroComboBox();
            this.SignSexTxt = new MetroFramework.Controls.MetroLabel();
            this.StatusCombo = new MetroFramework.Controls.MetroComboBox();
            this.SignStatusTxt = new MetroFramework.Controls.MetroLabel();
            this.Sign_btn = new MetroFramework.Controls.MetroButton();
            this.bloodGroupCombo = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // NamePart1Txt
            // 
            this.NamePart1Txt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NamePart1Txt.Location = new System.Drawing.Point(76, 118);
            this.NamePart1Txt.Name = "NamePart1Txt";
            this.NamePart1Txt.Size = new System.Drawing.Size(307, 23);
            this.NamePart1Txt.TabIndex = 0;
            this.NamePart1Txt.Text = "Name";
            this.NamePart1Txt.Click += new System.EventHandler(this.NamePart1Txt_Click);
            // 
            // SignEmailTxt
            // 
            this.SignEmailTxt.Location = new System.Drawing.Point(76, 147);
            this.SignEmailTxt.Name = "SignEmailTxt";
            this.SignEmailTxt.Size = new System.Drawing.Size(307, 23);
            this.SignEmailTxt.TabIndex = 2;
            this.SignEmailTxt.Text = "Email address";
            this.SignEmailTxt.Click += new System.EventHandler(this.SignEmailTxt_Click);
            // 
            // SignPassTxt
            // 
            this.SignPassTxt.Location = new System.Drawing.Point(76, 176);
            this.SignPassTxt.Name = "SignPassTxt";
            this.SignPassTxt.Size = new System.Drawing.Size(307, 23);
            this.SignPassTxt.TabIndex = 3;
            this.SignPassTxt.Text = "New Password";
            this.SignPassTxt.Click += new System.EventHandler(this.SignPassTxt_Click);
            // 
            // SignAreaTxt
            // 
            this.SignAreaTxt.Location = new System.Drawing.Point(76, 205);
            this.SignAreaTxt.Name = "SignAreaTxt";
            this.SignAreaTxt.Size = new System.Drawing.Size(307, 23);
            this.SignAreaTxt.TabIndex = 4;
            this.SignAreaTxt.Text = "Location";
            this.SignAreaTxt.Click += new System.EventHandler(this.SignAreaTxt_Click);
            // 
            // SignAgeTxt
            // 
            this.SignAgeTxt.Location = new System.Drawing.Point(241, 238);
            this.SignAgeTxt.Name = "SignAgeTxt";
            this.SignAgeTxt.Size = new System.Drawing.Size(142, 23);
            this.SignAgeTxt.TabIndex = 6;
            this.SignAgeTxt.Text = "Age";
            this.SignAgeTxt.Click += new System.EventHandler(this.SignAgeTxt_Click);
            // 
            // SexCombo
            // 
            this.SexCombo.FormattingEnabled = true;
            this.SexCombo.ItemHeight = 23;
            this.SexCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexCombo.Location = new System.Drawing.Point(111, 279);
            this.SexCombo.Name = "SexCombo";
            this.SexCombo.Size = new System.Drawing.Size(97, 29);
            this.SexCombo.TabIndex = 8;
            this.SexCombo.SelectedIndexChanged += new System.EventHandler(this.SexCombo_SelectedIndexChanged);
            // 
            // SignSexTxt
            // 
            this.SignSexTxt.AutoSize = true;
            this.SignSexTxt.Location = new System.Drawing.Point(76, 279);
            this.SignSexTxt.Name = "SignSexTxt";
            this.SignSexTxt.Size = new System.Drawing.Size(29, 19);
            this.SignSexTxt.TabIndex = 9;
            this.SignSexTxt.Text = "Sex";
            this.SignSexTxt.Click += new System.EventHandler(this.SignSexTxt_Click);
            // 
            // StatusCombo
            // 
            this.StatusCombo.FormattingEnabled = true;
            this.StatusCombo.ItemHeight = 23;
            this.StatusCombo.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.StatusCombo.Location = new System.Drawing.Point(286, 279);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(97, 29);
            this.StatusCombo.TabIndex = 10;
            this.StatusCombo.SelectedIndexChanged += new System.EventHandler(this.StatusCombo_SelectedIndexChanged);
            // 
            // SignStatusTxt
            // 
            this.SignStatusTxt.AutoSize = true;
            this.SignStatusTxt.Location = new System.Drawing.Point(235, 279);
            this.SignStatusTxt.Name = "SignStatusTxt";
            this.SignStatusTxt.Size = new System.Drawing.Size(45, 38);
            this.SignStatusTxt.TabIndex = 11;
            this.SignStatusTxt.Text = "Doner\r\nStatus";
            this.SignStatusTxt.Click += new System.EventHandler(this.SignStatusTxt_Click);
            // 
            // Sign_btn
            // 
            this.Sign_btn.Location = new System.Drawing.Point(132, 361);
            this.Sign_btn.Name = "Sign_btn";
            this.Sign_btn.Size = new System.Drawing.Size(200, 20);
            this.Sign_btn.TabIndex = 12;
            this.Sign_btn.Text = "Sign Up";
            this.Sign_btn.Click += new System.EventHandler(this.Sign_btn_Click);
            // 
            // bloodGroupCombo
            // 
            this.bloodGroupCombo.FormattingEnabled = true;
            this.bloodGroupCombo.ItemHeight = 23;
            this.bloodGroupCombo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodGroupCombo.Location = new System.Drawing.Point(76, 234);
            this.bloodGroupCombo.Name = "bloodGroupCombo";
            this.bloodGroupCombo.Size = new System.Drawing.Size(159, 29);
            this.bloodGroupCombo.TabIndex = 8;
            this.bloodGroupCombo.SelectedIndexChanged += new System.EventHandler(this.SexCombo_SelectedIndexChanged);
            // 
            // Sign_Up_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.Sign_btn);
            this.Controls.Add(this.SignStatusTxt);
            this.Controls.Add(this.StatusCombo);
            this.Controls.Add(this.SignSexTxt);
            this.Controls.Add(this.bloodGroupCombo);
            this.Controls.Add(this.SexCombo);
            this.Controls.Add(this.SignAgeTxt);
            this.Controls.Add(this.SignAreaTxt);
            this.Controls.Add(this.SignPassTxt);
            this.Controls.Add(this.SignEmailTxt);
            this.Controls.Add(this.NamePart1Txt);
            this.Name = "Sign_Up_Form";
            this.Text = "Sign_Up_Form";
            this.Load += new System.EventHandler(this.Sign_Up_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox NamePart1Txt;
        private MetroFramework.Controls.MetroTextBox SignEmailTxt;
        private MetroFramework.Controls.MetroTextBox SignPassTxt;
        private MetroFramework.Controls.MetroTextBox SignAreaTxt;
        private MetroFramework.Controls.MetroTextBox SignAgeTxt;
        private MetroFramework.Controls.MetroComboBox SexCombo;
        private MetroFramework.Controls.MetroLabel SignSexTxt;
        private MetroFramework.Controls.MetroComboBox StatusCombo;
        private MetroFramework.Controls.MetroLabel SignStatusTxt;
        private MetroFramework.Controls.MetroButton Sign_btn;
        private MetroFramework.Controls.MetroComboBox bloodGroupCombo;
    }
}