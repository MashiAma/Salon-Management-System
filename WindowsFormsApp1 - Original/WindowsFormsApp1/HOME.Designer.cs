namespace WindowsFormsApp1
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.btn_hlogin = new System.Windows.Forms.Button();
            this.lbl_homemess = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_qrcode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hlogin
            // 
            this.btn_hlogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_hlogin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hlogin.ForeColor = System.Drawing.Color.Navy;
            this.btn_hlogin.Location = new System.Drawing.Point(383, 610);
            this.btn_hlogin.Name = "btn_hlogin";
            this.btn_hlogin.Size = new System.Drawing.Size(181, 33);
            this.btn_hlogin.TabIndex = 12;
            this.btn_hlogin.Text = "Go to Login";
            this.btn_hlogin.UseVisualStyleBackColor = false;
            this.btn_hlogin.Click += new System.EventHandler(this.btn_hlogin_Click);
            // 
            // lbl_homemess
            // 
            this.lbl_homemess.AutoSize = true;
            this.lbl_homemess.BackColor = System.Drawing.Color.White;
            this.lbl_homemess.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homemess.ForeColor = System.Drawing.Color.Navy;
            this.lbl_homemess.Location = new System.Drawing.Point(141, 60);
            this.lbl_homemess.Name = "lbl_homemess";
            this.lbl_homemess.Size = new System.Drawing.Size(0, 41);
            this.lbl_homemess.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(909, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pb_qrcode
            // 
            this.pb_qrcode.BackColor = System.Drawing.Color.White;
            this.pb_qrcode.Location = new System.Drawing.Point(662, 536);
            this.pb_qrcode.Name = "pb_qrcode";
            this.pb_qrcode.Size = new System.Drawing.Size(112, 107);
            this.pb_qrcode.TabIndex = 16;
            this.pb_qrcode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(804, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Powered by";
            // 
            // HOME
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_qrcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_homemess);
            this.Controls.Add(this.btn_hlogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(950, 650);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "HOME";
            this.Padding = new System.Windows.Forms.Padding(23, 83, 23, 28);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hlogin;
        private System.Windows.Forms.Label lbl_homemess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_qrcode;
        private System.Windows.Forms.Label label1;
    }
}

