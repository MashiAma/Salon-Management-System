using MetroFramework.Controls;
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
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsApp1
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
           InitializeComponent(); 
            

        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void Staff_Login_Load(object sender, EventArgs e)
        {

            DateTime currentTime = DateTime.Now;
            TimeSpan currentDayTime = currentTime.TimeOfDay;

            if (currentDayTime < new TimeSpan(12, 0, 0))
            {

                lbl_ldis.Text = "Hi Good Morning, Welcome Back to the Login Page...!";
            }
            else
            {

                lbl_ldis.Text = "Hi Good Evening, Welcome Back to the Login Page...!";
            }
            }

        private void btn_sllogin_Click(object sender, EventArgs e)
        {
            
        }

        private void link_slback_Click(object sender, EventArgs e)
        {
            ;
        }

        private void linklbl_lsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login1 = new Login();
            login1.Close();
            ManageCustomer signup1 = new ManageCustomer();
            signup1.Show();
            signup1.BringToFront();
        }

        
    }

}
