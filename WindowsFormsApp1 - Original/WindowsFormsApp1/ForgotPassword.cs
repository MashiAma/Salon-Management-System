using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class ForgotPassword : Form
    {
        string randomCode;
        public static string to;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
        }
        private void btn_fpback_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage loginPage1 = new LoginPage();
            loginPage1.Show();
        }

        private void btn_fpverify_Click(object sender, EventArgs e)
        {
            if(randomCode==(txt_fpvercode.Text).ToString())
            {
                to=txt_fpemail.Text;
                this.Close();
                ResetPassword resetPassword1 = new ResetPassword();
                resetPassword1.Show();
            }
            else
            { 
                MessageBox.Show("Please Enter Correct Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btn_fpsendemail_Click(object sender, EventArgs e)
        {
            try
            {

                string from, pass, messageBody;
                Random random1 = new Random();
                randomCode = (random1.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (txt_fpemail.Text).ToString();

                if (txt_fpemail.Text.Length == 0)
                {
                    MessageBox.Show("Email Address Field can not be Blank.");
                    txt_fpemail.Focus();
                }
                else if (!Regex.IsMatch(txt_fpemail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Please Enter a valid email Address.");
                    txt_fpemail.Focus();
                }
                else
                {
                    from = "queenbeautysalonmain@gmail.com";
                    pass = "llpbqjranuoricdg";
                    messageBody = "Your Password Reset Code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Password Reseting Code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    smtp.Send(message);
                    MessageBox.Show("Verification Code send Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            catch (Exception)
            {
                MessageBox.Show("Verification Code not Sent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
