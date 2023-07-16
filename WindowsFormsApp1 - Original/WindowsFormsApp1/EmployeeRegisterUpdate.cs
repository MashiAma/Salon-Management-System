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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class EmployeeRegisterUpdate : Form
    {
        public EmployeeRegisterUpdate()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void C_AccountCreate_Load(object sender, EventArgs e)
        {
            lbl_heading1.Text = "Employee Details Registration and Updation";
            lbl_heading3.Text = "All Employee Details ";
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
            using (cmd = new SqlCommand("SELECT MAX(Employee_Id) +1 as Employee_Id FROM Employee", con))
            {
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    txt_id.Text = sdr["Employee_Id"].ToString();
                }
                con.Close();
            }
        }

        private void btn_empregister_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime do_joining = date_empjoining.Value;
                string f_name = txt_fname.Text;
                string l_name = txt_lname.Text;
                string tp = txt_telephone.Text;
                string email = txt_email.Text;
                DateTime dob = dob_picker.Value;
                int salary = Convert.ToInt32(txt_salary.Text);

                if (string.IsNullOrEmpty(date_empjoining.Text))
                {
                    lbl_displayerror.Text = "Joining Date Must be Selected.";
                    txt_fname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_fname.Text))
                {
                    lbl_displayerror.Text = "First Name Field cannot be Blank.";
                    txt_fname.Focus();
                }
                else if (!Regex.IsMatch(txt_fname.Text, @"^[a-zA-Z]+$"))
                {
                    lbl_displayerror.Text = "First Name Field only have Letters.";
                    txt_fname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_lname.Text))
                {
                    lbl_displayerror.Text = "Last Name Field cannot be Blank";
                    txt_lname.Focus();
                }
                else if (!Regex.IsMatch(txt_lname.Text, @"^[a-zA-Z]+$"))
                {
                    lbl_displayerror.Text = "Last Name Field only have Letters.";
                    txt_lname.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_branch.Text))
                {
                    lbl_displayerror.Text = "Branch must be selected.";
                }
                else if (txt_telephone.Text.Length == 0)
                {
                    lbl_displayerror.Text = "Telephone Number Field can not be Blank.";
                    txt_telephone.Focus();
                }
                else if (txt_telephone.Text.Length != 10)
                {
                    lbl_displayerror.Text = "Telephone Number Field must have 10 Numbers";
                    txt_telephone.Focus();
                }
                else if (!Regex.IsMatch(txt_telephone.Text, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
                {
                    lbl_displayerror.Text = "Telephone Number Field only have Numbers.";
                    txt_telephone.Focus();
                }
                
                else if (txt_email.Text.Length == 0)
                {
                    lbl_displayerror.Text = "Email Field cannot be Blank";
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_displayerror.Text = "Please Enter Valid Email Address.";
                    txt_email.Focus();
                }
                else if (string.IsNullOrEmpty(dob_picker.Text))
                {
                    lbl_displayerror.Text = "Date Of Birth must be Selected";
                    dob_picker.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_designation.Text))
                {
                    lbl_displayerror.Text = "Designation must be selected";
                    cmb_designation.Focus();
                }
                else if (string.IsNullOrEmpty(txt_salary.Text))
                {
                    lbl_displayerror.Text = "Salary Field cannot be Blank";
                    txt_salary.Focus();
                }
                else if (!Regex.IsMatch(txt_salary.Text, @"^[0-9]+$"))
                {
                    lbl_displayerror.Text = "Salary Field contains Numbers Only";
                    txt_salary.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_status1.Text))
                {
                    lbl_displayerror.Text = "Status Field must be selected";
                    cmb_status1.Focus();
                }
                else
                {
                    lbl_displayerror.Text = "";
                    con.Open();
                    cmd = new SqlCommand("Insert into Employee values ('" + txt_id.Text + "','" + date_empjoining.Value + "','" + txt_fname.Text + "', '" + txt_lname.Text + "', '" + cmb_branch.Text + "','" + txt_telephone.Text + "','" + txt_email.Text + "','" + dob_picker.Value + "', '" + cmb_designation.Text + "','" + txt_salary.Text + "','" + cmb_status1.Text + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("You Have Successfully Saved Employee to the System.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Data Can not be Saved to the System.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Check the values that you have entered", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_empupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(date_empjoining.Text))
                {
                    lbl_displayerror.Text = "Joining Date Must be Selected.";
                    txt_fname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_fname.Text))
                {
                    lbl_displayerror.Text = "First Name Field cannot be Blank.";
                    txt_fname.Focus();
                }
                else if (!Regex.IsMatch(txt_fname.Text, @"^[a-zA-Z]+$"))
                {
                    lbl_displayerror.Text = "First Name Field only have Letters.";
                    txt_fname.Focus();
                }
                else if (string.IsNullOrEmpty(txt_lname.Text))
                {
                    lbl_displayerror.Text = "Last Name Field cannot be Blank";
                    txt_lname.Focus();
                }
                else if (!Regex.IsMatch(txt_lname.Text, @"^[a-zA-Z]+$"))
                {
                    lbl_displayerror.Text = "Last Name Field only have Letters.";
                    txt_lname.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_branch.Text))
                {
                    lbl_displayerror.Text = "Branch must be selected.";
                }
                else if (txt_telephone.Text.Length == 0)
                {
                    lbl_displayerror.Text = "Telephone Number Field can not be Blank.";
                    txt_telephone.Focus();
                }
                else if (txt_telephone.Text.Length != 10)
                {
                    lbl_displayerror.Text = "Telephone Number Field must have 10 Numbers";
                    txt_telephone.Focus();
                }
                else if (!Regex.IsMatch(txt_telephone.Text, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
                {
                    lbl_displayerror.Text = "Telephone Number Field only have Numbers.";
                    txt_telephone.Focus();
                }

                else if (txt_email.Text.Length == 0)
                {
                    lbl_displayerror.Text = "Email Field cannot be Blank";
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_displayerror.Text = "Please Enter Valid Email Address.";
                    txt_email.Focus();
                }
                else if (string.IsNullOrEmpty(dob_picker.Text))
                {
                    lbl_displayerror.Text = "Date Of Birth must be Selected";
                    dob_picker.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_designation.Text))
                {
                    lbl_displayerror.Text = "Designation must be selected";
                    cmb_designation.Focus();
                }
                else if (string.IsNullOrEmpty(txt_salary.Text))
                {
                    lbl_displayerror.Text = "Salary Field cannot be Blank";
                    txt_salary.Focus();
                }
                else if (!Regex.IsMatch(txt_salary.Text, @"^[0-9]+$"))
                {
                    lbl_displayerror.Text = "Salary Field contains Numbers Only";
                    txt_salary.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_status1.Text))
                {
                    lbl_displayerror.Text = "Status Field must be selected";
                    cmb_status1.Focus();
                }
                else
                {
                    lbl_displayerror.Text = "";
                    con.Open();
                    cmd = new SqlCommand("Update Employee set Joining_Date='" + date_empjoining.Value + "',FirstName='" + txt_fname.Text + "', LastName='" + txt_lname.Text + "', Branch='" + cmb_branch.Text + "',Telephone='" + txt_telephone.Text + "',Email='" + txt_email.Text + "',Date_of_Birth='" + dob_picker.Value + "', Designation='" + cmb_designation.Text + "',Salary='" + Convert.ToDouble(txt_salary.Text) + "', Employee_Status='" + cmb_status1.Text + "' where Employee_Id = '" + txt_id.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("All the Data Successfully updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data Can not be Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_empclear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_telephone.Clear();
            txt_email.Clear();
            txt_salary.Clear();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Employee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_designation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_designation.SelectedIndex == 0)
                txt_salary.Text = (50000).ToString();
            else if (cmb_designation.SelectedIndex == 1)
                txt_salary.Text = (30000).ToString();
            else if (cmb_designation.SelectedIndex == 2)
                txt_salary.Text = (10000).ToString();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_heading1_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    


   



