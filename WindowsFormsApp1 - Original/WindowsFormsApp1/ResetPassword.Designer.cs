namespace WindowsFormsApp1
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.btn_rpback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_rpusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rpreset = new System.Windows.Forms.Button();
            this.txt_rpconpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rpnewpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rplogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rpback
            // 
            this.btn_rpback.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_rpback.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rpback.Location = new System.Drawing.Point(9, 411);
            this.btn_rpback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rpback.Name = "btn_rpback";
            this.btn_rpback.Size = new System.Drawing.Size(88, 27);
            this.btn_rpback.TabIndex = 14;
            this.btn_rpback.Text = "Back";
            this.btn_rpback.UseVisualStyleBackColor = false;
            this.btn_rpback.Click += new System.EventHandler(this.btn_rpback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_rpusername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_rpreset);
            this.panel1.Controls.Add(this.txt_rpconpassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_rpnewpassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(72, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 261);
            this.panel1.TabIndex = 16;
            // 
            // txt_rpusername
            // 
            this.txt_rpusername.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_rpusername.Location = new System.Drawing.Point(21, 45);
            this.txt_rpusername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_rpusername.Name = "txt_rpusername";
            this.txt_rpusername.Size = new System.Drawing.Size(186, 23);
            this.txt_rpusername.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Your Username";
            // 
            // btn_rpreset
            // 
            this.btn_rpreset.BackColor = System.Drawing.Color.Salmon;
            this.btn_rpreset.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rpreset.Location = new System.Drawing.Point(64, 218);
            this.btn_rpreset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rpreset.Name = "btn_rpreset";
            this.btn_rpreset.Size = new System.Drawing.Size(88, 27);
            this.btn_rpreset.TabIndex = 5;
            this.btn_rpreset.Text = "Reset";
            this.btn_rpreset.UseVisualStyleBackColor = false;
            this.btn_rpreset.Click += new System.EventHandler(this.btn_rpreset_Click);
            // 
            // txt_rpconpassword
            // 
            this.txt_rpconpassword.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_rpconpassword.Location = new System.Drawing.Point(21, 170);
            this.txt_rpconpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_rpconpassword.Name = "txt_rpconpassword";
            this.txt_rpconpassword.Size = new System.Drawing.Size(186, 23);
            this.txt_rpconpassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Confirm Password";
            // 
            // txt_rpnewpassword
            // 
            this.txt_rpnewpassword.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_rpnewpassword.Location = new System.Drawing.Point(21, 108);
            this.txt_rpnewpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_rpnewpassword.Name = "txt_rpnewpassword";
            this.txt_rpnewpassword.Size = new System.Drawing.Size(186, 23);
            this.txt_rpnewpassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reset Password";
            // 
            // btn_rplogin
            // 
            this.btn_rplogin.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_rplogin.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rplogin.Location = new System.Drawing.Point(274, 411);
            this.btn_rplogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rplogin.Name = "btn_rplogin";
            this.btn_rplogin.Size = new System.Drawing.Size(88, 27);
            this.btn_rplogin.TabIndex = 17;
            this.btn_rplogin.Text = "Login";
            this.btn_rplogin.UseVisualStyleBackColor = false;
            this.btn_rplogin.Click += new System.EventHandler(this.btn_rplogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(154, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 58);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 85);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(341, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "X";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_rplogin);
            this.Controls.Add(this.btn_rpback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rpback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_rpreset;
        private System.Windows.Forms.TextBox txt_rpconpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rpnewpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rplogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_rpusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}