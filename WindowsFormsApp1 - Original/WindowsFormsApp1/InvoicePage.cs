using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InvoicePage : Form
    {

        private bool isbuttonClicked = false;
        public InvoicePage()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvoicePage_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                using (cmd = new SqlCommand("Select Appointment_Date,Branch, Ser_Name, Start_Time,End_Time,Price,FirstName,LastName from Appointment, Customer where Appointment.Customer_Id=Customer.Customer_Id and Appointment_Id=@Appointment_Id", con))
                {
                    cmd.Parameters.AddWithValue("Appointment_Id", txt_invoice_appointmentid.Text);
                    using (SqlDataReader r1 = cmd.ExecuteReader())
                    {
                        if (r1.Read())
                        {
                            lbl_appdate.Text = r1["Appointment_Date"].ToString();
                            lbl_branch.Text = r1["Branch"].ToString();
                            lbl_serviceName.Text = r1["Ser_Name"].ToString();
                            lbl_starttime.Text = r1["Start_Time"].ToString();
                            lbl_endtime.Text = r1["End_Time"].ToString();
                            lbl_price.Text = r1["Price"].ToString();
                            lbl_total.Text = r1["Price"].ToString();
                            lbl_fname.Text = r1["FirstName"].ToString();
                            lbl_lname.Text = r1["LastName"].ToString();

                            isbuttonClicked = true;
                        }
                        else
                        {
                            MessageBox.Show("Appointment Not Found. Please Create a new Appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if(isbuttonClicked==true)
            {
                try
                {
                    lbl_appid.Text = txt_invoice_appointmentid.Text;
                    lbl_ptype.Text = cmb_paymenttype.Text;

                    if (string.IsNullOrEmpty(cmb_statusUpdate.Text))
                    {
                        MessageBox.Show("Status Update Should be Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(cmb_paymenttype.Text))
                    {
                        MessageBox.Show("Payment Type Should be Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("Update Appointment set Status_Update='" + cmb_statusUpdate.Text + "' where Appointment_Id='" + txt_invoice_appointmentid.Text + "'", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Appointment Status Successfully Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PrintScreen();
                            printPreviewDialog1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Appointment Status Can not be Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
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
            

        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void PrintScreen()
        {
            Graphics mygraphics = panel_print.CreateGraphics();
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("B5", 516, 729);
            Size s = panel_print.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, panel_print.ClientRectangle.Width, panel_print.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void panel_print_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
