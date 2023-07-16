namespace WindowsFormsApp1
{
    partial class ManageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_cregister = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cusregister = new System.Windows.Forms.Button();
            this.btn_cusupdate = new System.Windows.Forms.Button();
            this.btn_cusclear = new System.Windows.Forms.Button();
            this.lbl_heading1 = new System.Windows.Forms.Label();
            this.lbl_heading3 = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_cusdisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(119, 71);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 23);
            this.txt_id.TabIndex = 8;
            // 
            // lbl_cregister
            // 
            this.lbl_cregister.AutoEllipsis = true;
            this.lbl_cregister.AutoSize = true;
            this.lbl_cregister.BackColor = System.Drawing.Color.Snow;
            this.lbl_cregister.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cregister.ForeColor = System.Drawing.Color.Red;
            this.lbl_cregister.Location = new System.Drawing.Point(202, 39);
            this.lbl_cregister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cregister.Name = "lbl_cregister";
            this.lbl_cregister.Size = new System.Drawing.Size(0, 19);
            this.lbl_cregister.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 54;
            this.label13.Text = "Customer Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(379, 113);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(134, 23);
            this.txt_email.TabIndex = 20;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telephone.Location = new System.Drawing.Point(379, 71);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(134, 23);
            this.txt_telephone.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Telephone";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(119, 150);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(134, 23);
            this.txt_lname.TabIndex = 10;
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(119, 111);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(134, 23);
            this.txt_fname.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // btn_cusregister
            // 
            this.btn_cusregister.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cusregister.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusregister.ForeColor = System.Drawing.Color.Black;
            this.btn_cusregister.Location = new System.Drawing.Point(379, 200);
            this.btn_cusregister.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cusregister.Name = "btn_cusregister";
            this.btn_cusregister.Size = new System.Drawing.Size(100, 30);
            this.btn_cusregister.TabIndex = 86;
            this.btn_cusregister.Text = "Register";
            this.btn_cusregister.UseVisualStyleBackColor = false;
            this.btn_cusregister.Click += new System.EventHandler(this.btn_cusregister_Click);
            // 
            // btn_cusupdate
            // 
            this.btn_cusupdate.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cusupdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusupdate.ForeColor = System.Drawing.Color.Black;
            this.btn_cusupdate.Location = new System.Drawing.Point(214, 200);
            this.btn_cusupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cusupdate.Name = "btn_cusupdate";
            this.btn_cusupdate.Size = new System.Drawing.Size(100, 30);
            this.btn_cusupdate.TabIndex = 85;
            this.btn_cusupdate.Text = "Update";
            this.btn_cusupdate.UseVisualStyleBackColor = false;
            this.btn_cusupdate.Click += new System.EventHandler(this.btn_cusupdate_Click);
            // 
            // btn_cusclear
            // 
            this.btn_cusclear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cusclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusclear.ForeColor = System.Drawing.Color.Black;
            this.btn_cusclear.Location = new System.Drawing.Point(45, 200);
            this.btn_cusclear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cusclear.Name = "btn_cusclear";
            this.btn_cusclear.Size = new System.Drawing.Size(100, 30);
            this.btn_cusclear.TabIndex = 87;
            this.btn_cusclear.Text = "Clear";
            this.btn_cusclear.UseVisualStyleBackColor = false;
            this.btn_cusclear.Click += new System.EventHandler(this.btn_cusclear_Click);
            // 
            // lbl_heading1
            // 
            this.lbl_heading1.AutoSize = true;
            this.lbl_heading1.BackColor = System.Drawing.Color.Lavender;
            this.lbl_heading1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading1.Location = new System.Drawing.Point(-4, 0);
            this.lbl_heading1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_heading1.MinimumSize = new System.Drawing.Size(550, 30);
            this.lbl_heading1.Name = "lbl_heading1";
            this.lbl_heading1.Size = new System.Drawing.Size(550, 30);
            this.lbl_heading1.TabIndex = 88;
            this.lbl_heading1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_heading3
            // 
            this.lbl_heading3.AutoSize = true;
            this.lbl_heading3.BackColor = System.Drawing.Color.Lavender;
            this.lbl_heading3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading3.Location = new System.Drawing.Point(48, 340);
            this.lbl_heading3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_heading3.MaximumSize = new System.Drawing.Size(838, 30);
            this.lbl_heading3.MinimumSize = new System.Drawing.Size(838, 30);
            this.lbl_heading3.Name = "lbl_heading3";
            this.lbl_heading3.Size = new System.Drawing.Size(838, 30);
            this.lbl_heading3.TabIndex = 90;
            this.lbl_heading3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.DarkGray;
            this.btn_view.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_view.Location = new System.Drawing.Point(772, 573);
            this.btn_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(117, 32);
            this.btn_view.TabIndex = 92;
            this.btn_view.Text = "View All";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dob_picker
            // 
            this.dob_picker.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_picker.Location = new System.Drawing.Point(379, 150);
            this.dob_picker.Margin = new System.Windows.Forms.Padding(4);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.Size = new System.Drawing.Size(134, 23);
            this.dob_picker.TabIndex = 89;
            this.dob_picker.Value = new System.DateTime(2023, 3, 5, 20, 4, 22, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_cusregister);
            this.panel1.Controls.Add(this.btn_cusclear);
            this.panel1.Controls.Add(this.dob_picker);
            this.panel1.Controls.Add(this.btn_cusupdate);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.lbl_heading1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lbl_cregister);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_telephone);
            this.panel1.Controls.Add(this.txt_lname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_fname);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(343, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 240);
            this.panel1.TabIndex = 90;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(48, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 240);
            this.panel2.TabIndex = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(37, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_close.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(901, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 97;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(16, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_cusdisplay
            // 
            this.lbl_cusdisplay.AutoSize = true;
            this.lbl_cusdisplay.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_cusdisplay.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusdisplay.Location = new System.Drawing.Point(0, 0);
            this.lbl_cusdisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cusdisplay.MaximumSize = new System.Drawing.Size(950, 70);
            this.lbl_cusdisplay.MinimumSize = new System.Drawing.Size(950, 70);
            this.lbl_cusdisplay.Name = "lbl_cusdisplay";
            this.lbl_cusdisplay.Size = new System.Drawing.Size(950, 70);
            this.lbl_cusdisplay.TabIndex = 99;
            this.lbl_cusdisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_cusdisplay.Click += new System.EventHandler(this.lbl_cusdisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 100;
            this.label1.Text = "Manage Customer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Location = new System.Drawing.Point(0, 630);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 20);
            this.panel3.TabIndex = 101;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 193);
            this.dataGridView1.TabIndex = 102;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.lbl_heading3);
            this.Controls.Add(this.lbl_cusdisplay);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(950, 650);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "ManageCustomer";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 22);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Customer_SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_cregister;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cusregister;
        private System.Windows.Forms.Button btn_cusupdate;
        private System.Windows.Forms.Button btn_cusclear;
        private System.Windows.Forms.Label lbl_heading1;
        private System.Windows.Forms.Label lbl_heading3;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DateTimePicker dob_picker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_cusdisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}