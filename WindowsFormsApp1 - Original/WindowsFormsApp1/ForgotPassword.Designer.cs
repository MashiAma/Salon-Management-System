namespace WindowsFormsApp1
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fpverify = new System.Windows.Forms.Button();
            this.txt_fpvercode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fpemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_fpsendemail = new System.Windows.Forms.Button();
            this.btn_fpback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forgot Your Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter your Email to send you a Verification code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(153, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 85);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_fpverify);
            this.panel1.Controls.Add(this.txt_fpvercode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_fpemail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_fpsendemail);
            this.panel1.Location = new System.Drawing.Point(68, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 209);
            this.panel1.TabIndex = 10;
            // 
            // btn_fpverify
            // 
            this.btn_fpverify.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_fpverify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fpverify.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fpverify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_fpverify.Location = new System.Drawing.Point(76, 165);
            this.btn_fpverify.Name = "btn_fpverify";
            this.btn_fpverify.Size = new System.Drawing.Size(80, 25);
            this.btn_fpverify.TabIndex = 5;
            this.btn_fpverify.Text = "Verify";
            this.btn_fpverify.UseVisualStyleBackColor = false;
            this.btn_fpverify.Click += new System.EventHandler(this.btn_fpverify_Click);
            // 
            // txt_fpvercode
            // 
            this.txt_fpvercode.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_fpvercode.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fpvercode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_fpvercode.Location = new System.Drawing.Point(18, 136);
            this.txt_fpvercode.Name = "txt_fpvercode";
            this.txt_fpvercode.Size = new System.Drawing.Size(201, 23);
            this.txt_fpvercode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Verification Code";
            // 
            // txt_fpemail
            // 
            this.txt_fpemail.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_fpemail.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fpemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_fpemail.Location = new System.Drawing.Point(18, 39);
            this.txt_fpemail.Name = "txt_fpemail";
            this.txt_fpemail.Size = new System.Drawing.Size(201, 23);
            this.txt_fpemail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Email Address";
            // 
            // btn_fpsendemail
            // 
            this.btn_fpsendemail.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_fpsendemail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fpsendemail.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fpsendemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_fpsendemail.Location = new System.Drawing.Point(76, 68);
            this.btn_fpsendemail.Name = "btn_fpsendemail";
            this.btn_fpsendemail.Size = new System.Drawing.Size(80, 25);
            this.btn_fpsendemail.TabIndex = 0;
            this.btn_fpsendemail.Text = "Send Email";
            this.btn_fpsendemail.UseVisualStyleBackColor = false;
            this.btn_fpsendemail.Click += new System.EventHandler(this.btn_fpsendemail_Click);
            // 
            // btn_fpback
            // 
            this.btn_fpback.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_fpback.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fpback.Location = new System.Drawing.Point(140, 406);
            this.btn_fpback.Name = "btn_fpback";
            this.btn_fpback.Size = new System.Drawing.Size(84, 30);
            this.btn_fpback.TabIndex = 6;
            this.btn_fpback.Text = "Back";
            this.btn_fpback.UseVisualStyleBackColor = false;
            this.btn_fpback.Click += new System.EventHandler(this.btn_fpback_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(332, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "X";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_fpback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(375, 450);
            this.MinimumSize = new System.Drawing.Size(375, 450);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fpverify;
        private System.Windows.Forms.TextBox txt_fpvercode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fpemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_fpsendemail;
        private System.Windows.Forms.Button btn_fpback;
        private System.Windows.Forms.Button button1;
    }
}