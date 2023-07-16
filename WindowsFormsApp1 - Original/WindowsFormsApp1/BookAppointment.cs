using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WindowsFormsApp1
{
    public partial class BookAppointment : Form
    {
        public BookAppointment()
        {
            InitializeComponent();
        }

        private DateTimePicker timePicker;

        private void InitializeTimePicker()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(10, 10);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void BookAppointment_Load(object sender, EventArgs e) //Form Load Event
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
            lbl_heading1.Text = "Create Booking";
            lbl_heading2.Text = "Update Booking Status";
            lbl_heading3.Text = "All Bookings";
            tab_main.SelectedTab = tab_service;

        }

        //Tab Control Event
        private void tab_service_Click(object sender, EventArgs e)
        {
            
        } 

        //Services Tab all controls
        private void cmb_selectservice_SelectedIndexChanged(object sender, EventArgs e) 
        { }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try 
            {            
                    con.Open();
                    da = new SqlDataAdapter("Select Ser_name, Start_Time, End_Time, Status_Update from Appointment Where Branch='" + cmb_branchservice.Text + "' and Appointment_Date='" + dob_picker1.Value + "' and Status_Update!='Canceled'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_gmpbranch.DataSource = dt;
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
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_selectservice.Text))
            {
                MessageBox.Show("Service Field cannot be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tab_main.SelectedTab = tab_customer;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void cmb_branchservice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_selectservice.Items.Clear();
                con.Open();
                using (cmd = new SqlCommand("Select Ser_Name from Salon_Services Where Branch=@Branch", con))
                {
                    cmd.Parameters.AddWithValue("@Branch", cmb_branchservice.Text);
                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                        while (dr.Read())                       
                        {
                            cmb_selectservice.Items.Add(dr["Ser_Name"].ToString()); 
                        }
                }
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


        //Customer tab all controls
        private void btn_csearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                using (cmd = new SqlCommand("Select FirstName, LastName, Email, Customer_Id From Customer Where Telephone= @Telephone", con))
                {
                    cmd.Parameters.AddWithValue("Telephone", txt_telephone.Text);
                    
                    using (SqlDataReader r1 = cmd.ExecuteReader())
                    {
                        if (r1.Read())
                        {
                            txt_id.Text = r1["Customer_Id"].ToString();
                            txt_fname.Text = r1["FirstName"].ToString();
                            txt_lname.Text = r1["LastName"].ToString();
                            txt_email.Text = r1["Email"].ToString();                   
                        }
                        else
                        {
                             MessageBox.Show("Cutomer Not Found. Please Register Customer to the System.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    con.Close();
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

        private void lklbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageCustomer m1 = new ManageCustomer();
            m1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //next button of the customer tab
        {           
           tab_main.SelectedTab = tab_confirmation;        
        }

        private void btn_cback_Click(object sender, EventArgs e)//back to previous page botton of the customer page
        {
            tab_main.SelectedTab = tab_service;
        }

        private void btn_cclear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_telephone.Clear();
            txt_id.Clear();
            txt_email.Clear();
        }
       
        //all tab control related to confirmation tab
        private void tab_confirmation_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                using (cmd = new SqlCommand("SELECT MAX(Appointment_Id)+1 as Appointment_Id FROM Appointment", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        txt_appointmentid.Text = dr["Appointment_Id"].ToString();
                    }
                }


                using (cmd = new SqlCommand("Select * from Salon_Services Where Branch= @Branch and Ser_Name=@Ser_Name", con))
                {
                    cmd.Parameters.AddWithValue("@Branch", cmb_branchservice.Text);
                    cmd.Parameters.AddWithValue("@Ser_Name", cmb_selectservice.Text);
                    txt_cservice.Text = cmb_selectservice.SelectedItem.ToString();
                    dob_pickercon.Value = dob_picker1.Value;
                                    

                    using (SqlDataReader r1 = cmd.ExecuteReader())
                    {
                        if (r1.Read())
                        {
                            txt_cprice.Text = r1["Ser_Charge"].ToString();
                            txt_cduration.Text = r1["Duration_Minutes"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Details Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
                con.Close();
            }

            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Service Type Field of Service Tab can not be blank", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btn_createbooking_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
                cmd = new SqlCommand("Insert into Appointment values ('" + txt_appointmentid.Text + "','" + txt_id.Text + "', '" + txt_cservice.Text + "', '" + cmb_branchservice.Text + "','" + dob_pickercon.Value + "','" + booking_starttime.Value + "','" + booking_endtime.Value + "', '" + txt_cprice.Text + "','"+ cmb_status.Text+"') ", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("You Have Successfully Book an Appointment.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }
                else
                    MessageBox.Show("Your booking is not Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Errors", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                con.Close();
        }

        private void btn_conclear_Click(object sender, EventArgs e)
        {
            txt_appointmentid.Clear();
            txt_cduration.Clear();
            txt_cservice.Clear();
            txt_cprice.Clear();
        }

        private void btn_conback_Click(object sender, EventArgs e)
        {
            tab_main.SelectedTab = tab_customer;
        }

        private void booking_starttime_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker timePicker = new DateTimePicker();
            timePicker.Value = booking_starttime.Value;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
           
        }

        private void booking_endtime_ValueChanged(object sender, EventArgs e)
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
        }
        //This is Booking status updation form
        private void btn_appclear_Click(object sender, EventArgs e)
        {
            txt_appoinid.Clear();
        }

        private void btn_appupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_appoinid.Text))
                {
                    lbl_displayupdate.Text = "Appointment ID Should \nbe Filled";
                }
                else if (!Regex.IsMatch(txt_appoinid.Text, @"^[0-9]+$"))
                {
                    lbl_displayupdate.Text = "Appointment ID Should \n contains Numbers Only.";
                }
                else if (string.IsNullOrEmpty(cmb_updatestatus.Text))
                {
                    lbl_displayupdate.Text = "Update Status Should \n be Selected";
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("Update Appointment set Status_Update='" + cmb_updatestatus.Text + "' where Appointment_Id='" + txt_appoinid.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Appointment Status Successfully Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Appointment Status Can not be Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_searchbranch_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Appointment Where Branch='" + cmb_branchsearch.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Appointment ", con);
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_printInvoice_Click(object sender, EventArgs e)
        {
            InvoicePage invoice1= new InvoicePage();
            invoice1.txt_invoice_appointmentid.Text= txt_appointmentid.Text;
            this.Close();  
            invoice1.ShowDialog();

        }
    }
    
}
