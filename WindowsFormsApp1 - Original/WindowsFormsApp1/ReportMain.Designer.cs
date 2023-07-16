namespace WindowsFormsApp1
{
    partial class ReportMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMain));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_cusdisplay = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tab_controlrep = new System.Windows.Forms.TabControl();
            this.tab_repAppointment = new System.Windows.Forms.TabPage();
            this.date_picker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_status1 = new System.Windows.Forms.ComboBox();
            this.cmb_branch1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_appointmentSearch = new System.Windows.Forms.Button();
            this.tab_repExpenses = new System.Windows.Forms.TabPage();
            this.cmb_branch2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_repExpenses = new System.Windows.Forms.Button();
            this.tab_repEmployee = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_branch = new System.Windows.Forms.ComboBox();
            this.cmb_empStatus = new System.Windows.Forms.ComboBox();
            this.report_ViewEmployee = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_repEmployee = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.report_ViewAppointment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.date_picker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMain = new WindowsFormsApp1.DataSetMain();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new WindowsFormsApp1.DataSetMainTableAdapters.AppointmentTableAdapter();
            this.employeeTableAdapter = new WindowsFormsApp1.DataSetMainTableAdapters.EmployeeTableAdapter();
            this.expensesTableAdapter = new WindowsFormsApp1.DataSetMainTableAdapters.ExpensesTableAdapter();
            this.report_ViewExpenses = new Microsoft.Reporting.WinForms.ReportViewer();
            this.date_pickerexp1 = new System.Windows.Forms.DateTimePicker();
            this.date_pickerexp2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_controlrep.SuspendLayout();
            this.tab_repAppointment.SuspendLayout();
            this.tab_repExpenses.SuspendLayout();
            this.tab_repEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 34);
            this.label1.TabIndex = 104;
            this.label1.Text = "Reports";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_close.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(895, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(43, 36);
            this.btn_close.TabIndex = 101;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_cusdisplay
            // 
            this.lbl_cusdisplay.AutoSize = true;
            this.lbl_cusdisplay.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbl_cusdisplay.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusdisplay.Location = new System.Drawing.Point(-1, -2);
            this.lbl_cusdisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cusdisplay.MaximumSize = new System.Drawing.Size(950, 70);
            this.lbl_cusdisplay.MinimumSize = new System.Drawing.Size(950, 70);
            this.lbl_cusdisplay.Name = "lbl_cusdisplay";
            this.lbl_cusdisplay.Size = new System.Drawing.Size(950, 70);
            this.lbl_cusdisplay.TabIndex = 103;
            this.lbl_cusdisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // tab_controlrep
            // 
            this.tab_controlrep.Controls.Add(this.tab_repAppointment);
            this.tab_controlrep.Controls.Add(this.tab_repExpenses);
            this.tab_controlrep.Controls.Add(this.tab_repEmployee);
            this.tab_controlrep.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_controlrep.Location = new System.Drawing.Point(25, 83);
            this.tab_controlrep.Name = "tab_controlrep";
            this.tab_controlrep.SelectedIndex = 0;
            this.tab_controlrep.Size = new System.Drawing.Size(900, 520);
            this.tab_controlrep.TabIndex = 105;
            // 
            // tab_repAppointment
            // 
            this.tab_repAppointment.Controls.Add(this.label9);
            this.tab_repAppointment.Controls.Add(this.date_picker2);
            this.tab_repAppointment.Controls.Add(this.report_ViewAppointment);
            this.tab_repAppointment.Controls.Add(this.date_picker1);
            this.tab_repAppointment.Controls.Add(this.cmb_status1);
            this.tab_repAppointment.Controls.Add(this.cmb_branch1);
            this.tab_repAppointment.Controls.Add(this.label6);
            this.tab_repAppointment.Controls.Add(this.label5);
            this.tab_repAppointment.Controls.Add(this.label4);
            this.tab_repAppointment.Controls.Add(this.btn_appointmentSearch);
            this.tab_repAppointment.Location = new System.Drawing.Point(4, 24);
            this.tab_repAppointment.Name = "tab_repAppointment";
            this.tab_repAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tab_repAppointment.Size = new System.Drawing.Size(892, 492);
            this.tab_repAppointment.TabIndex = 0;
            this.tab_repAppointment.Text = "                             Appointments                                 ";
            this.tab_repAppointment.UseVisualStyleBackColor = true;
            this.tab_repAppointment.Click += new System.EventHandler(this.tab_repAppointment_Click);
            // 
            // date_picker1
            // 
            this.date_picker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker1.Location = new System.Drawing.Point(125, 59);
            this.date_picker1.Name = "date_picker1";
            this.date_picker1.Size = new System.Drawing.Size(129, 23);
            this.date_picker1.TabIndex = 12;
            // 
            // cmb_status1
            // 
            this.cmb_status1.FormattingEnabled = true;
            this.cmb_status1.Items.AddRange(new object[] {
            "Pending",
            "Paid",
            "Canceled"});
            this.cmb_status1.Location = new System.Drawing.Point(565, 15);
            this.cmb_status1.Name = "cmb_status1";
            this.cmb_status1.Size = new System.Drawing.Size(129, 23);
            this.cmb_status1.TabIndex = 11;
            // 
            // cmb_branch1
            // 
            this.cmb_branch1.FormattingEnabled = true;
            this.cmb_branch1.Items.AddRange(new object[] {
            "Gampaha",
            "Wattala",
            "Colombo"});
            this.cmb_branch1.Location = new System.Drawing.Point(125, 20);
            this.cmb_branch1.Name = "cmb_branch1";
            this.cmb_branch1.Size = new System.Drawing.Size(129, 23);
            this.cmb_branch1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Appointment \r\nStatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Branch";
            // 
            // btn_appointmentSearch
            // 
            this.btn_appointmentSearch.Location = new System.Drawing.Point(780, 32);
            this.btn_appointmentSearch.Name = "btn_appointmentSearch";
            this.btn_appointmentSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_appointmentSearch.TabIndex = 3;
            this.btn_appointmentSearch.Text = "Search";
            this.btn_appointmentSearch.UseVisualStyleBackColor = true;
            this.btn_appointmentSearch.Click += new System.EventHandler(this.btn_appointmentSearch_Click);
            // 
            // tab_repExpenses
            // 
            this.tab_repExpenses.Controls.Add(this.label10);
            this.tab_repExpenses.Controls.Add(this.label7);
            this.tab_repExpenses.Controls.Add(this.date_pickerexp2);
            this.tab_repExpenses.Controls.Add(this.date_pickerexp1);
            this.tab_repExpenses.Controls.Add(this.cmb_branch2);
            this.tab_repExpenses.Controls.Add(this.label8);
            this.tab_repExpenses.Controls.Add(this.report_ViewExpenses);
            this.tab_repExpenses.Controls.Add(this.btn_repExpenses);
            this.tab_repExpenses.Location = new System.Drawing.Point(4, 24);
            this.tab_repExpenses.Name = "tab_repExpenses";
            this.tab_repExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tab_repExpenses.Size = new System.Drawing.Size(892, 492);
            this.tab_repExpenses.TabIndex = 1;
            this.tab_repExpenses.Text = "                                             Expenses                            " +
    "                ";
            this.tab_repExpenses.UseVisualStyleBackColor = true;
            this.tab_repExpenses.Click += new System.EventHandler(this.tab_repExpenses_Click);
            // 
            // cmb_branch2
            // 
            this.cmb_branch2.FormattingEnabled = true;
            this.cmb_branch2.Items.AddRange(new object[] {
            "Gampaha",
            "Wattala",
            "Colombo"});
            this.cmb_branch2.Location = new System.Drawing.Point(111, 24);
            this.cmb_branch2.Name = "cmb_branch2";
            this.cmb_branch2.Size = new System.Drawing.Size(129, 23);
            this.cmb_branch2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Branch";
            // 
            // btn_repExpenses
            // 
            this.btn_repExpenses.Location = new System.Drawing.Point(776, 21);
            this.btn_repExpenses.Name = "btn_repExpenses";
            this.btn_repExpenses.Size = new System.Drawing.Size(75, 23);
            this.btn_repExpenses.TabIndex = 4;
            this.btn_repExpenses.Text = "Search";
            this.btn_repExpenses.UseVisualStyleBackColor = true;
            this.btn_repExpenses.Click += new System.EventHandler(this.btn_repExpenses_Click);
            // 
            // tab_repEmployee
            // 
            this.tab_repEmployee.Controls.Add(this.label3);
            this.tab_repEmployee.Controls.Add(this.label2);
            this.tab_repEmployee.Controls.Add(this.cmb_branch);
            this.tab_repEmployee.Controls.Add(this.cmb_empStatus);
            this.tab_repEmployee.Controls.Add(this.report_ViewEmployee);
            this.tab_repEmployee.Controls.Add(this.btn_repEmployee);
            this.tab_repEmployee.Location = new System.Drawing.Point(4, 24);
            this.tab_repEmployee.Name = "tab_repEmployee";
            this.tab_repEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_repEmployee.Size = new System.Drawing.Size(892, 492);
            this.tab_repEmployee.TabIndex = 2;
            this.tab_repEmployee.Text = "                                     Employee                                    " +
    " ";
            this.tab_repEmployee.UseVisualStyleBackColor = true;
            this.tab_repEmployee.Click += new System.EventHandler(this.tab_repEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Employee Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Branch";
            // 
            // cmb_branch
            // 
            this.cmb_branch.FormattingEnabled = true;
            this.cmb_branch.Items.AddRange(new object[] {
            "Gampaha",
            "Wattala",
            "Colombo"});
            this.cmb_branch.Location = new System.Drawing.Point(224, 20);
            this.cmb_branch.Name = "cmb_branch";
            this.cmb_branch.Size = new System.Drawing.Size(129, 23);
            this.cmb_branch.TabIndex = 9;
            // 
            // cmb_empStatus
            // 
            this.cmb_empStatus.FormattingEnabled = true;
            this.cmb_empStatus.Items.AddRange(new object[] {
            "Active",
            "Resign"});
            this.cmb_empStatus.Location = new System.Drawing.Point(550, 20);
            this.cmb_empStatus.Name = "cmb_empStatus";
            this.cmb_empStatus.Size = new System.Drawing.Size(121, 23);
            this.cmb_empStatus.TabIndex = 8;
            // 
            // report_ViewEmployee
            // 
            reportDataSource10.Name = "DataSet1";
            reportDataSource10.Value = this.employeeBindingSource;
            this.report_ViewEmployee.LocalReport.DataSources.Add(reportDataSource10);
            this.report_ViewEmployee.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.EmployeeWizard.rdlc";
            this.report_ViewEmployee.Location = new System.Drawing.Point(19, 61);
            this.report_ViewEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.report_ViewEmployee.Name = "report_ViewEmployee";
            this.report_ViewEmployee.ServerReport.BearerToken = null;
            this.report_ViewEmployee.Size = new System.Drawing.Size(855, 402);
            this.report_ViewEmployee.TabIndex = 7;
            // 
            // btn_repEmployee
            // 
            this.btn_repEmployee.Location = new System.Drawing.Point(782, 20);
            this.btn_repEmployee.Name = "btn_repEmployee";
            this.btn_repEmployee.Size = new System.Drawing.Size(75, 23);
            this.btn_repEmployee.TabIndex = 5;
            this.btn_repEmployee.Text = "Search";
            this.btn_repEmployee.UseVisualStyleBackColor = true;
            this.btn_repEmployee.Click += new System.EventHandler(this.btn_repEmployee_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Location = new System.Drawing.Point(0, 630);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 20);
            this.panel3.TabIndex = 106;
            // 
            // report_ViewAppointment
            // 
            reportDataSource11.Name = "DataSet1";
            reportDataSource11.Value = this.appointmentBindingSource;
            this.report_ViewAppointment.LocalReport.DataSources.Add(reportDataSource11);
            this.report_ViewAppointment.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.AppointmentWizard.rdlc";
            this.report_ViewAppointment.Location = new System.Drawing.Point(29, 108);
            this.report_ViewAppointment.Name = "report_ViewAppointment";
            this.report_ViewAppointment.ServerReport.BearerToken = null;
            this.report_ViewAppointment.Size = new System.Drawing.Size(835, 360);
            this.report_ViewAppointment.TabIndex = 13;
            // 
            // date_picker2
            // 
            this.date_picker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker2.Location = new System.Drawing.Point(565, 53);
            this.date_picker2.Name = "date_picker2";
            this.date_picker2.Size = new System.Drawing.Size(129, 23);
            this.date_picker2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "End Date";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.dataSetMain;
            // 
            // dataSetMain
            // 
            this.dataSetMain.DataSetName = "DataSetMain";
            this.dataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.dataSetMain;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataSetMain;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // report_ViewExpenses
            // 
            this.report_ViewExpenses.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource12.Name = "DataSet1";
            reportDataSource12.Value = this.expensesBindingSource;
            this.report_ViewExpenses.LocalReport.DataSources.Add(reportDataSource12);
            this.report_ViewExpenses.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ExpensesWizard.rdlc";
            this.report_ViewExpenses.Location = new System.Drawing.Point(36, 70);
            this.report_ViewExpenses.Name = "report_ViewExpenses";
            this.report_ViewExpenses.ServerReport.BearerToken = null;
            this.report_ViewExpenses.Size = new System.Drawing.Size(815, 379);
            this.report_ViewExpenses.TabIndex = 5;
            // 
            // date_pickerexp1
            // 
            this.date_pickerexp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pickerexp1.Location = new System.Drawing.Point(343, 24);
            this.date_pickerexp1.Name = "date_pickerexp1";
            this.date_pickerexp1.Size = new System.Drawing.Size(121, 23);
            this.date_pickerexp1.TabIndex = 16;
            // 
            // date_pickerexp2
            // 
            this.date_pickerexp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pickerexp2.Location = new System.Drawing.Point(603, 21);
            this.date_pickerexp2.Name = "date_pickerexp2";
            this.date_pickerexp2.Size = new System.Drawing.Size(126, 23);
            this.date_pickerexp2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Start Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "End Date";
            // 
            // ReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tab_controlrep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_cusdisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportMain";
            this.Load += new System.EventHandler(this.ReportMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tab_controlrep.ResumeLayout(false);
            this.tab_repAppointment.ResumeLayout(false);
            this.tab_repAppointment.PerformLayout();
            this.tab_repExpenses.ResumeLayout(false);
            this.tab_repExpenses.PerformLayout();
            this.tab_repEmployee.ResumeLayout(false);
            this.tab_repEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_cusdisplay;
        private System.Windows.Forms.TabControl tab_controlrep;
        private System.Windows.Forms.TabPage tab_repAppointment;
        private System.Windows.Forms.TabPage tab_repExpenses;
        private System.Windows.Forms.TabPage tab_repEmployee;
        private System.Windows.Forms.Panel panel3;
        private DataSetMain dataSetMain;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private DataSetMainTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.Button btn_appointmentSearch;
        private System.Windows.Forms.Button btn_repExpenses;
        private System.Windows.Forms.Button btn_repEmployee;
        private Microsoft.Reporting.WinForms.ReportViewer report_ViewEmployee;
        private System.Windows.Forms.ComboBox cmb_branch;
        private System.Windows.Forms.ComboBox cmb_empStatus;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSetMainTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private DataSetMainTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_picker1;
        private System.Windows.Forms.ComboBox cmb_status1;
        private System.Windows.Forms.ComboBox cmb_branch1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_branch2;
        private System.Windows.Forms.Label label8;
        private Microsoft.Reporting.WinForms.ReportViewer report_ViewAppointment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_picker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_pickerexp2;
        private System.Windows.Forms.DateTimePicker date_pickerexp1;
        private Microsoft.Reporting.WinForms.ReportViewer report_ViewExpenses;
    }
}