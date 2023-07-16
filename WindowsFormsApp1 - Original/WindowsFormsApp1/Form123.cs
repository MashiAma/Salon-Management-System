using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gad_project_1
{
    public partial class t : MetroFramework.Forms.MetroForm
    {
        public t()
        {
            InitializeComponent();
        }
        SqlConnection c0n = new SqlConnection(@"");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            string sle_cb = "";
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox b && b.Checked)
                {
                    sle_cb = sle_cb + b.Text + ",";
                }
            }
            if (!string.IsNullOrEmpty(sle_cb))
            {
                sle_cb = sle_cb.TrimEnd(',', ' ');
                //MessageBox.Show($"Selected CheckBox {sle_cb}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show( sle_cb);
            }
            else
            {
                MessageBox.Show("No Features Selected");
            }

            //b.Checked = Capture;
            /*CheckBox b = (CheckBox)c;
            if (b.Checked)
            {
                //s = b.Text + s;
                s = b.Text + "," + s;
            }
            */



        }
        //MessageBox.Show($"hi{s}");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cb_fm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cb_hm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // t
            // 
            this.ClientSize = new System.Drawing.Size(668, 300);
            this.Name = "t";
            this.Load += new System.EventHandler(this.t_Load);
            this.ResumeLayout(false);

        }

        private void t_Load(object sender, EventArgs e)
        {

        }
    }
}
    

