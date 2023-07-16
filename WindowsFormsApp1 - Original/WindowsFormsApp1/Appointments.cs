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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

                // Get the selected date from the event arguments.
                DateTime selectedDate = e.Start;

                // Do something with the selected date, such as update a label on the form.
                label1.Text = "Selected date: " + selectedDate.ToShortDateString();
            if(monthCalendar1.SelectionRange.Start <= e.Day.Date && e.Day.Date <= monthCalendar1.SelectionRange.End)
    {
                // Bold the current date.
                e.Cell.Font = new Font(e.Cell.Font, FontStyle.Bold);
                if (e.Start <= DateTime.Now)
                {
                    // Disable the "Book Now" button.
                    button1.Enabled = false;
                }
                else
                {
                    // Enable the "Book Now" button.
                    button1.Enabled = true;
                    DateTime selectedDate = monthCalendar1.SelectionStart;

                    // Get the user's name and contact information from the text boxes.
                    string name = textBox1.Text;
                    string contactInfo = textBox2.Text;

                    // Save the booking information to a database or other storage medium.
                    // For example, you might use a SQL INSERT statement to insert the data into a table.
                }
            }
    }
}
