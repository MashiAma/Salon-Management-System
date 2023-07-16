namespace WindowsFormsApp1
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Expenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart_branchTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.chartemployee_Count = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_cusdisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_monthlyIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chart_bookingCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Expenses)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_branchTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartemployee_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_monthlyIncome)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bookingCount)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_Expenses
            // 
            this.chart_Expenses.BorderlineColor = System.Drawing.Color.Lavender;
            chartArea1.Name = "ChartArea1";
            this.chart_Expenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Expenses.Legends.Add(legend1);
            this.chart_Expenses.Location = new System.Drawing.Point(34, 36);
            this.chart_Expenses.Name = "chart_Expenses";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Monthly_Expenses";
            this.chart_Expenses.Series.Add(series1);
            this.chart_Expenses.Size = new System.Drawing.Size(317, 191);
            this.chart_Expenses.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.chart_branchTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chartemployee_Count);
            this.panel1.Location = new System.Drawing.Point(44, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 241);
            this.panel1.TabIndex = 6;
            // 
            // chart_branchTotal
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_branchTotal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_branchTotal.Legends.Add(legend2);
            this.chart_branchTotal.Location = new System.Drawing.Point(24, 33);
            this.chart_branchTotal.Name = "chart_branchTotal";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Branch_Total";
            this.chart_branchTotal.Series.Add(series2);
            this.chart_branchTotal.Size = new System.Drawing.Size(202, 191);
            this.chart_branchTotal.TabIndex = 9;
            this.chart_branchTotal.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Emloyee Details";
            // 
            // chartemployee_Count
            // 
            chartArea3.Name = "ChartArea1";
            this.chartemployee_Count.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartemployee_Count.Legends.Add(legend3);
            this.chartemployee_Count.Location = new System.Drawing.Point(249, 33);
            this.chartemployee_Count.Name = "chartemployee_Count";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series3.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series3.Legend = "Legend1";
            series3.Name = "Employee_Count";
            this.chartemployee_Count.Series.Add(series3);
            this.chartemployee_Count.Size = new System.Drawing.Size(221, 191);
            this.chartemployee_Count.TabIndex = 7;
            this.chartemployee_Count.Text = "Employee Count";
            // 
            // lbl_cusdisplay
            // 
            this.lbl_cusdisplay.AutoSize = true;
            this.lbl_cusdisplay.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_cusdisplay.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusdisplay.Location = new System.Drawing.Point(0, 0);
            this.lbl_cusdisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cusdisplay.MaximumSize = new System.Drawing.Size(950, 65);
            this.lbl_cusdisplay.MinimumSize = new System.Drawing.Size(950, 65);
            this.lbl_cusdisplay.Name = "lbl_cusdisplay";
            this.lbl_cusdisplay.Size = new System.Drawing.Size(950, 65);
            this.lbl_cusdisplay.TabIndex = 100;
            this.lbl_cusdisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 101;
            this.label1.Text = "Charts";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 46);
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Location = new System.Drawing.Point(0, 632);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 18);
            this.panel3.TabIndex = 104;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_close.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(898, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 39);
            this.btn_close.TabIndex = 105;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chart_monthlyIncome);
            this.panel2.Location = new System.Drawing.Point(44, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 253);
            this.panel2.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Income";
            // 
            // chart_monthlyIncome
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_monthlyIncome.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_monthlyIncome.Legends.Add(legend4);
            this.chart_monthlyIncome.Location = new System.Drawing.Point(38, 40);
            this.chart_monthlyIncome.Name = "chart_monthlyIncome";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Monthly_Income";
            this.chart_monthlyIncome.Series.Add(series4);
            this.chart_monthlyIncome.Size = new System.Drawing.Size(282, 184);
            this.chart_monthlyIncome.TabIndex = 107;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.chart_Expenses);
            this.panel4.Location = new System.Drawing.Point(515, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 253);
            this.panel4.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "Expenses";
            // 
            // chart_bookingCount
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_bookingCount.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_bookingCount.Legends.Add(legend5);
            this.chart_bookingCount.Location = new System.Drawing.Point(43, 40);
            this.chart_bookingCount.Name = "chart_bookingCount";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Branch_Booking";
            this.chart_bookingCount.Series.Add(series5);
            this.chart_bookingCount.Size = new System.Drawing.Size(243, 184);
            this.chart_bookingCount.TabIndex = 108;
            this.chart_bookingCount.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lavender;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.chart_bookingCount);
            this.panel5.Location = new System.Drawing.Point(579, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 241);
            this.panel5.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 25);
            this.label5.TabIndex = 109;
            this.label5.Text = "Ongoing Booking Count";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cusdisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(950, 650);
            this.Name = "Charts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Expenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_branchTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartemployee_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_monthlyIncome)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bookingCount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Expenses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cusdisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartemployee_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_monthlyIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bookingCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_branchTotal;
    }
}