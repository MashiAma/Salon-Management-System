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

namespace WindowsFormsApp1
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void Expenses_Load(object sender, EventArgs e)
        {
            lbl_heading1.Text = "Expenses Adding and Updation";
            lbl_heading3.Text = "All Expenses Details";
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
            
            DateTime currentDate = DateTime.Now;
            exp_date.MinDate = currentDate.AddDays(-30); 
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
            con.Open();
            using (cmd = new SqlCommand("SELECT MAX(Expense_Id) +1 as Expense_Id FROM Expenses", con))
            {
                
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    txt_expid.Text = sdr["Expense_Id"].ToString();
                }
                con.Close();
            }
        }
        private void expense_value_ValueChanged(object sender, EventArgs e)
        {
            expense_value.Minimum = 0;
            expense_value.Maximum = int.MaxValue;
        }
        private void btn_eadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string description = txt_description.Text;
                DateTime dob = exp_date.Value;
                int value = Convert.ToInt32(expense_value.Text);
                if (string.IsNullOrEmpty(txt_expid.Text))
                {
                    lbl_displayerror.Text = "Id Field cannot be Blank";
                    txt_expid.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_etype.Text))
                {
                    lbl_displayerror.Text = "Type Field must be Selected";
                    cmb_etype.Focus();
                }
                else if (string.IsNullOrEmpty(txt_description.Text))
                {
                    lbl_displayerror.Text = "Description Field cannot be Blank";
                    txt_description.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_ebranch.Text))
                {
                    lbl_displayerror.Text = "Branch must be selected.";
                }
                else if (string.IsNullOrEmpty(expense_value.Text))
                {
                    lbl_displayerror.Text = "Amount Field Can not be Blank.";
                    expense_value.Focus();
                }
                else if (!Regex.IsMatch(expense_value.Text, @"^[0-9]+$"))
                {
                    lbl_displayerror.Text = "SAmount Field Has numbers Only";
                    lbl_displayerror.Focus();
                }
                else
                {
                    lbl_displayerror.Text = "";
                    con.Open();
                    cmd = new SqlCommand("Insert into Expenses values ('"+txt_expid.Text+"','" + cmb_etype.Text + "','" + txt_description.Text + "', '" + cmb_ebranch.Text + "', '" + exp_date.Value + "','" + expense_value.Text + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("You Have Successfully added Expense to the System.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Data Can not be added to the System.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_eupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_expid.Text))
                {
                    lbl_displayerror.Text = "Id Field cannot be Blank";
                    txt_expid.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_etype.Text))
                {
                    lbl_displayerror.Text = "Type Field must be Selected";
                    cmb_etype.Focus();
                }
                else if (string.IsNullOrEmpty(txt_description.Text))
                {
                    lbl_displayerror.Text = "Description Field cannot be Blank";
                    txt_description.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_ebranch.Text))
                {
                    lbl_displayerror.Text = "Branch must be selected.";
                }
                else if (string.IsNullOrEmpty(expense_value.Text))
                {
                    lbl_displayerror.Text = "Amount Field Can not be Blank.";
                    expense_value.Focus();
                }
                else if (!Regex.IsMatch(expense_value.Text, @"^[0-9]+$"))
                {
                    lbl_displayerror.Text = "SAmount Field Has numbers Only";
                    lbl_displayerror.Focus();
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("Update Expenses set Expense_Type='" + cmb_etype.Text + "', Expense_Description='" + txt_description.Text + "',Branch= '" + cmb_ebranch.Text + "',Expense_Date= '" + exp_date.Value + "',Amount= '" + expense_value.Text + "' where Expense_Id='" + txt_expid.Text+ "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Your Data Successfully updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Data Can not be Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_eclear_Click(object sender, EventArgs e)
        {
            txt_expid.Clear();
            txt_description.Clear();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Expenses", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_searchbranch_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Expenses Where Branch='" + cmb_branchsearch.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
