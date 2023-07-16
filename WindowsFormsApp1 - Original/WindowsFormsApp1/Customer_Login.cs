using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Customer_Login : MetroFramework.Forms.MetroForm
    {
        public Customer_Login()
        {
            InitializeComponent();
        }

        private void Customer_Login_Load(object sender, EventArgs e)
        {

        }
        private void btn_cllogin_Click(object sender, EventArgs e)
        {
           /* try
            {
                string c_username = txt_clusername.Text;
                string C_password = txt_clpassword.Text;


                if (string.IsNullOrEmpty(txt_clusername.Text))
                {
                    metroLabel3.Text = "Username Can not be blank";
                }
                else if (txt_clusername.Text.Any(char.IsSymbol))
                {
                    metroLabel3.Text = "Username Can not have Symbols";
                }
                else if (string.IsNullOrEmpty(txt_clpassword.Text))
                {
                    metroLabel3.Text = "Password Can not be blank";

                }
                else if (txt_clpassword.Text.Length != 8)
                {
                    metroLabel3.Text = "Password Should have 8 Characters";
                }
                else if (!Regex.IsMatch(txt_clpassword.Text, @"^?=.*[a - z](?=.*[A - Z])(?=.*\d)(?=.*[@$! % *? &])[A - Za - z\d@$! % *? &]{ 8,}$"))
                {
                    metroLabel3.Text = "Please mus contains letter,symbols, digts and characters";
                }
                else
                {
                    MessageBox.Show(" You Have Successfully Logged as a Customer Member. Click next to go Home Page or click back to Clear the password and username", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            
            catch (FormatException)
            {
                MessageBox.Show("Check the values that you have entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           */

        }

        private void link_clback_Click(object sender, EventArgs e)
        {
            //txt_clpassword.Clear();
            //txt_clusername.Clear();
        }

        private void link_clnext_Click(object sender, EventArgs e)
        {
            //HOME home1 = new HOME();
            //home1.Show();
            //this.Hide();
        }
        
    }

}
    
    

