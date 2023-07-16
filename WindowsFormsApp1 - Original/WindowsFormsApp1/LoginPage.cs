using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;

        private void LoginPage_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
        }

        private void btn_lologin_Click(object sender, EventArgs e)
        {
            try
            {
                string s_username = txt_logusername.Text;
                string s_password = txt_logpassword.Text;

                con.Open();
                da = new SqlDataAdapter("Select * from Login_Details where Username='" + txt_logusername.Text + "' and L_Password='" + txt_logpassword.Text + "'", con);
                DataTable datatable1 = new DataTable();
                da.Fill(datatable1);
                MainPage mainPage1 = new MainPage();
                mainPage1.btn_user.Text = txt_logusername.Text;

                if (datatable1.Rows.Count > 0)
                {
                    MessageBox.Show("You Have Succssfully Logged to the System");
                    this.Hide();
                    //MainPage mainPage2 = new MainPage();
                    mainPage1.Show();
                }
                else if (string.IsNullOrEmpty(txt_logusername.Text))
                {
                    lbl_meslogin.Text = "Username can not be Blank.";
                    txt_logusername.Focus();
                }

                else if (string.IsNullOrEmpty(txt_logpassword.Text))
                {
                    lbl_meslogin.Text = "Password can not be Blank.";
                    txt_logpassword.Focus();
                }
                else
                {
                    lbl_meslogin.Text = "Invalid username or password.Try Again";
                    txt_logpassword.Clear();
                    txt_logusername.Clear();
                }
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check the Values that you have entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Please Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

            private void btn_logclear_Click(object sender, EventArgs e)
            {
                txt_logpassword.Clear();
                txt_logusername.Clear();
            }

        private void linklbl_forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ForgotPassword forgotPassword1 = new ForgotPassword();
            forgotPassword1.Show();

        }

        private void cb_password_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_password.Checked == true)
            {
                txt_logpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_logpassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
                this.Close();

        }
    }
}
