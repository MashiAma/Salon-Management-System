namespace WindowsFormsApp1
{
    partial class Customer_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Login));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cllogin = new MetroFramework.Controls.MetroButton();
            this.txt_clusername = new System.Windows.Forms.TextBox();
            this.txt_clpassword = new System.Windows.Forms.TextBox();
            this.link_clnext = new MetroFramework.Controls.MetroLink();
            this.link_clback = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(367, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password : ";
            // 
            // btn_cllogin
            // 
            this.btn_cllogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cllogin.BackgroundImage")));
            this.btn_cllogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cllogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cllogin.Location = new System.Drawing.Point(267, 261);
            this.btn_cllogin.Name = "btn_cllogin";
            this.btn_cllogin.Size = new System.Drawing.Size(117, 52);
            this.btn_cllogin.TabIndex = 23;
            this.btn_cllogin.UseSelectable = true;
            this.btn_cllogin.Click += new System.EventHandler(this.btn_cllogin_Click);
            // 
            // txt_clusername
            // 
            this.txt_clusername.Location = new System.Drawing.Point(267, 97);
            this.txt_clusername.Name = "txt_clusername";
            this.txt_clusername.Size = new System.Drawing.Size(100, 20);
            this.txt_clusername.TabIndex = 21;
            // 
            // txt_clpassword
            // 
            this.txt_clpassword.Location = new System.Drawing.Point(267, 172);
            this.txt_clpassword.Name = "txt_clpassword";
            this.txt_clpassword.Size = new System.Drawing.Size(100, 20);
            this.txt_clpassword.TabIndex = 22;
            // 
            // link_clnext
            // 
            this.link_clnext.Location = new System.Drawing.Point(499, 26);
            this.link_clnext.Name = "link_clnext";
            this.link_clnext.Size = new System.Drawing.Size(75, 23);
            this.link_clnext.TabIndex = 35;
            this.link_clnext.Text = "Next>>";
            this.link_clnext.UseSelectable = true;
            this.link_clnext.Click += new System.EventHandler(this.link_clnext_Click);
            // 
            // link_clback
            // 
            this.link_clback.Location = new System.Drawing.Point(367, 26);
            this.link_clback.Name = "link_clback";
            this.link_clback.Size = new System.Drawing.Size(75, 23);
            this.link_clback.TabIndex = 34;
            this.link_clback.Text = "<<Back";
            this.link_clback.UseSelectable = true;
            this.link_clback.Click += new System.EventHandler(this.link_clback_Click);
            // 
            // Customer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.link_clnext);
            this.Controls.Add(this.link_clback);
            this.Controls.Add(this.btn_cllogin);
            this.Controls.Add(this.txt_clpassword);
            this.Controls.Add(this.txt_clusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel3);
            this.Name = "Customer_Login";
            this.Text = "Customer_Login";
            this.Load += new System.EventHandler(this.Customer_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btn_cllogin;
        private System.Windows.Forms.TextBox txt_clusername;
        private System.Windows.Forms.TextBox txt_clpassword;
        private MetroFramework.Controls.MetroLink link_clnext;
        private MetroFramework.Controls.MetroLink link_clback;
    }
}