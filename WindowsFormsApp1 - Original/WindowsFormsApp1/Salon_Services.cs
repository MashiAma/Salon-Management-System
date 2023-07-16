using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Salon_Services : Form
    {
        public Salon_Services()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void Salon_Services_Load(object sender, EventArgs e)
        {
            lbl_serupdateadd.Text = "Services Adding and Updation";
            lbl_deldis.Text = "Delete Services";
            lbl_serrudis.Text = " All Services";
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
        }
        
        private void btn_seradd_Click_1(object sender, EventArgs e)
        { 
            try
            {
                string ser_name = txt_sersn.Text;
                int duration = Convert.ToInt32(txt_serduration.Text);
                int charge = Convert.ToInt32(txt_sercharge.Text);

                if (string.IsNullOrEmpty(cmb_branch.Text))
                {
                    lbl_eerrordis.Text = "Branch must be selected";
                }
                else if (string.IsNullOrEmpty(txt_sersn.Text))
                {
                    lbl_eerrordis.Text = "Service Name Field cannot be Blank";
                    txt_sersn.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_sercategory.Text))
                {
                    lbl_eerrordis.Text = "Service Category must be selected";
                }                
                else if (string.IsNullOrEmpty(txt_serduration.Text))
                {
                    lbl_eerrordis.Text = "Service Duration Field cannot be Blank";
                    txt_serduration.Focus();
                }
                else if (!Regex.IsMatch(txt_serduration.Text, @"^[0-9]+$"))
                {
                    lbl_eerrordis.Text = "Appointment ID Should contains Numbers Only.";
                }                
                else if (string.IsNullOrEmpty(txt_sercharge.Text))
                {
                    lbl_eerrordis.Text = "Service Charge Field cannot be Blank";
                    txt_sercharge.Focus();
                }
                else if (!Regex.IsMatch(txt_sercharge.Text, @"^[0-9]+$"))
                {
                    lbl_eerrordis.Text = "Service Charge Field Has numbers Only";
                    txt_sercharge.Focus();
                }
                else
                {
                    lbl_eerrordis.Text = "";
                    con.Open();
                    cmd = new SqlCommand("Insert into Salon_Services values ('" + cmb_branch.Text + "' ,'" + txt_sersn.Text + "','" + cmb_sercategory.Text + "', '" + txt_serduration.Text + "','" + txt_sercharge.Text + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("You Have Successfully Saved Service to the System.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Data Can not be Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Check the values that you have entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btn_serclearr_Click_1(object sender, EventArgs e)
        {
            txt_sersn.Clear();
            txt_serduration.Clear();
            txt_sercharge.Clear();
        }

       
       private void btn_serupdate_Click_1(object sender, EventArgs e)
       {
            try
            {
                if (string.IsNullOrEmpty(cmb_branch.Text))
                {
                    lbl_eerrordis.Text = "Branch must be selected";
                }
                else if (string.IsNullOrEmpty(txt_sersn.Text))
                {
                    lbl_eerrordis.Text = "Service Name Field cannot be Blank";
                    txt_sersn.Focus();
                }
                else if (string.IsNullOrEmpty(cmb_sercategory.Text))
                {
                    lbl_eerrordis.Text = "Service Category must be selected";
                }
                else if (string.IsNullOrEmpty(txt_serduration.Text))
                {
                    lbl_eerrordis.Text = "Service Duration Field cannot be Blank";
                    txt_serduration.Focus();
                }
                else if (!Regex.IsMatch(txt_serduration.Text, @"^[0-9]+$"))
                {
                    lbl_eerrordis.Text = "Appointment ID Should contains Numbers Only.";
                }
                else if (string.IsNullOrEmpty(txt_sercharge.Text))
                {
                    lbl_eerrordis.Text = "Service Charge Field cannot be Blank";
                    txt_sercharge.Focus();
                }
                else if (!Regex.IsMatch(txt_sercharge.Text, @"^[0-9]+$"))
                {
                    lbl_eerrordis.Text = "Service Charge Field Has numbers Only";
                    txt_sercharge.Focus();
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("Update Salon_Services set Ser_Category='" + cmb_sercategory.Text + "', Duration_Minutes='" + txt_serduration.Text + "',Ser_Charge='" + txt_sercharge.Text + "' where Branch='" + cmb_branch.Text + "' AND Ser_Name='" + txt_sersn.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Your Data Successfully Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Data Can not be Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
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

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmb_serbranch.Text))
                {
                    lbl_deldisplayerror.Text = "Branch must be selected";
                }
                else if (string.IsNullOrEmpty(txt_sername.Text))
                {
                    lbl_deldisplayerror.Text = "Service Name Field cannot be Blank";
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from Salon_Services where Branch = '" + cmb_serbranch.Text + "' AND Ser_Name='" + txt_sername.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Your Data Successfully Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your Data Can not be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
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

        private void btn_cldel_Click(object sender, EventArgs e)
        {
            txt_sername.Clear();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Salon_Services", con);
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
            cmd = new SqlCommand("Select * from Salon_Services Where Branch='" + cmb_branchsearch.Text + "'", con);
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

