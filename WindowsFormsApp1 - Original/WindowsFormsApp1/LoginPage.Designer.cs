namespace WindowsFormsApp1
{
    partial class LoginPage
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
            System.Windows.Forms.LinkLabel linklbl_forgotpass;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_logusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_logpassword = new System.Windows.Forms.TextBox();
            this.lbl_meslogin = new System.Windows.Forms.Label();
            this.btn_logclear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_lologin = new System.Windows.Forms.Button();
            this.cb_password = new System.Windows.Forms.CheckBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            linklbl_forgotpass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbl_forgotpass
            // 
            linklbl_forgotpass.AutoSize = true;
            linklbl_forgotpass.BackColor = System.Drawing.Color.Transparent;
            linklbl_forgotpass.DisabledLinkColor = System.Drawing.Color.Black;
            linklbl_forgotpass.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linklbl_forgotpass.ForeColor = System.Drawing.Color.Navy;
            linklbl_forgotpass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            linklbl_forgotpass.Location = new System.Drawing.Point(75, 392);
            linklbl_forgotpass.Name = "linklbl_forgotpass";
            linklbl_forgotpass.Size = new System.Drawing.Size(185, 25);
            linklbl_forgotpass.TabIndex = 50;
            linklbl_forgotpass.TabStop = true;
            linklbl_forgotpass.Text = "Forgot password?";
            linklbl_forgotpass.UseMnemonic = false;
            linklbl_forgotpass.VisitedLinkColor = System.Drawing.Color.Black;
            linklbl_forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_forgotpass_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(119, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login ";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(33, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Username : ";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txt_logusername
            // 
            this.txt_logusername.BackColor = System.Drawing.Color.White;
            this.txt_logusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_logusername.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_logusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_logusername.Location = new System.Drawing.Point(167, 148);
            this.txt_logusername.Name = "txt_logusername";
            this.txt_logusername.Size = new System.Drawing.Size(139, 18);
            this.txt_logusername.TabIndex = 28;
            this.txt_logusername.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password : ";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txt_logpassword
            // 
            this.txt_logpassword.BackColor = System.Drawing.Color.White;
            this.txt_logpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_logpassword.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_logpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_logpassword.Location = new System.Drawing.Point(167, 200);
            this.txt_logpassword.Name = "txt_logpassword";
            this.txt_logpassword.Size = new System.Drawing.Size(139, 15);
            this.txt_logpassword.TabIndex = 31;
            this.txt_logpassword.UseSystemPasswordChar = true;
            // 
            // lbl_meslogin
            // 
            this.lbl_meslogin.AutoSize = true;
            this.lbl_meslogin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_meslogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meslogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_meslogin.Location = new System.Drawing.Point(29, 263);
            this.lbl_meslogin.Name = "lbl_meslogin";
            this.lbl_meslogin.Size = new System.Drawing.Size(0, 19);
            this.lbl_meslogin.TabIndex = 51;
            // 
            // btn_logclear
            // 
            this.btn_logclear.BackColor = System.Drawing.Color.White;
            this.btn_logclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_logclear.Location = new System.Drawing.Point(2, 420);
            this.btn_logclear.Name = "btn_logclear";
            this.btn_logclear.Size = new System.Drawing.Size(59, 28);
            this.btn_logclear.TabIndex = 53;
            this.btn_logclear.Text = "Clear";
            this.btn_logclear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_logclear.UseMnemonic = false;
            this.btn_logclear.UseVisualStyleBackColor = false;
            this.btn_logclear.Click += new System.EventHandler(this.btn_logclear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // btn_lologin
            // 
            this.btn_lologin.BackColor = System.Drawing.Color.White;
            this.btn_lologin.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lologin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_lologin.Location = new System.Drawing.Point(80, 346);
            this.btn_lologin.Name = "btn_lologin";
            this.btn_lologin.Size = new System.Drawing.Size(180, 34);
            this.btn_lologin.TabIndex = 55;
            this.btn_lologin.Text = "Log In";
            this.btn_lologin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_lologin.UseMnemonic = false;
            this.btn_lologin.UseVisualStyleBackColor = false;
            this.btn_lologin.Click += new System.EventHandler(this.btn_lologin_Click);
            // 
            // cb_password
            // 
            this.cb_password.AutoSize = true;
            this.cb_password.BackColor = System.Drawing.Color.DodgerBlue;
            this.cb_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cb_password.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_password.ForeColor = System.Drawing.Color.Black;
            this.cb_password.Location = new System.Drawing.Point(167, 221);
            this.cb_password.Name = "cb_password";
            this.cb_password.Size = new System.Drawing.Size(119, 19);
            this.cb_password.TabIndex = 57;
            this.cb_password.Text = "                               ";
            this.cb_password.UseMnemonic = false;
            this.cb_password.UseVisualStyleBackColor = false;
            this.cb_password.CheckedChanged += new System.EventHandler(this.cb_password_CheckedChanged_1);
            // 
            // btn_close
            // 
            this.btn_close.AutoEllipsis = true;
            this.btn_close.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_close.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_close.Location = new System.Drawing.Point(311, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(27, 26);
            this.btn_close.TabIndex = 58;
            this.btn_close.Text = "X";
            this.btn_close.UseMnemonic = false;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(186, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Show Password";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cb_password);
            this.Controls.Add(this.btn_logclear);
            this.Controls.Add(this.btn_lologin);
            this.Controls.Add(this.txt_logpassword);
            this.Controls.Add(this.txt_logusername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_meslogin);
            this.Controls.Add(linklbl_forgotpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_meslogin;
        private System.Windows.Forms.Button btn_logclear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_lologin;
        private System.Windows.Forms.CheckBox cb_password;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.TextBox txt_logusername;
        private System.Windows.Forms.TextBox txt_logpassword;
        private System.Windows.Forms.Label label4;
    }
}