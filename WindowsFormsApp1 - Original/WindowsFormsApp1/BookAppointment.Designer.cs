namespace WindowsFormsApp1
{
    partial class BookAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAppointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_main = new MetroFramework.Controls.MetroTabControl();
            this.tab_service = new MetroFramework.Controls.MetroTabPage();
            this.dob_picker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_selectservice = new System.Windows.Forms.ComboBox();
            this.cmb_branchservice = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.dgv_gmpbranch = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_customer = new MetroFramework.Controls.MetroTabPage();
            this.btn_cclear = new System.Windows.Forms.Button();
            this.btn_cback = new System.Windows.Forms.Button();
            this.btn_cnext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lklbl_register = new System.Windows.Forms.LinkLabel();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_csearch = new System.Windows.Forms.Button();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_confirmation = new MetroFramework.Controls.MetroTabPage();
            this.btn_printInvoice = new System.Windows.Forms.Button();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_cduration = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.booking_endtime = new System.Windows.Forms.DateTimePicker();
            this.booking_starttime = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dob_pickercon = new System.Windows.Forms.DateTimePicker();
            this.txt_appointmentid = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.Label();
            this.btn_createbooking = new System.Windows.Forms.Button();
            this.btn_conback = new System.Windows.Forms.Button();
            this.btn_conclear = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cprice = new System.Windows.Forms.TextBox();
            this.txt_cservice = new System.Windows.Forms.TextBox();
            this.lbl_heading1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_displayupdate = new System.Windows.Forms.Label();
            this.cmb_updatestatus = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_heading2 = new System.Windows.Forms.Label();
            this.btn_appclear = new System.Windows.Forms.Button();
            this.btn_appupdate = new System.Windows.Forms.Button();
            this.txt_appoinid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_branchsearch = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btn_searchbranch = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_heading3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_main.SuspendLayout();
            this.tab_service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gmpbranch)).BeginInit();
            this.tab_customer.SuspendLayout();
            this.tab_confirmation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tab_service);
            this.tab_main.Controls.Add(this.tab_customer);
            this.tab_main.Controls.Add(this.tab_confirmation);
            this.tab_main.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tab_main.ItemSize = new System.Drawing.Size(200, 40);
            this.tab_main.Location = new System.Drawing.Point(201, 103);
            this.tab_main.Margin = new System.Windows.Forms.Padding(6);
            this.tab_main.MaximumSize = new System.Drawing.Size(492, 298);
            this.tab_main.MinimumSize = new System.Drawing.Size(492, 298);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 2;
            this.tab_main.Size = new System.Drawing.Size(492, 298);
            this.tab_main.TabIndex = 100;
            this.tab_main.TabStop = false;
            this.tab_main.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tab_main.UseCustomBackColor = true;
            this.tab_main.UseCustomForeColor = true;
            this.tab_main.UseSelectable = true;
            this.tab_main.UseStyleColors = true;
            // 
            // tab_service
            // 
            this.tab_service.BackColor = System.Drawing.Color.White;
            this.tab_service.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab_service.Controls.Add(this.dob_picker1);
            this.tab_service.Controls.Add(this.label15);
            this.tab_service.Controls.Add(this.label7);
            this.tab_service.Controls.Add(this.cmb_selectservice);
            this.tab_service.Controls.Add(this.cmb_branchservice);
            this.tab_service.Controls.Add(this.btn_close);
            this.tab_service.Controls.Add(this.btn_next);
            this.tab_service.Controls.Add(this.dgv_gmpbranch);
            this.tab_service.Controls.Add(this.btn_search);
            this.tab_service.Controls.Add(this.label1);
            this.tab_service.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_service.ForeColor = System.Drawing.Color.Black;
            this.tab_service.HorizontalScrollbarBarColor = true;
            this.tab_service.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_service.HorizontalScrollbarSize = 1;
            this.tab_service.Location = new System.Drawing.Point(4, 44);
            this.tab_service.Margin = new System.Windows.Forms.Padding(6);
            this.tab_service.Name = "tab_service";
            this.tab_service.Size = new System.Drawing.Size(484, 250);
            this.tab_service.TabIndex = 1;
            this.tab_service.Text = "Services                    ";
            this.tab_service.UseCustomBackColor = true;
            this.tab_service.UseCustomForeColor = true;
            this.tab_service.UseStyleColors = true;
            this.tab_service.VerticalScrollbarBarColor = true;
            this.tab_service.VerticalScrollbarHighlightOnWheel = false;
            this.tab_service.VerticalScrollbarSize = 1;
            this.tab_service.Click += new System.EventHandler(this.tab_service_Click);
            // 
            // dob_picker1
            // 
            this.dob_picker1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_picker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_picker1.Location = new System.Drawing.Point(258, 8);
            this.dob_picker1.Margin = new System.Windows.Forms.Padding(6);
            this.dob_picker1.Name = "dob_picker1";
            this.dob_picker1.RightToLeftLayout = true;
            this.dob_picker1.Size = new System.Drawing.Size(102, 23);
            this.dob_picker1.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(198, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 30);
            this.label15.TabIndex = 63;
            this.label15.Text = "Booking \r\nDate";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select \r\nBranch";
            // 
            // cmb_selectservice
            // 
            this.cmb_selectservice.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_selectservice.FormattingEnabled = true;
            this.cmb_selectservice.Location = new System.Drawing.Point(165, 177);
            this.cmb_selectservice.Margin = new System.Windows.Forms.Padding(6);
            this.cmb_selectservice.Name = "cmb_selectservice";
            this.cmb_selectservice.Size = new System.Drawing.Size(302, 23);
            this.cmb_selectservice.TabIndex = 10;
            this.cmb_selectservice.SelectedIndexChanged += new System.EventHandler(this.cmb_selectservice_SelectedIndexChanged);
            // 
            // cmb_branchservice
            // 
            this.cmb_branchservice.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_branchservice.FormattingEnabled = true;
            this.cmb_branchservice.Items.AddRange(new object[] {
            "Gampaha",
            "Wattala",
            "Colombo"});
            this.cmb_branchservice.Location = new System.Drawing.Point(60, 9);
            this.cmb_branchservice.Margin = new System.Windows.Forms.Padding(6);
            this.cmb_branchservice.Name = "cmb_branchservice";
            this.cmb_branchservice.Size = new System.Drawing.Size(112, 23);
            this.cmb_branchservice.TabIndex = 9;
            this.cmb_branchservice.SelectedIndexChanged += new System.EventHandler(this.cmb_branchservice_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.DarkGray;
            this.btn_close.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(15, 217);
            this.btn_close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 30);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Back";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.DarkGray;
            this.btn_next.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(366, 217);
            this.btn_next.Margin = new System.Windows.Forms.Padding(6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 30);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // dgv_gmpbranch
            // 
            this.dgv_gmpbranch.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv_gmpbranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gmpbranch.Location = new System.Drawing.Point(24, 66);
            this.dgv_gmpbranch.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_gmpbranch.Name = "dgv_gmpbranch";
            this.dgv_gmpbranch.Size = new System.Drawing.Size(442, 105);
            this.dgv_gmpbranch.TabIndex = 6;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkGray;
            this.btn_search.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(379, 6);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 30);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search All";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Service";
            // 
            // tab_customer
            // 
            this.tab_customer.Controls.Add(this.btn_cclear);
            this.tab_customer.Controls.Add(this.btn_cback);
            this.tab_customer.Controls.Add(this.btn_cnext);
            this.tab_customer.Controls.Add(this.label5);
            this.tab_customer.Controls.Add(this.lklbl_register);
            this.tab_customer.Controls.Add(this.txt_telephone);
            this.tab_customer.Controls.Add(this.label9);
            this.tab_customer.Controls.Add(this.txt_email);
            this.tab_customer.Controls.Add(this.btn_csearch);
            this.tab_customer.Controls.Add(this.txt_lname);
            this.tab_customer.Controls.Add(this.label4);
            this.tab_customer.Controls.Add(this.txt_fname);
            this.tab_customer.Controls.Add(this.label2);
            this.tab_customer.Controls.Add(this.txt_id);
            this.tab_customer.Controls.Add(this.label13);
            this.tab_customer.Controls.Add(this.label3);
            this.tab_customer.HorizontalScrollbarBarColor = true;
            this.tab_customer.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_customer.HorizontalScrollbarSize = 1;
            this.tab_customer.Location = new System.Drawing.Point(4, 44);
            this.tab_customer.Margin = new System.Windows.Forms.Padding(6);
            this.tab_customer.Name = "tab_customer";
            this.tab_customer.Size = new System.Drawing.Size(484, 250);
            this.tab_customer.TabIndex = 2;
            this.tab_customer.Text = "Customer                        ";
            this.tab_customer.VerticalScrollbarBarColor = true;
            this.tab_customer.VerticalScrollbarHighlightOnWheel = false;
            this.tab_customer.VerticalScrollbarSize = 1;
            // 
            // btn_cclear
            // 
            this.btn_cclear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cclear.Location = new System.Drawing.Point(366, 6);
            this.btn_cclear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cclear.Name = "btn_cclear";
            this.btn_cclear.Size = new System.Drawing.Size(100, 30);
            this.btn_cclear.TabIndex = 75;
            this.btn_cclear.Text = "Clear";
            this.btn_cclear.UseVisualStyleBackColor = false;
            this.btn_cclear.Click += new System.EventHandler(this.btn_cclear_Click);
            // 
            // btn_cback
            // 
            this.btn_cback.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cback.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cback.Location = new System.Drawing.Point(24, 203);
            this.btn_cback.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cback.Name = "btn_cback";
            this.btn_cback.Size = new System.Drawing.Size(100, 30);
            this.btn_cback.TabIndex = 74;
            this.btn_cback.Text = "Back";
            this.btn_cback.UseVisualStyleBackColor = false;
            this.btn_cback.Click += new System.EventHandler(this.btn_cback_Click);
            // 
            // btn_cnext
            // 
            this.btn_cnext.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cnext.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cnext.Location = new System.Drawing.Point(366, 203);
            this.btn_cnext.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cnext.Name = "btn_cnext";
            this.btn_cnext.Size = new System.Drawing.Size(100, 30);
            this.btn_cnext.TabIndex = 63;
            this.btn_cnext.Text = "Next";
            this.btn_cnext.UseVisualStyleBackColor = false;
            this.btn_cnext.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 73;
            this.label5.Text = "Register New \r\nCustomer";
            // 
            // lklbl_register
            // 
            this.lklbl_register.AutoSize = true;
            this.lklbl_register.BackColor = System.Drawing.Color.White;
            this.lklbl_register.DisabledLinkColor = System.Drawing.Color.Red;
            this.lklbl_register.Location = new System.Drawing.Point(120, 63);
            this.lklbl_register.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lklbl_register.Name = "lklbl_register";
            this.lklbl_register.Size = new System.Drawing.Size(66, 19);
            this.lklbl_register.TabIndex = 72;
            this.lklbl_register.TabStop = true;
            this.lklbl_register.Text = "Register";
            this.lklbl_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_register_LinkClicked);
            // 
            // txt_telephone
            // 
            this.txt_telephone.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telephone.Location = new System.Drawing.Point(116, 11);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(6);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(118, 23);
            this.txt_telephone.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 66;
            this.label9.Text = "Telephone";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(325, 158);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(124, 23);
            this.txt_email.TabIndex = 67;
            // 
            // btn_csearch
            // 
            this.btn_csearch.BackColor = System.Drawing.Color.DarkGray;
            this.btn_csearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_csearch.Location = new System.Drawing.Point(246, 6);
            this.btn_csearch.Margin = new System.Windows.Forms.Padding(6);
            this.btn_csearch.Name = "btn_csearch";
            this.btn_csearch.Size = new System.Drawing.Size(100, 30);
            this.btn_csearch.TabIndex = 68;
            this.btn_csearch.Text = "Search";
            this.btn_csearch.UseVisualStyleBackColor = false;
            this.btn_csearch.Click += new System.EventHandler(this.btn_csearch_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(325, 117);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(6);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(124, 23);
            this.txt_lname.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Email";
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(116, 158);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(6);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(118, 23);
            this.txt_fname.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "First Name";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(116, 117);
            this.txt_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(118, 23);
            this.txt_id.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 117);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 68;
            this.label13.Text = "Customer Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Last Name";
            // 
            // tab_confirmation
            // 
            this.tab_confirmation.BackColor = System.Drawing.Color.White;
            this.tab_confirmation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab_confirmation.Controls.Add(this.btn_printInvoice);
            this.tab_confirmation.Controls.Add(this.cmb_status);
            this.tab_confirmation.Controls.Add(this.txt_cduration);
            this.tab_confirmation.Controls.Add(this.button1);
            this.tab_confirmation.Controls.Add(this.label18);
            this.tab_confirmation.Controls.Add(this.booking_endtime);
            this.tab_confirmation.Controls.Add(this.booking_starttime);
            this.tab_confirmation.Controls.Add(this.label17);
            this.tab_confirmation.Controls.Add(this.label16);
            this.tab_confirmation.Controls.Add(this.dob_pickercon);
            this.tab_confirmation.Controls.Add(this.txt_appointmentid);
            this.tab_confirmation.Controls.Add(this.Comment);
            this.tab_confirmation.Controls.Add(this.btn_createbooking);
            this.tab_confirmation.Controls.Add(this.btn_conback);
            this.tab_confirmation.Controls.Add(this.btn_conclear);
            this.tab_confirmation.Controls.Add(this.label14);
            this.tab_confirmation.Controls.Add(this.label11);
            this.tab_confirmation.Controls.Add(this.label10);
            this.tab_confirmation.Controls.Add(this.label8);
            this.tab_confirmation.Controls.Add(this.label6);
            this.tab_confirmation.Controls.Add(this.txt_cprice);
            this.tab_confirmation.Controls.Add(this.txt_cservice);
            this.tab_confirmation.HorizontalScrollbarBarColor = true;
            this.tab_confirmation.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_confirmation.HorizontalScrollbarSize = 1;
            this.tab_confirmation.Location = new System.Drawing.Point(4, 44);
            this.tab_confirmation.Margin = new System.Windows.Forms.Padding(6);
            this.tab_confirmation.Name = "tab_confirmation";
            this.tab_confirmation.Size = new System.Drawing.Size(484, 250);
            this.tab_confirmation.TabIndex = 3;
            this.tab_confirmation.Text = "Confirmation               ";
            this.tab_confirmation.UseCustomBackColor = true;
            this.tab_confirmation.UseCustomForeColor = true;
            this.tab_confirmation.UseStyleColors = true;
            this.tab_confirmation.VerticalScrollbarBarColor = true;
            this.tab_confirmation.VerticalScrollbarHighlightOnWheel = false;
            this.tab_confirmation.VerticalScrollbarSize = 1;
            this.tab_confirmation.Click += new System.EventHandler(this.tab_confirmation_Click);
            // 
            // btn_printInvoice
            // 
            this.btn_printInvoice.BackColor = System.Drawing.Color.DarkGray;
            this.btn_printInvoice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printInvoice.Location = new System.Drawing.Point(331, 206);
            this.btn_printInvoice.Name = "btn_printInvoice";
            this.btn_printInvoice.Size = new System.Drawing.Size(121, 29);
            this.btn_printInvoice.TabIndex = 205;
            this.btn_printInvoice.Text = "Print Invoice";
            this.btn_printInvoice.UseVisualStyleBackColor = false;
            this.btn_printInvoice.Click += new System.EventHandler(this.btn_printInvoice_Click);
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.White;
            this.cmb_status.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Pending"});
            this.cmb_status.Location = new System.Drawing.Point(105, 162);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(6);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(316, 25);
            this.cmb_status.TabIndex = 203;
            // 
            // txt_cduration
            // 
            this.txt_cduration.BackColor = System.Drawing.Color.White;
            this.txt_cduration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cduration.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cduration.Location = new System.Drawing.Point(305, 92);
            this.txt_cduration.Margin = new System.Windows.Forms.Padding(6);
            this.txt_cduration.Name = "txt_cduration";
            this.txt_cduration.Size = new System.Drawing.Size(113, 23);
            this.txt_cduration.TabIndex = 202;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(834, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 201;
            this.button1.Text = "Sent Confirmation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(420, 101);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 90;
            this.label18.Text = "Minutes";
            // 
            // booking_endtime
            // 
            this.booking_endtime.AllowDrop = true;
            this.booking_endtime.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.booking_endtime.CalendarTitleBackColor = System.Drawing.Color.Silver;
            this.booking_endtime.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.booking_endtime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_endtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.booking_endtime.Location = new System.Drawing.Point(306, 127);
            this.booking_endtime.Margin = new System.Windows.Forms.Padding(6);
            this.booking_endtime.Name = "booking_endtime";
            this.booking_endtime.ShowUpDown = true;
            this.booking_endtime.Size = new System.Drawing.Size(113, 23);
            this.booking_endtime.TabIndex = 89;
            this.booking_endtime.Value = new System.DateTime(2023, 3, 2, 0, 0, 0, 0);
            this.booking_endtime.ValueChanged += new System.EventHandler(this.booking_endtime_ValueChanged);
            // 
            // booking_starttime
            // 
            this.booking_starttime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_starttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.booking_starttime.Location = new System.Drawing.Point(105, 127);
            this.booking_starttime.Margin = new System.Windows.Forms.Padding(6);
            this.booking_starttime.Name = "booking_starttime";
            this.booking_starttime.ShowUpDown = true;
            this.booking_starttime.Size = new System.Drawing.Size(112, 23);
            this.booking_starttime.TabIndex = 87;
            this.booking_starttime.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.booking_starttime.ValueChanged += new System.EventHandler(this.booking_starttime_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 87);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 30);
            this.label17.TabIndex = 86;
            this.label17.Text = "Appointment \r\nDate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 46);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 30);
            this.label16.TabIndex = 85;
            this.label16.Text = "Appointment \r\nId";
            // 
            // dob_pickercon
            // 
            this.dob_pickercon.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dob_pickercon.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dob_pickercon.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_pickercon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_pickercon.Location = new System.Drawing.Point(105, 87);
            this.dob_pickercon.Margin = new System.Windows.Forms.Padding(6);
            this.dob_pickercon.Name = "dob_pickercon";
            this.dob_pickercon.Size = new System.Drawing.Size(112, 23);
            this.dob_pickercon.TabIndex = 84;
            // 
            // txt_appointmentid
            // 
            this.txt_appointmentid.BackColor = System.Drawing.Color.White;
            this.txt_appointmentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_appointmentid.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appointmentid.Location = new System.Drawing.Point(102, 47);
            this.txt_appointmentid.Margin = new System.Windows.Forms.Padding(6);
            this.txt_appointmentid.Name = "txt_appointmentid";
            this.txt_appointmentid.Size = new System.Drawing.Size(113, 23);
            this.txt_appointmentid.TabIndex = 83;
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.BackColor = System.Drawing.Color.Transparent;
            this.Comment.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(6, 171);
            this.Comment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(45, 15);
            this.Comment.TabIndex = 78;
            this.Comment.Text = "Status";
            // 
            // btn_createbooking
            // 
            this.btn_createbooking.BackColor = System.Drawing.Color.DarkGray;
            this.btn_createbooking.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createbooking.Location = new System.Drawing.Point(169, 206);
            this.btn_createbooking.Margin = new System.Windows.Forms.Padding(6);
            this.btn_createbooking.Name = "btn_createbooking";
            this.btn_createbooking.Size = new System.Drawing.Size(136, 30);
            this.btn_createbooking.TabIndex = 75;
            this.btn_createbooking.Text = "Create Booking";
            this.btn_createbooking.UseVisualStyleBackColor = false;
            this.btn_createbooking.Click += new System.EventHandler(this.btn_createbooking_Click);
            // 
            // btn_conback
            // 
            this.btn_conback.BackColor = System.Drawing.Color.DarkGray;
            this.btn_conback.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conback.Location = new System.Drawing.Point(12, 206);
            this.btn_conback.Margin = new System.Windows.Forms.Padding(6);
            this.btn_conback.Name = "btn_conback";
            this.btn_conback.Size = new System.Drawing.Size(100, 30);
            this.btn_conback.TabIndex = 76;
            this.btn_conback.Text = "Back";
            this.btn_conback.UseVisualStyleBackColor = false;
            this.btn_conback.Click += new System.EventHandler(this.btn_conback_Click);
            // 
            // btn_conclear
            // 
            this.btn_conclear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_conclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conclear.Location = new System.Drawing.Point(372, 3);
            this.btn_conclear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_conclear.Name = "btn_conclear";
            this.btn_conclear.Size = new System.Drawing.Size(100, 30);
            this.btn_conclear.TabIndex = 77;
            this.btn_conclear.Text = "Clear";
            this.btn_conclear.UseVisualStyleBackColor = false;
            this.btn_conclear.Click += new System.EventHandler(this.btn_conclear_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 127);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 30);
            this.label14.TabIndex = 13;
            this.label14.Text = "Booking \r\nStart Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(240, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 30);
            this.label11.TabIndex = 12;
            this.label11.Text = "Booking \r\nEnd Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "Service \r\nPrice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Service";
            // 
            // txt_cprice
            // 
            this.txt_cprice.BackColor = System.Drawing.Color.White;
            this.txt_cprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cprice.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cprice.Location = new System.Drawing.Point(305, 51);
            this.txt_cprice.Margin = new System.Windows.Forms.Padding(6);
            this.txt_cprice.Name = "txt_cprice";
            this.txt_cprice.Size = new System.Drawing.Size(113, 23);
            this.txt_cprice.TabIndex = 5;
            // 
            // txt_cservice
            // 
            this.txt_cservice.BackColor = System.Drawing.Color.White;
            this.txt_cservice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cservice.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cservice.Location = new System.Drawing.Point(102, 10);
            this.txt_cservice.Margin = new System.Windows.Forms.Padding(6);
            this.txt_cservice.Name = "txt_cservice";
            this.txt_cservice.Size = new System.Drawing.Size(113, 23);
            this.txt_cservice.TabIndex = 2;
            // 
            // lbl_heading1
            // 
            this.lbl_heading1.AutoSize = true;
            this.lbl_heading1.BackColor = System.Drawing.Color.Lavender;
            this.lbl_heading1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading1.Location = new System.Drawing.Point(201, 82);
            this.lbl_heading1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_heading1.MinimumSize = new System.Drawing.Size(492, 30);
            this.lbl_heading1.Name = "lbl_heading1";
            this.lbl_heading1.Size = new System.Drawing.Size(492, 30);
            this.lbl_heading1.TabIndex = 203;
            this.lbl_heading1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_displayupdate);
            this.panel2.Controls.Add(this.cmb_updatestatus);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.lbl_heading2);
            this.panel2.Controls.Add(this.btn_appclear);
            this.panel2.Controls.Add(this.btn_appupdate);
            this.panel2.Controls.Add(this.txt_appoinid);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(734, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 315);
            this.panel2.TabIndex = 204;
            // 
            // lbl_displayupdate
            // 
            this.lbl_displayupdate.AutoSize = true;
            this.lbl_displayupdate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displayupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_displayupdate.Location = new System.Drawing.Point(33, 45);
            this.lbl_displayupdate.Name = "lbl_displayupdate";
            this.lbl_displayupdate.Size = new System.Drawing.Size(0, 15);
            this.lbl_displayupdate.TabIndex = 212;
            // 
            // cmb_updatestatus
            // 
            this.cmb_updatestatus.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_updatestatus.FormattingEnabled = true;
            this.cmb_updatestatus.Items.AddRange(new object[] {
            "Pending",
            "Paid",
            "Canceled"});
            this.cmb_updatestatus.Location = new System.Drawing.Point(26, 189);
            this.cmb_updatestatus.Margin = new System.Windows.Forms.Padding(6);
            this.cmb_updatestatus.Name = "cmb_updatestatus";
            this.cmb_updatestatus.Size = new System.Drawing.Size(154, 23);
            this.cmb_updatestatus.TabIndex = 204;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 166);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 15);
            this.label19.TabIndex = 211;
            this.label19.Text = "Update Status";
            // 
            // lbl_heading2
            // 
            this.lbl_heading2.AutoSize = true;
            this.lbl_heading2.BackColor = System.Drawing.Color.Lavender;
            this.lbl_heading2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading2.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_heading2.MaximumSize = new System.Drawing.Size(215, 30);
            this.lbl_heading2.MinimumSize = new System.Drawing.Size(215, 30);
            this.lbl_heading2.Name = "lbl_heading2";
            this.lbl_heading2.Size = new System.Drawing.Size(215, 30);
            this.lbl_heading2.TabIndex = 85;
            this.lbl_heading2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_appclear
            // 
            this.btn_appclear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_appclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appclear.Location = new System.Drawing.Point(64, 230);
            this.btn_appclear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_appclear.Name = "btn_appclear";
            this.btn_appclear.Size = new System.Drawing.Size(89, 30);
            this.btn_appclear.TabIndex = 84;
            this.btn_appclear.Text = "Clear";
            this.btn_appclear.UseVisualStyleBackColor = false;
            this.btn_appclear.Click += new System.EventHandler(this.btn_appclear_Click);
            // 
            // btn_appupdate
            // 
            this.btn_appupdate.BackColor = System.Drawing.Color.DarkGray;
            this.btn_appupdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appupdate.Location = new System.Drawing.Point(63, 272);
            this.btn_appupdate.Margin = new System.Windows.Forms.Padding(6);
            this.btn_appupdate.Name = "btn_appupdate";
            this.btn_appupdate.Size = new System.Drawing.Size(90, 30);
            this.btn_appupdate.TabIndex = 67;
            this.btn_appupdate.Text = "Update";
            this.btn_appupdate.UseVisualStyleBackColor = false;
            this.btn_appupdate.Click += new System.EventHandler(this.btn_appupdate_Click);
            // 
            // txt_appoinid
            // 
            this.txt_appoinid.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appoinid.Location = new System.Drawing.Point(27, 115);
            this.txt_appoinid.Margin = new System.Windows.Forms.Padding(6);
            this.txt_appoinid.Name = "txt_appoinid";
            this.txt_appoinid.Size = new System.Drawing.Size(160, 23);
            this.txt_appoinid.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 15);
            this.label12.TabIndex = 83;
            this.label12.Text = "Appointment Id";
            // 
            // cmb_branchsearch
            // 
            this.cmb_branchsearch.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_branchsearch.FormattingEnabled = true;
            this.cmb_branchsearch.Items.AddRange(new object[] {
            "Gampaha",
            "Wattala",
            "Colombo"});
            this.cmb_branchsearch.Location = new System.Drawing.Point(15, 464);
            this.cmb_branchsearch.Margin = new System.Windows.Forms.Padding(6);
            this.cmb_branchsearch.Name = "cmb_branchsearch";
            this.cmb_branchsearch.Size = new System.Drawing.Size(154, 23);
            this.cmb_branchsearch.TabIndex = 210;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(12, 440);
            this.lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 17);
            this.lbl.TabIndex = 209;
            this.lbl.Text = "Branch";
            // 
            // btn_searchbranch
            // 
            this.btn_searchbranch.BackColor = System.Drawing.Color.DarkGray;
            this.btn_searchbranch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchbranch.Location = new System.Drawing.Point(78, 497);
            this.btn_searchbranch.Margin = new System.Windows.Forms.Padding(6);
            this.btn_searchbranch.Name = "btn_searchbranch";
            this.btn_searchbranch.Size = new System.Drawing.Size(93, 30);
            this.btn_searchbranch.TabIndex = 208;
            this.btn_searchbranch.Text = "Search";
            this.btn_searchbranch.UseVisualStyleBackColor = false;
            this.btn_searchbranch.Click += new System.EventHandler(this.btn_searchbranch_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.DarkGray;
            this.btn_view.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(15, 589);
            this.btn_view.Margin = new System.Windows.Forms.Padding(6);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(156, 27);
            this.btn_view.TabIndex = 207;
            this.btn_view.Text = "View All";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 70);
            this.panel1.TabIndex = 211;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(909, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 32);
            this.button3.TabIndex = 214;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.SlateGray;
            this.label20.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(71, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(189, 32);
            this.label20.TabIndex = 213;
            this.label20.Text = "Appointments";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1074, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 49);
            this.pictureBox2.TabIndex = 212;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(15, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 180);
            this.panel3.TabIndex = 212;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Location = new System.Drawing.Point(0, 630);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 20);
            this.panel4.TabIndex = 213;
            // 
            // lbl_heading3
            // 
            this.lbl_heading3.AutoSize = true;
            this.lbl_heading3.BackColor = System.Drawing.Color.Lavender;
            this.lbl_heading3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading3.Location = new System.Drawing.Point(197, 434);
            this.lbl_heading3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_heading3.MaximumSize = new System.Drawing.Size(741, 30);
            this.lbl_heading3.MinimumSize = new System.Drawing.Size(741, 30);
            this.lbl_heading3.Name = "lbl_heading3";
            this.lbl_heading3.Size = new System.Drawing.Size(741, 30);
            this.lbl_heading3.TabIndex = 214;
            this.lbl_heading3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 468);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(745, 149);
            this.dataGridView1.TabIndex = 216;
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_heading3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_branchsearch);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_searchbranch);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_heading1);
            this.Controls.Add(this.tab_main);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(950, 650);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "BookAppointment";
            this.Padding = new System.Windows.Forms.Padding(30, 87, 30, 29);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BookAppointment_Load);
            this.tab_main.ResumeLayout(false);
            this.tab_service.ResumeLayout(false);
            this.tab_service.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gmpbranch)).EndInit();
            this.tab_customer.ResumeLayout(false);
            this.tab_customer.PerformLayout();
            this.tab_confirmation.ResumeLayout(false);
            this.tab_confirmation.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private MetroFramework.Controls.MetroTabControl tab_main;
        //private MetroFramework.Controls.MetroTabPage tab_service;
        //private MetroFramework.Controls.MetroTabPage tab_customer;
        //private MetroFramework.Controls.MetroTabPage tab_confirmation;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_gmpbranch;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_csearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cnext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lklbl_register;
        private System.Windows.Forms.Button btn_cback;
        private System.Windows.Forms.Button btn_cclear;
        private System.Windows.Forms.TextBox txt_cprice;
        private System.Windows.Forms.TextBox txt_cservice;
        private System.Windows.Forms.Button btn_conclear;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_createbooking;
        private System.Windows.Forms.Button btn_conback;
        private System.Windows.Forms.ComboBox cmb_branchservice;
        private System.Windows.Forms.ComboBox cmb_selectservice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.DateTimePicker dob_picker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dob_pickercon;
        private System.Windows.Forms.TextBox txt_appointmentid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker booking_starttime;
        private System.Windows.Forms.DateTimePicker booking_endtime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTabControl tab_main;
        private MetroFramework.Controls.MetroTabPage tab_service;
        private MetroFramework.Controls.MetroTabPage tab_customer;
        private MetroFramework.Controls.MetroTabPage tab_confirmation;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_heading1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_appclear;
        private System.Windows.Forms.Button btn_appupdate;
        private System.Windows.Forms.TextBox txt_appoinid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_branchsearch;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn_searchbranch;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.TextBox txt_cduration;
        private System.Windows.Forms.Label lbl_heading2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ComboBox cmb_updatestatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_heading3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_displayupdate;
        private System.Windows.Forms.Button btn_printInvoice;
    }
}