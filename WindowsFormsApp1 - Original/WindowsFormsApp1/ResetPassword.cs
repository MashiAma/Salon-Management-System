using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class ResetPassword : Form
    {
        string username = ForgotPassword.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
        }

        private void btn_rpback_Click(object sender, EventArgs e)
        {
            this.Close();
            ForgotPassword forgotPassword1 = new ForgotPassword();
            forgotPassword1.Show();
        }

        private void btn_rplogin_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage loginPage1 = new LoginPage();
            loginPage1.Show();
        }

        private void btn_rpreset_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_rpusername.Text))
                {
                    MessageBox.Show("Username Should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!Regex.IsMatch(txt_rpnewpassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$"))
                {
                    MessageBox.Show("Password have Minimum eight characters and atleast have one letter or one number","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_rpnewpassword.Text)) 
                {
                    MessageBox.Show("New Password Field Should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_rpconpassword.Text))
                {
                    MessageBox.Show("Confirm Password Field Should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_rpnewpassword.Text != txt_rpconpassword.Text)
                {
                    MessageBox.Show("New Password Field and Confirm Password Field Should be matched.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                { 
                    con.Open();
                    cmd = new SqlCommand("Update Login_Details set L_Password='" + txt_rpnewpassword.Text + "',Confirm_Password='" + txt_rpconpassword.Text + "' where Username= '" +txt_rpusername.Text + "'", con);
                    int i=cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Your Password Successfully reset.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Password Can not be reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
              
            }
            catch (SqlException)
            {
                System.Windows.Forms.MessageBox.Show("Database Errors", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        
    }
}
