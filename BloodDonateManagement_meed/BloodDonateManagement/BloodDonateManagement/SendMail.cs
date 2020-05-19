using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using System.Net.Mail;

namespace BloodDonateManagement
{
    public partial class SendMail : MetroForm
    {
        string mailAddress;

        public SendMail(string mailAddress)
        {
            InitializeComponent();
            this.mailAddress = mailAddress;
            mailTxt.Text = mailAddress;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MailMessage("BloodDonoroop2@gmail.com", mailAddress);
                message.Subject = "Blood Needed";
                message.Body = mailBodyTxt.Text;
                SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587);
                mailer.Credentials = new NetworkCredential("BloodDonoroop2@gmail.com", "donateblood");
                mailer.EnableSsl = true;
                mailer.Send(message);

                MessageBox.Show("Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
