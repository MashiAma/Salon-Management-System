using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._4_practical1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double price, discount, net = 0;
            int quantity;
            try
            {
                
                price = Convert.ToDouble(txt_price.Text);
                discount = Convert.ToDouble(txt_discount.Text);
                quantity = Convert.ToInt32(txt_quantity.Text);

                if (price<= 0)
                {
                    MessageBox.Show("Price Can Not be Zero or Minus","Error");
                }
                else if(quantity<=0)
                {
                    MessageBox.Show("Quantity Can Not be Zero or Minus", "Error");
                }
                else if(discount<=0)
                {
                    MessageBox.Show("Discount Can Not be Zero or Minus", "Error");
                }
                else
                {
                    net = (price - (price * discount/100)) * quantity;
                    txt_bill.Text = net.ToString();
                    MessageBox.Show($"Net Bill Amount = {txt_bill.Text}");
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("You can enter numbers only","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
