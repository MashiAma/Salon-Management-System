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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WindowsFormsApp1
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
   
        private void Customer_SignUp_Load(object sender, EventArgs e)
        {         
            lbl_heading1.Text = "Register and Update Customer Details";
            lbl_heading3.Text = "All Customer Details ";
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
        
            using (cmd = new SqlCommand("SELECT MAX(Customer_Id) +1 as Customer_Id FROM Customer", con))
            {
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    txt_id.Text = sdr["Customer_Id"].ToString();
                }
                con.Close();
            }

        }
        private void btn_cusregister_Click(object sender, EventArgs e)
        {
            try
            {
                string f_name = txt_fname.Text;
                string l_name = txt_lname.Text;
                string tp = txt_telephone.Text;
                string email = txt_email.Text;
                DateTime dob = dob_picker.Value;

                if (string.IsNullOrEmpty(txt_fname.Text))
                {
                    lbl_cregister.Text = "First Name Field cannot be Blank.";
                    txt_fname.Focus();
                }
                else if (!Regex.IsMatch(txt_fname.Text, @"^[a-zA-Z]+$"))
                {
                    lbl_cregister.Text = "First Name Field only have Letters.";
                    txt_fname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_lname.Text))
                {
                    lbl_cregister.Text = "Last Name Field cannot be Blank";
                    txt_lname.Focus();
                }
                else if (!Regex.IsMatch(txt_lname.Text, @"^[a-zA-Z]+$"))
                {
                    lbl_cregister.Text = "Last Name Field only have Letters.";
                    txt_lname.Focus();
                }
                else if (txt_telephone.Text.Length == 0)
                {
                    lbl_cregister.Text = "Telephone Number Field can not be Blank.";
                    txt_telephone.Focus();
                }
                else if (txt_telephone.Text.Length != 10)
                {
                    lbl_cregister.Text = "Telephone Number Field must have 10 Numbers";
                    txt_telephone.Focus();
                }
                else if (!Regex.IsMatch(txt_telephone.Text, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
                {
                    lbl_cregister.Text = "Telephone Number Field only have Numbers.";
                    txt_telephone.Focus();
                }                
                else if (txt_email.Text.Length == 0)
                {
                    lbl_cregister.Text = "Email Address Field can not be Blank.";
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_cregister.Text = "Please Enter a valid email Address.";
                    txt_email.Focus();
                }
                else if (string.IsNullOrEmpty(dob_picker.Text))
                {
                    lbl_cregister.Text = "Please Select Date of Birth Field.";
                    txt_email.Focus();
                }
                else
                {
                    lbl_cregister.Text = "";
                    con.Open();
                    cmd = new SqlCommand("Insert into Customer values ('" + txt_id.Text + "','" + txt_fname.Text + "', '" + txt_lname.Text + "','" + txt_telephone.Text + "','" + txt_email.Text + "','" + dob_picker.Value + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        System.Windows.Forms.MessageBox.Show("You Have Successfully Saved Customer to the System.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Your Data Can not be Save to the System.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Check the values that you have entered", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btn_cusupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_fname.Text))
                {
                    lbl_cregister.Text = "First Name Field cannot be Blank.";
                    txt_fname.Focus();
                }
                else if (!Regex.IsMatch(txt_fname.Text, @"^[a-zA-Z]+$"))
                {
                    lbl_cregister.Text = "First Name Field only have Letters.";
                    txt_fname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_lname.Text))
                {
                    lbl_cregister.Text = "Last Name Field cannot be Blank";
                    txt_lname.Focus();
                }
                else if (!Regex.IsMatch(txt_lname.Text, @"^[a-zA-Z]+$"))
                {
                    lbl_cregister.Text = "Last Name Field only have Letters.";
                    txt_lname.Focus();
                }
                else if (txt_telephone.Text.Length == 0)
                {
                    lbl_cregister.Text = "Telephone Number Field can not be Blank.";
                    txt_telephone.Focus();
                }
                else if (txt_telephone.Text.Length != 10)
                {
                    lbl_cregister.Text = "Telephone Number Field must have 10 Numbers";
                    txt_telephone.Focus();
                }
                else if (!Regex.IsMatch(txt_telephone.Text, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
                {
                    lbl_cregister.Text = "Telephone Number Field only have Numbers.";
                    txt_telephone.Focus();
                }
                else if (txt_email.Text.Length == 0)
                {
                    lbl_cregister.Text = "Email Address Field can not be Blank.";
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_cregister.Text = "Please Enter a valid email Address.";
                    txt_email.Focus();
                }
                else if (string.IsNullOrEmpty(dob_picker.Text))
                {
                    lbl_cregister.Text = "Please Select Date of Birth Field.";
                    txt_email.Focus();
                }
                else
                {
                    lbl_cregister.Text = "";
                    con.Open();
                    cmd = new SqlCommand("Update Customer set FirstName='" + txt_fname.Text + "', LastName='" + txt_lname.Text + "',Telephone='" + txt_telephone.Text + "',Email='" + txt_email.Text + "',Date_of_Birth='" + dob_picker.Value + "' where Customer_Id = '" + txt_id.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        System.Windows.Forms.MessageBox.Show("Your Data Successfully updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        System.Windows.Forms.MessageBox.Show("Your Data Can not be Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
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
        private void btn_cusclear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_telephone.Clear();
            txt_email.Clear();
        }

      
        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            { 
                con.Open();
                da = new SqlDataAdapter("Select * from Customer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

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

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_cusdisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
