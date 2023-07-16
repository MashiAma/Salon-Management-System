namespace WindowsFormsApp1
{
    partial class Appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tab_services = new System.Windows.Forms.TabPage();
            this.tab_customer = new System.Windows.Forms.TabPage();
            this.tab_confirmation = new System.Windows.Forms.TabPage();
            this.tab_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tab_services);
            this.tab_main.Controls.Add(this.tab_customer);
            this.tab_main.Controls.Add(this.tab_confirmation);
            this.tab_main.Location = new System.Drawing.Point(150, 62);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(469, 258);
            this.tab_main.TabIndex = 0;
            // 
            // tab_services
            // 
            this.tab_services.BackColor = System.Drawing.Color.Gray;
            this.tab_services.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_services.Location = new System.Drawing.Point(4, 22);
            this.tab_services.Name = "tab_services";
            this.tab_services.Padding = new System.Windows.Forms.Padding(3);
            this.tab_services.Size = new System.Drawing.Size(461, 232);
            this.tab_services.TabIndex = 0;
            this.tab_services.Text = "Services                          ";
            // 
            // tab_customer
            // 
            this.tab_customer.Location = new System.Drawing.Point(4, 22);
            this.tab_customer.Name = "tab_customer";
            this.tab_customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_customer.Size = new System.Drawing.Size(461, 232);
            this.tab_customer.TabIndex = 1;
            this.tab_customer.Text = "Customer                          ";
            this.tab_customer.UseVisualStyleBackColor = true;
            // 
            // tab_confirmation
            // 
            this.tab_confirmation.Location = new System.Drawing.Point(4, 22);
            this.tab_confirmation.Name = "tab_confirmation";
            this.tab_confirmation.Padding = new System.Windows.Forms.Padding(3);
            this.tab_confirmation.Size = new System.Drawing.Size(461, 232);
            this.tab_confirmation.TabIndex = 2;
            this.tab_confirmation.Text = "Confirmation                    ";
            this.tab_confirmation.UseVisualStyleBackColor = true;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_main);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.tab_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tab_services;
        private System.Windows.Forms.TabPage tab_customer;
        private System.Windows.Forms.TabPage tab_confirmation;
    }
}