using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WindowsFormsApp1
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;

        private void Charts_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-MPVS9TB;Initial Catalog=Salon;Integrated Security=True");
            EmployeeChart1();
            EmployeeChart2();
            IncomeChart();
            ExpensesChart();
            BookingChart();
        }

        
        public void EmployeeChart1()
        {
            DataTable dt = new DataTable();
            con.Open();
            da = new SqlDataAdapter("select Branch, Sum(Salary) as Branch_Total from Employee where Employee_Status = 'Active'group by Branch", con);
            da.Fill(dt);
            chart_branchTotal.DataSource = dt;
            con.Close();

            chart_branchTotal.Series["Branch_Total"].XValueMember = "Branch";
            chart_branchTotal.Series["Branch_Total"].YValueMembers = "Branch_Total";

            //chart formatting
            chart_branchTotal.Series["Branch_Total"].ChartType = SeriesChartType.Column;
            chart_branchTotal.Legends[0].LegendStyle = LegendStyle.Table;
            chart_branchTotal.Legends[0].Docking = Docking.Top;
            chart_branchTotal.Legends[0].Alignment = StringAlignment.Center;
            chart_branchTotal.Legends[0].Title = "Monthly Total Employee Salaries";


        }
        void EmployeeChart2()
        {
           
            DataTable dt = new DataTable();
            con.Open();
            da = new SqlDataAdapter("select Employee_Status, count(Employee_Id) as Employee_Count from Employee group by Employee_Status", con);
            da.Fill(dt);
            chartemployee_Count.DataSource = dt;
            con.Close();
            chartemployee_Count.Series["Employee_Count"].XValueMember = "Employee_Status";
            chartemployee_Count.Series["Employee_Count"].YValueMembers = "Employee_Count";

            //chart Formatting
            chartemployee_Count.Series["Employee_Count"].ChartType = SeriesChartType.Pie;
            chartemployee_Count.Legends[0].LegendStyle = LegendStyle.Table;
            chartemployee_Count.Legends[0].Docking = Docking.Top;
            chartemployee_Count.Legends[0].Alignment = StringAlignment.Center;
            chartemployee_Count.Legends[0].Title = "Active & Resign Employee Count";
            
        }
        void ExpensesChart()
        {

            DataTable dt = new DataTable();
            con.Open();
            da = new SqlDataAdapter("select year(Expense_Date) as Expense_Year,DATENAME(Month,Expense_Date) as Expense_Month ,sum(Amount) as Monthly_Expenses from Expenses group by year(Expense_Date), DATENAME(MONTH,Expense_Date) order by year(Expense_Date);", con);
            da.Fill(dt);
            chart_Expenses.DataSource = dt;
            con.Close();
            chart_Expenses.Series["Monthly_Expenses"].XValueMember = "Expense_Month";
            chart_Expenses.Series["Monthly_Expenses"].YValueMembers = "Monthly_Expenses";

            //chart Formatting
            chart_Expenses.Series["Monthly_Expenses"].ChartType = SeriesChartType.Line;
            chart_Expenses.Legends[0].LegendStyle = LegendStyle.Table;
            chart_Expenses.Legends[0].Docking = Docking.Top;
            chart_Expenses.Legends[0].Alignment = StringAlignment.Center;
            chart_Expenses.Legends[0].Title = "Current Year Monthly Expenses";

        }
        void IncomeChart()
        {

            DataTable dt = new DataTable();
            con.Open();
            da = new SqlDataAdapter("select year(Appointment_Date) as Appointment_Year,DATENAME(Month,Appointment_Date) as Appointment_Month ,sum(Price) as Monthly_Income from Appointment where Status_Update='Paid' group by year(Appointment_Date), DATENAME(MONTH,Appointment_Date) order by year(Appointment_Date)", con);
            da.Fill(dt);
            chart_monthlyIncome.DataSource = dt;
            con.Close();
            chart_monthlyIncome.Series["Monthly_Income"].XValueMember = "Appointment_Month";
            chart_monthlyIncome.Series["Monthly_Income"].YValueMembers = "Monthly_Income";

            //chart Formatting
            chart_monthlyIncome.Series["Monthly_Income"].ChartType = SeriesChartType.Line;
            chart_monthlyIncome.Legends[0].LegendStyle = LegendStyle.Table;
            chart_monthlyIncome.Legends[0].Docking = Docking.Top;
            chart_monthlyIncome.Legends[0].Alignment = StringAlignment.Center;
            chart_monthlyIncome.Legends[0].Title = "Current Year Monthly Income";

        }
        void BookingChart() 
        {
            DataTable dt = new DataTable();
            con.Open();
            da = new SqlDataAdapter("SELECT Branch, count(*) as Branch_Booking FROM Appointment WHERE Status_Update='Pending' AND MONTH(Appointment_Date) = MONTH( GETDATE()) GROUP BY Branch", con);
            da.Fill(dt);
            chart_bookingCount.DataSource = dt;
            con.Close();

            chart_bookingCount.Series["Branch_Booking"].XValueMember = "Branch";
            chart_bookingCount.Series["Branch_Booking"].YValueMembers = "Branch_Booking";

            //chart formatting
            chart_bookingCount.Series["Branch_Booking"].ChartType = SeriesChartType.Column;
            chart_bookingCount.Legends[0].LegendStyle = LegendStyle.Table;
            chart_bookingCount.Legends[0].Docking = Docking.Top;
            chart_bookingCount.Legends[0].Alignment = StringAlignment.Center;
            chart_bookingCount.Legends[0].Title = "Pending Booking Count of Branches";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
   
}
