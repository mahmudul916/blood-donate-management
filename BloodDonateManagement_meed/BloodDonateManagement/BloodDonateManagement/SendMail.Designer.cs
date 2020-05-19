namespace BloodDonateManagement
{
    partial class SendMail
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mailTxt = new MetroFramework.Controls.MetroTextBox();
            this.mailBodyTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 86);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(26, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "To:";
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(80, 85);
            this.mailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(209, 28);
            this.mailTxt.TabIndex = 1;
            // 
            // mailBodyTxt
            // 
            this.mailBodyTxt.Location = new System.Drawing.Point(31, 140);
            this.mailBodyTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mailBodyTxt.Multiline = true;
            this.mailBodyTxt.Name = "mailBodyTxt";
            this.mailBodyTxt.Size = new System.Drawing.Size(696, 241);
            this.mailBodyTxt.TabIndex = 2;
            this.mailBodyTxt.Text = "Write your mail here";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(256, 398);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(275, 44);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Send";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 446);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mailBodyTxt);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SendMail";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Send Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mailTxt;
        private MetroFramework.Controls.MetroTextBox mailBodyTxt;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}