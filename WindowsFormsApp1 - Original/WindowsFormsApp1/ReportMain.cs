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
    public partial class ReportMain : Form
    {
        public ReportMain()
        {
            InitializeComponent();
        }

        private void ReportMain_Load(object sender, EventArgs e)
        {          

        }
        private void btn_appointmentSearch_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dataSetMain.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.dataSetMain.Appointment, cmb_branch1.Text, cmb_status1.Text, date_picker1.Text, date_picker2.Text);
            this.report_ViewAppointment.RefreshReport();
        }

        private void tab_repExpenses_Click(object sender, EventArgs e)
        {}

        private void btn_repEmployee_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMain.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dataSetMain.Employee, cmb_branch.Text, cmb_empStatus.Text);
            this.report_ViewEmployee.RefreshReport();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_repExpenses_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMain.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.dataSetMain.Expenses,cmb_branch2.Text,date_pickerexp1.Text,date_pickerexp2.Text);
            report_ViewExpenses.RefreshReport();
        }

        private void tab_repEmployee_Click(object sender, EventArgs e)
        {}

        private void tab_repAppointment_Click(object sender, EventArgs e)
        {

        }

    }
}
