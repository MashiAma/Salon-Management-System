using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void Signup_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
        }
        private void btn_register_Click_1(object sender, EventArgs e)
        {
            try
            {
                string s_username = txt_regusername.Text;
                string s_password = txt_regpass.Text;
                string c_password = txt_regconpass.Text;
                string email = txt_regemail.Text;

                if (string.IsNullOrEmpty(txt_regusername.Text))
                {
                    lbl_mesregister.Text = "Username Feild Can not be blank";
                }
                else if (string.IsNullOrEmpty(txt_regpass.Text))
                {
                    lbl_mesregister.Text = "Password Feild Can not be blank";
                }
                else if (!Regex.IsMatch(txt_regpass.Text, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$"))
                {
                    lbl_mesregister.Text = "Password have Minimum eight characters \n and atleast have one letter or one number";
                }
                else if (string.IsNullOrEmpty(txt_regconpass.Text))
                {
                    lbl_mesregister.Text = "Confirm Password Feild Can not be blank";
                }
                else if (txt_regconpass.Text != txt_regpass.Text)
                {
                    lbl_mesregister.Text = "Password Feild and Confirm Password Feild\n Should be matched.";
                }
                else if (txt_regemail.Text.Length == 0)
                {
                    lbl_mesregister.Text = "Please Enter Email Address.";
                }
                else if (!Regex.IsMatch(txt_regemail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_mesregister.Text = "Enter a valid email. Ex:name@gmail.com";
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into Login_Details values ('" + txt_regusername.Text + "','" + txt_regpass.Text + "', '" + txt_regconpass.Text + "','" + txt_regemail.Text + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("You Have Successfully Register User to the System.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Data Can not be Save to the System.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Check whether you have entered correct values or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginPage loginPage1 = new LoginPage();
            loginPage1.Show();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_regusername.Clear();
            txt_regpass.Clear();
            txt_regconpass.Clear();
            txt_regemail.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

