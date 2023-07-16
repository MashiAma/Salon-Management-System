namespace WindowsFormsApp1
{
    partial class Signup
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
            System.Windows.Forms.Button btn_close;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_mesregister = new System.Windows.Forms.Label();
            this.txt_regpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_regusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_regconpass = new System.Windows.Forms.TextBox();
            this.txt_regemail = new System.Windows.Forms.TextBox();
            this.link_login = new System.Windows.Forms.LinkLabel();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = System.Drawing.Color.MediumTurquoise;
            btn_close.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_close.ForeColor = System.Drawing.Color.Black;
            btn_close.Location = new System.Drawing.Point(332, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new System.Drawing.Size(31, 29);
            btn_close.TabIndex = 71;
            btn_close.Text = "X";
            btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_close.UseMnemonic = false;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 82);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_mesregister
            // 
            this.lbl_mesregister.AutoSize = true;
            this.lbl_mesregister.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mesregister.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mesregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_mesregister.Location = new System.Drawing.Point(27, 324);
            this.lbl_mesregister.Name = "lbl_mesregister";
            this.lbl_mesregister.Size = new System.Drawing.Size(0, 17);
            this.lbl_mesregister.TabIndex = 60;
            // 
            // txt_regpass
            // 
            this.txt_regpass.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_regpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_regpass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_regpass.Location = new System.Drawing.Point(181, 163);
            this.txt_regpass.Name = "txt_regpass";
            this.txt_regpass.Size = new System.Drawing.Size(139, 16);
            this.txt_regpass.TabIndex = 59;
            this.txt_regpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 58;
            this.label3.Text = "Password : ";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txt_regusername
            // 
            this.txt_regusername.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt_regusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_regusername.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regusername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_regusername.Location = new System.Drawing.Point(181, 123);
            this.txt_regusername.Name = "txt_regusername";
            this.txt_regusername.Size = new System.Drawing.Size(139, 18);
            this.txt_regusername.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 56;
            this.label2.Text = "Username : ";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(92, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 62;
            this.label1.Text = "Register New User";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 50);
            this.label4.TabIndex = 64;
            this.label4.Text = "Confirm \r\nPassword : ";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(40, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "Email : ";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // txt_regconpass
            // 
            this.txt_regconpass.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_regconpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_regconpass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regconpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_regconpass.Location = new System.Drawing.Point(181, 209);
            this.txt_regconpass.Name = "txt_regconpass";
            this.txt_regconpass.Size = new System.Drawing.Size(139, 16);
            this.txt_regconpass.TabIndex = 66;
            this.txt_regconpass.UseSystemPasswordChar = true;
            // 
            // txt_regemail
            // 
            this.txt_regemail.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_regemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_regemail.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_regemail.Location = new System.Drawing.Point(181, 246);
            this.txt_regemail.Name = "txt_regemail";
            this.txt_regemail.Size = new System.Drawing.Size(139, 16);
            this.txt_regemail.TabIndex = 67;
            // 
            // link_login
            // 
            this.link_login.AutoSize = true;
            this.link_login.BackColor = System.Drawing.Color.Transparent;
            this.link_login.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.link_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_login.LinkColor = System.Drawing.Color.Black;
            this.link_login.Location = new System.Drawing.Point(393, 349);
            this.link_login.Name = "link_login";
            this.link_login.Size = new System.Drawing.Size(62, 24);
            this.link_login.TabIndex = 68;
            this.link_login.TabStop = true;
            this.link_login.Text = "Login";
            this.link_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_login_LinkClicked);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.White;
            this.btn_register.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_register.Location = new System.Drawing.Point(98, 382);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(186, 31);
            this.btn_register.TabIndex = 69;
            this.btn_register.Text = "Register";
            this.btn_register.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_register.UseMnemonic = false;
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_clear.Location = new System.Drawing.Point(257, 280);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(63, 30);
            this.btn_clear.TabIndex = 70;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.link_login);
            this.Controls.Add(this.txt_regemail);
            this.Controls.Add(this.txt_regconpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mesregister);
            this.Controls.Add(this.txt_regpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_regusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_mesregister;
        private System.Windows.Forms.TextBox txt_regpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_regusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_regconpass;
        private System.Windows.Forms.TextBox txt_regemail;
        private System.Windows.Forms.LinkLabel link_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_clear;
    }
}