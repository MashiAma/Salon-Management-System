using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_homemess.Text = "Queen Beauty Salon Management System";
            QRCodeGenerator qrcode= new QRCodeGenerator();
            QRCodeData data = qrcode.CreateQrCode("www.softwaresuggest.com",QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pb_qrcode.Image = code.GetGraphic(3);
          
        }
        private void btn_hlogin_Click(object sender, EventArgs e)
        {
            //this is the first run             
            LoginPage login1 = new LoginPage();
            login1.Show();           

            //Invoice invo= new Invoice();
            //invo.Show();
            //Charts c1= new Charts();
            //c1.Show();  
            //ManageCustomer c1 = new ManageCustomer();
            //c1.Show();
            //EmployeeRegisterUpdate e1= new EmployeeRegisterUpdate();
            //e1.Show();

            //Salon_Services s1 = new Salon_Services();   
            //s1.Show();
            //BookAppointment a1 = new BookAppointment();
            //a1.Show();
            //MainPage m1= new MainPage();
            //m1.Show();

            //Expenses h1 = new Expenses();
            //h1.Show();
            //EmployeeReport r1= new EmployeeReport();    
            //r1.Show();
            //ExpensesReport rep1=new ExpensesReport();
            //rep1.Show();
            //ReportMain r1= new ReportMain();
            //r1.Show();
            //InvoicePage invoice1 = new InvoicePage();
            //invoice1.Show();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
