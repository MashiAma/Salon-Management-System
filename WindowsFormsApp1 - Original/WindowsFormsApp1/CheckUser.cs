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
    public partial class CheckUser : Form
    {
        public string pageName;
        public CheckUser(string pageName)
        {
            InitializeComponent();
            this.pageName = pageName;   
        }
        SqlConnection con;
        SqlDataAdapter da;

        private void CheckUser_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            User(pageName);
        }
        public void User(string pageName)
        {
            try
            {
                string s_username = txt_logusername.Text;
                string s_password = txt_logpassword.Text;

                con.Open();
                da = new SqlDataAdapter("Select * from Login_Details where Username='" + txt_logusername.Text + "' and L_Password='" + txt_logpassword.Text + "'", con);
                DataTable datatable1 = new DataTable();
                da.Fill(datatable1);

                if (datatable1.Rows.Count == 1)
                {                    
                    MessageBox.Show("Sussefully access the Page","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if(pageName== "EmployeeRegisterUpdate")
                    {
                        EmployeeRegisterUpdate employeeRegisterUpdate1 = new EmployeeRegisterUpdate();
                        employeeRegisterUpdate1.Show();
                    }    
                    else if (pageName == "Expenses")
                    {
                        Expenses expenses1 = new Expenses();
                        expenses1.Show();
                    }
                    else if (pageName=="Signup")
                    {
                        Signup signup1= new Signup();
                        signup1.Show();
                    }
                    this.Close();                  
                }
                else
                {
                    MessageBox.Show("Your username or password was incorrect or else You don't have an access to this page","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
