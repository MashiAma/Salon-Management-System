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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;



namespace WindowsFormsApp1
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_cpusername.Text))
                {
                    lbl_message.Text = "Username Field can not be Blank.";
                    txt_cpusername.Focus();
                }
                else if (string.IsNullOrEmpty(txt_cpcurrentpassword.Text))
                {
                    lbl_message.Text = "Current Password Field can not be Blank.";
                    txt_cpcurrentpassword.Focus();
                }
                else if (string.IsNullOrEmpty(txt_cpnewpassword.Text))
                {
                    lbl_message.Text = "New Password Field can not be Blank.";
                    txt_cpnewpassword.Focus();

                }
                else if (!Regex.IsMatch(txt_cpnewpassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$"))
                {
                    lbl_message.Text = "New Password Minimum have eight characters and \n atleast have one letter or one number";
                    txt_cpnewpassword.Focus();
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("Select * from Login_Details where Username='" + txt_cpusername.Text + "' and L_Password='" + txt_cpcurrentpassword.Text + "'", con);
                    da = new SqlDataAdapter(cmd);
                    DataTable datatable1 = new DataTable();
                    da.Fill(datatable1);

                    if (datatable1.Rows.Count > 0)
                    {

                        cmd = new SqlCommand("Update Login_Details set L_Password='" + txt_cpnewpassword.Text + "',Confirm_Password='" + txt_cpnewpassword.Text + "' where Username = '" + txt_cpusername.Text + "'", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Your Password Successfully Changed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                            
                        else
                            MessageBox.Show("Your Password Can not be Changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Invalid Current username or password that you have entered. Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }

            catch (SqlException)
            {
                System.Windows.MessageBox.Show("Database Errors", "ERROR", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cpusername.Clear();
            txt_cpnewpassword.Clear();
            txt_cpcurrentpassword.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
