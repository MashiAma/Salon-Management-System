namespace WindowsFormsApp1
{
    partial class Login
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_meslogin = new System.Windows.Forms.Label();
            this.link_lback = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_lmessage = new System.Windows.Forms.Label();
            this.lbl_ldis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(400, 114);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 24;
            // 
            // lbl_meslogin
            // 
            this.lbl_meslogin.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_meslogin.AutoEllipsis = true;
            this.lbl_meslogin.AutoSize = true;
            this.lbl_meslogin.BackColor = System.Drawing.Color.Red;
            this.lbl_meslogin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meslogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_meslogin.Location = new System.Drawing.Point(125, 186);
            this.lbl_meslogin.Name = "lbl_meslogin";
            this.lbl_meslogin.Size = new System.Drawing.Size(0, 18);
            this.lbl_meslogin.TabIndex = 30;
            // 
            // link_lback
            // 
            this.link_lback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.link_lback.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.link_lback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.link_lback.Location = new System.Drawing.Point(23, 404);
            this.link_lback.Name = "link_lback";
            this.link_lback.Size = new System.Drawing.Size(75, 23);
            this.link_lback.Style = MetroFramework.MetroColorStyle.Black;
            this.link_lback.TabIndex = 30;
            this.link_lback.Text = "<<Back";
            this.link_lback.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.link_lback.UseCustomBackColor = true;
            this.link_lback.UseCustomForeColor = true;
            this.link_lback.UseMnemonic = false;
            this.link_lback.UseSelectable = true;
            this.link_lback.UseStyleColors = true;
            this.link_lback.Click += new System.EventHandler(this.link_slback_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(447, 204);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 34;
            // 
            // lbl_lmessage
            // 
            this.lbl_lmessage.AutoSize = true;
            this.lbl_lmessage.BackColor = System.Drawing.Color.Fuchsia;
            this.lbl_lmessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_lmessage.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lmessage.Location = new System.Drawing.Point(112, 382);
            this.lbl_lmessage.Name = "lbl_lmessage";
            this.lbl_lmessage.Size = new System.Drawing.Size(0, 15);
            this.lbl_lmessage.TabIndex = 42;
            this.lbl_lmessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ldis
            // 
            this.lbl_ldis.AutoSize = true;
            this.lbl_ldis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_ldis.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ldis.Location = new System.Drawing.Point(-1, 16);
            this.lbl_ldis.MaximumSize = new System.Drawing.Size(600, 60);
            this.lbl_ldis.MinimumSize = new System.Drawing.Size(600, 60);
            this.lbl_ldis.Name = "lbl_ldis";
            this.lbl_ldis.Size = new System.Drawing.Size(600, 60);
            this.lbl_ldis.TabIndex = 43;
            this.lbl_ldis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.girl_flower_face_pattern_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lbl_ldis);
            this.Controls.Add(this.lbl_lmessage);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.link_lback);
            this.Controls.Add(this.lbl_meslogin);
            this.Controls.Add(this.metroLabel3);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Movable = false;
            this.Name = "Login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Tag = "";
            this.Text = "                ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Staff_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label lbl_meslogin;
        private MetroFramework.Controls.MetroLink link_lback;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lbl_lmessage;
        private System.Windows.Forms.Label lbl_ldis;
    }
}