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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        private void MainPage_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
            lbl_displayheader.Text = "";
            DateTime currentTime = DateTime.Now;
            TimeSpan currentDayTime = currentTime.TimeOfDay;

            if (currentDayTime < new TimeSpan(12, 0, 0))
            {
                lbl_displayheader.Text = "Good Morning, Welcome to the Dashboard...!";
            }
            else
            {
                lbl_displayheader.Text = "Good Evening, Welcome to the Dashboard...!";
            }
            lbl_heading3.Text = "Current Month All Pending Bookings";
            panel_mpmanage.Width = 150;
            panel_mainicons.Height = 70;
            panel_Summary.Width = 150;
            showBooking();
            Income();

        }

        private void tile_manage_Click(object sender, EventArgs e)
        {
            if (panel_mpmanage.Width == 225)
            {
                panel_mpmanage.Width = 150;
            }
            else
            {
                panel_mpmanage.Width = 225;
            }
        }

        private void tile_mpcustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer r1 = new ManageCustomer();
            r1.Show();

        }
        private void tile_mpemployee_Click(object sender, EventArgs e)
        {
           CheckUser check1 = new CheckUser("EmployeeRegisterUpdate");
           check1.Show();
            
        }
       
        private void tile_appointment_Click(object sender, EventArgs e)
        {
            BookAppointment bookAppointment1 = new BookAppointment();
            bookAppointment1.ShowDialog();
        }

        private void tile_mpservices_Click(object sender, EventArgs e)
        {
            Salon_Services service1 = new Salon_Services();
            service1.ShowDialog();
        }    

        private void tile_mpincome_expense_Click(object sender, EventArgs e)
        {

            CheckUser check1 = new CheckUser("Expenses");
            check1.Show();
        }
        private void tile_mpinvoice_Click(object sender, EventArgs e)
        {
            InvoicePage invoice1 = new InvoicePage();
            invoice1.ShowDialog();
        }
        private void btn_user_Click(object sender, EventArgs e)
        {

            if (panel_mainicons.Height == 220)
            {
                panel_mainicons.Height = 70;
            }
            else
            {
                panel_mainicons.Height = 220;
            }
        }

        private void btn_newregister_Click(object sender, EventArgs e)
        {
            CheckUser check1 = new CheckUser("Signup");
            check1.Show();         
        }

        private void btn_newpassword_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword1= new ChangePassword();
            changepassword1.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            HOME home1= new HOME();
            home1.Show();
        }

        private void tile_mpsummary_Click(object sender, EventArgs e)
        {
            if (panel_Summary.Width == 225)
            {
                panel_Summary.Width = 150;
            }
            else
            {
                panel_Summary.Width = 225;
            }
        }

        private void subtile_reports_Click(object sender, EventArgs e)
        {
            ReportMain reportmain1= new ReportMain();
            reportmain1.Show();
        }

        private void subtile_charts_Click(object sender, EventArgs e)
        {
            Charts chart1= new Charts();
            chart1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void showBooking()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM Appointment WHERE Status_Update='Pending' AND MONTH(Appointment_Date) = MONTH( GETDATE())", con);
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public void Income()
        {
            DataTable dt = new DataTable();
            con.Open();
            da = new SqlDataAdapter("SELECT Incomes.Year1, Incomes.Month1, Income_Amount, Expense_Amount , Income_Amount - Expense_Amount AS Profit  FROM(select year(Expense_Date) as Year1, DATENAME(Month,Expense_Date) as Month1 ,sum(Amount) as Expense_Amount from Expenses group by year(Expense_Date), DATENAME(MONTH,Expense_Date)) Expense LEFT JOIN (select year(Appointment_Date) as Year1, DATENAME(Month,Appointment_Date) as Month1 , sum(Price) as Income_Amount from Appointment where Status_Update='Paid' group by year(Appointment_Date), DATENAME(MONTH,Appointment_Date) ) AS Incomes ON Expense.Year1 = Incomes.Year1 AND Expense.Month1= Incomes.Month1 ORDER BY Incomes.Year1, Incomes.Month1", con);
            da.Fill(dt);
            chart_finalincome.DataSource = dt;
            con.Close();

            chart_finalincome.Series["Profit"].XValueMember = "Month1";
            chart_finalincome.Series["Profit"].YValueMembers = "Profit";

            //chart formatting
            chart_finalincome.Series["Profit"].ChartType = SeriesChartType.Column;
            chart_finalincome.Legends[0].LegendStyle = LegendStyle.Table;
            chart_finalincome.Legends[0].Docking = Docking.Top;
            chart_finalincome.Legends[0].Alignment = StringAlignment.Center;
            chart_finalincome.Legends[0].Title = "Monthly Total Income";


        }
    }
}
