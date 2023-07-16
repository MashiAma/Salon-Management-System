namespace WindowsFormsApp1
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ebranch = new System.Windows.Forms.ComboBox();
            this.expense_value = new System.Windows.Forms.NumericUpDown();
            this.lbl_displayerror = new System.Windows.Forms.Label();
            this.exp_date = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eupdate = new System.Windows.Forms.Button();
            this.btn_eadd = new System.Windows.Forms.Button();
            this.cmb_etype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_expid = new System.Windows.Forms.TextBox();
            this.lbl_heading1 = new System.Windows.Forms.Label();
            this.btn_eclear = new System.Windows.Forms.Button();
            this.cmb_branchsearch = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btn_searchbranch = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.lbl_heading3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.expense_value)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(163, 148);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(145, 23);
            this.txt_description.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Value";
            // 
            // cmb_ebranch
            // 
            this.cmb_ebranch.FormattingEnabled = true;
            this.cmb_ebranch.Items.AddRange(new object[] {
            "Gampaha",
            "Wattala",
            "Colombo"});
            this.cmb_ebranch.Location = new System.Drawing.Point(418, 69);
            this.cmb_ebranch.Name = "cmb_ebranch";
            this.cmb_ebranch.Size = new System.Drawing.Size(145, 23);
            this.cmb_ebranch.TabIndex = 11;
            // 
            // expense_value
            // 
            this.expense_value.Location = new System.Drawing.Point(418, 148);
            this.expense_value.Name = "expense_value";
            this.expense_value.Size = new System.Drawing.Size(145, 23);
            this.expense_value.TabIndex = 15;
            this.expense_value.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.expense_value.ValueChanged += new System.EventHandler(this.expense_value_ValueChanged);
            // 
            // lbl_displayerror
            // 
            this.lbl_displayerror.AutoSize = true;
            this.lbl_displayerror.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displayerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_displayerror.Location = new System.Drawing.Point(127, 45);
            this.lbl_displayerror.Name = "lbl_displayerror";
            this.lbl_displayerror.Size = new System.Drawing.Size(0, 19);
            this.lbl_displayerror.TabIndex = 17;
            // 
            // exp_date
            // 
            this.exp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.exp_date.Location = new System.Drawing.Point(418, 110);
            this.exp_date.MaxDate = new System.DateTime(2023, 3, 31, 0, 0, 0, 0);
            this.exp_date.MinDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.exp_date.Name = "exp_date";
            this.exp_date.Size = new System.Drawing.Size(145, 23);
            this.exp_date.TabIndex = 18;
            this.exp_date.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_eupdate);
            this.panel1.Controls.Add(this.btn_eadd);
            this.panel1.Controls.Add(this.cmb_etype);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_expid);
            this.panel1.Controls.Add(this.lbl_heading1);
            this.panel1.Controls.Add(this.btn_eclear);
            this.panel1.Controls.Add(this.exp_date);
            this.panel1.Controls.Add(this.lbl_displayerror);
            this.panel1.Controls.Add(this.expense_value);
            this.panel1.Controls.Add(this.cmb_ebranch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(300, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 247);
            this.panel1.TabIndex = 19;
            // 
            // btn_eupdate
            // 
            this.btn_eupdate.BackColor = System.Drawing.Color.DarkGray;
            this.btn_eupdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eupdate.Location = new System.Drawing.Point(268, 196);
            this.btn_eupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eupdate.Name = "btn_eupdate";
            this.btn_eupdate.Size = new System.Drawing.Size(100, 30);
            this.btn_eupdate.TabIndex = 221;
            this.btn_eupdate.Text = "Update";
            this.btn_eupdate.UseVisualStyleBackColor = false;
            this.btn_eupdate.Click += new System.EventHandler(this.btn_eupdate_Click);
            // 
            // btn_eadd
            // 
            this.btn_eadd.BackColor = System.Drawing.Color.DarkGray;
            this.btn_eadd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eadd.Location = new System.Drawing.Point(463, 196);
            this.btn_eadd.Name = "btn_eadd";
            this.btn_eadd.Size = new System.Drawing.Size(100, 30);
            this.btn_eadd.TabIndex = 217;
            this.btn_eadd.Text = "Add";
            this.btn_eadd.UseVisualStyleBackColor = false;
            this.btn_eadd.Click += new System.EventHandler(this.btn_eadd_Click_1);
            // 
            // cmb_etype
            // 
            this.cmb_etype.FormattingEnabled = true;
            this.cmb_etype.Items.AddRange(new object[] {
            "Rent",
            "Utilities",
            "Equipments",
            "Products",
            "Salary & Wages",
            "Other"});
            this.cmb_etype.Location = new System.Drawing.Point(163, 109);
            this.cmb_etype.Name = "cmb_etype";
            this.cmb_etype.Size = new System.Drawing.Size(145, 23);
            this.cmb_etype.TabIndex = 220;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "Id";
            // 
            // txt_expid
            // 
            this.txt_expid.Location = new System.Drawing.Point(163, 74);
            this.txt_expid.Name = "txt_expid";
            this.txt_expid.Size = new System.Drawing.Size(145, 23);
            this.txt_expid.TabIndex = 78;
            // 
            // lbl_heading1
            // 
            this.lbl_heading1.AutoSize = true;
            this.lbl_heading1.BackColor = System.Drawing.Color.Lavender;
            this.lbl_heading1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading1.Location = new System.Drawing.Point(0, 1);
            this.lbl_heading1.MaximumSize = new System.Drawing.Size(600, 30);
            this.lbl_heading1.MinimumSize = new System.Drawing.Size(600, 30);
            this.lbl_heading1.Name = "lbl_heading1";
            this.lbl_heading1.Size = new System.Drawing.Size(600, 30);
            this.lbl_heading1.TabIndex = 77;
            this.lbl_heading1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_eclear
            // 
            this.btn_eclear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_eclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eclear.Location = new System.Drawing.Point(72, 196);
            this.btn_eclear.Name = "btn_eclear";
            this.btn_eclear.Size = new System.Drawing.Size(100, 30);
            this.btn_eclear.TabIndex = 219;
            this.btn_eclear.Text = "Clear";
            this.btn_eclear.UseVisualStyleBackColor = false;
            this.btn_eclear.Click += new System.EventHandler(this.btn_eclear_Click);
            // 
            // cmb_branchsearch
            // 
            this.cmb_branchsearch.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_branchsearch.FormattingEnabled = true;
            this.cmb_branchsearch.Items.AddRange(new object[] {
            "Gampaha",
            "Wattala",
            "Colombo"});
            this.cmb_branchsearch.Location = new System.Drawing.Point(29, 401);
            this.cmb_branchsearch.Name = "cmb_branchsearch";
            this.cmb_branchsearch.Size = new System.Drawing.Size(120, 23);
            this.cmb_branchsearch.TabIndex = 216;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(26, 383);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(50, 15);
            this.lbl.TabIndex = 215;
            this.lbl.Text = "Branch";
            // 
            // btn_searchbranch
            // 
            this.btn_searchbranch.BackColor = System.Drawing.Color.DarkGray;
            this.btn_searchbranch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchbranch.Location = new System.Drawing.Point(157, 394);
            this.btn_searchbranch.Name = "btn_searchbranch";
            this.btn_searchbranch.Size = new System.Drawing.Size(90, 32);
            this.btn_searchbranch.TabIndex = 214;
            this.btn_searchbranch.Text = "Search";
            this.btn_searchbranch.UseVisualStyleBackColor = false;
            this.btn_searchbranch.Click += new System.EventHandler(this.btn_searchbranch_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.DarkGray;
            this.btn_view.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(29, 576);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(218, 35);
            this.btn_view.TabIndex = 213;
            this.btn_view.Text = "View All";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // lbl_heading3
            // 
            this.lbl_heading3.AutoSize = true;
            this.lbl_heading3.BackColor = System.Drawing.Color.Lavender;
            this.lbl_heading3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading3.Location = new System.Drawing.Point(258, 368);
            this.lbl_heading3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_heading3.MaximumSize = new System.Drawing.Size(650, 30);
            this.lbl_heading3.MinimumSize = new System.Drawing.Size(650, 30);
            this.lbl_heading3.Name = "lbl_heading3";
            this.lbl_heading3.Size = new System.Drawing.Size(650, 30);
            this.lbl_heading3.TabIndex = 212;
            this.lbl_heading3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(950, 70);
            this.panel3.MinimumSize = new System.Drawing.Size(950, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 70);
            this.panel3.TabIndex = 218;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SlateGray;
            this.label11.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(68, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 28);
            this.label11.TabIndex = 101;
            this.label11.Text = "Expenses";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_close.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(900, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(38, 36);
            this.btn_close.TabIndex = 98;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(29, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 210);
            this.panel2.TabIndex = 222;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 402);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 209);
            this.dataGridView1.TabIndex = 223;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 633);
            this.panel4.MaximumSize = new System.Drawing.Size(950, 20);
            this.panel4.MinimumSize = new System.Drawing.Size(950, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 20);
            this.panel4.TabIndex = 224;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmb_branchsearch);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_searchbranch);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.lbl_heading3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expense_value)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_ebranch;
        private System.Windows.Forms.NumericUpDown expense_value;
        private System.Windows.Forms.Label lbl_displayerror;
        private System.Windows.Forms.DateTimePicker exp_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_expid;
        private System.Windows.Forms.Label lbl_heading1;
        private System.Windows.Forms.ComboBox cmb_branchsearch;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn_searchbranch;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label lbl_heading3;
        private System.Windows.Forms.Button btn_eclear;
        private System.Windows.Forms.Button btn_eadd;
        private System.Windows.Forms.ComboBox cmb_etype;
        private System.Windows.Forms.Button btn_eupdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
    }
}