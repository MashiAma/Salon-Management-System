namespace Gad_project_1
{
    partial class t
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
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_hco = new System.Windows.Forms.CheckBox();
            this.Cb_hm = new System.Windows.Forms.CheckBox();
            this.Cb_hcut = new System.Windows.Forms.CheckBox();
            this.Cb_ep = new System.Windows.Forms.CheckBox();
            this.Cb_fc = new System.Windows.Forms.CheckBox();
            this.Cb_fm = new System.Windows.Forms.CheckBox();
            this.Cb_np = new System.Windows.Forms.CheckBox();
            this.Cb_nco = new System.Windows.Forms.CheckBox();
            this.Cb_hst = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.ForeColor = System.Drawing.Color.Maroon;
            this.btn_next.Location = new System.Drawing.Point(89, 372);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 26);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Location = new System.Drawing.Point(298, 372);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 26);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(512, 372);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 26);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(298, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Services we provided..";
            // 
            // Cb_hco
            // 
            this.Cb_hco.AutoSize = true;
            this.Cb_hco.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_hco.Location = new System.Drawing.Point(52, 220);
            this.Cb_hco.Name = "Cb_hco";
            this.Cb_hco.Size = new System.Drawing.Size(84, 19);
            this.Cb_hco.TabIndex = 12;
            this.Cb_hco.Text = "Hair Color";
            this.Cb_hco.UseVisualStyleBackColor = true;
            // 
            // Cb_hm
            // 
            this.Cb_hm.AutoSize = true;
            this.Cb_hm.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_hm.Location = new System.Drawing.Point(52, 178);
            this.Cb_hm.Name = "Cb_hm";
            this.Cb_hm.Size = new System.Drawing.Size(108, 19);
            this.Cb_hm.TabIndex = 13;
            this.Cb_hm.Text = "Head Massage";
            this.Cb_hm.UseVisualStyleBackColor = true;
            this.Cb_hm.CheckedChanged += new System.EventHandler(this.Cb_hm_CheckedChanged);
            // 
            // Cb_hcut
            // 
            this.Cb_hcut.AutoSize = true;
            this.Cb_hcut.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_hcut.Location = new System.Drawing.Point(52, 132);
            this.Cb_hcut.Name = "Cb_hcut";
            this.Cb_hcut.Size = new System.Drawing.Size(73, 19);
            this.Cb_hcut.TabIndex = 14;
            this.Cb_hcut.Text = "Hair Cut";
            this.Cb_hcut.UseVisualStyleBackColor = true;
            // 
            // Cb_ep
            // 
            this.Cb_ep.AutoSize = true;
            this.Cb_ep.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ep.Location = new System.Drawing.Point(266, 132);
            this.Cb_ep.Name = "Cb_ep";
            this.Cb_ep.Size = new System.Drawing.Size(132, 19);
            this.Cb_ep.TabIndex = 15;
            this.Cb_ep.Text = "Eyebrows Plucking";
            this.Cb_ep.UseVisualStyleBackColor = true;
            // 
            // Cb_fc
            // 
            this.Cb_fc.AutoSize = true;
            this.Cb_fc.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_fc.Location = new System.Drawing.Point(266, 178);
            this.Cb_fc.Name = "Cb_fc";
            this.Cb_fc.Size = new System.Drawing.Size(109, 19);
            this.Cb_fc.TabIndex = 16;
            this.Cb_fc.Text = "Facial Cleanup";
            this.Cb_fc.UseVisualStyleBackColor = true;
            // 
            // Cb_fm
            // 
            this.Cb_fm.AutoSize = true;
            this.Cb_fm.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_fm.Location = new System.Drawing.Point(266, 220);
            this.Cb_fm.Name = "Cb_fm";
            this.Cb_fm.Size = new System.Drawing.Size(105, 19);
            this.Cb_fm.TabIndex = 17;
            this.Cb_fm.Text = "Face Massage";
            this.Cb_fm.UseVisualStyleBackColor = true;
            this.Cb_fm.CheckedChanged += new System.EventHandler(this.Cb_fm_CheckedChanged);
            // 
            // Cb_np
            // 
            this.Cb_np.AutoSize = true;
            this.Cb_np.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_np.Location = new System.Drawing.Point(504, 132);
            this.Cb_np.Name = "Cb_np";
            this.Cb_np.Size = new System.Drawing.Size(84, 19);
            this.Cb_np.TabIndex = 18;
            this.Cb_np.Text = "Nail Polish";
            this.Cb_np.UseVisualStyleBackColor = true;
            // 
            // Cb_nco
            // 
            this.Cb_nco.AutoSize = true;
            this.Cb_nco.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_nco.Location = new System.Drawing.Point(504, 178);
            this.Cb_nco.Name = "Cb_nco";
            this.Cb_nco.Size = new System.Drawing.Size(106, 19);
            this.Cb_nco.TabIndex = 19;
            this.Cb_nco.Text = "Nail Colouring";
            this.Cb_nco.UseVisualStyleBackColor = true;
            // 
            // Cb_hst
            // 
            this.Cb_hst.AutoSize = true;
            this.Cb_hst.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_hst.Location = new System.Drawing.Point(52, 260);
            this.Cb_hst.Name = "Cb_hst";
            this.Cb_hst.Size = new System.Drawing.Size(98, 19);
            this.Cb_hst.TabIndex = 21;
            this.Cb_hst.Text = "Hair Straight";
            this.Cb_hst.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hair Treatments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Facial Treatments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Other";
            // 
            // t
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(701, 465);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_fm);
            this.Controls.Add(this.Cb_nco);
            this.Controls.Add(this.Cb_np);
            this.Controls.Add(this.Cb_fc);
            this.Controls.Add(this.Cb_ep);
            this.Controls.Add(this.Cb_hst);
            this.Controls.Add(this.Cb_hco);
            this.Controls.Add(this.Cb_hcut);
            this.Controls.Add(this.Cb_hm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_next);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "t";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Cb_hco;
        private System.Windows.Forms.CheckBox Cb_hm;
        private System.Windows.Forms.CheckBox Cb_hcut;
        private System.Windows.Forms.CheckBox Cb_ep;
        private System.Windows.Forms.CheckBox Cb_fc;
        private System.Windows.Forms.CheckBox Cb_fm;
        private System.Windows.Forms.CheckBox Cb_np;
        private System.Windows.Forms.CheckBox Cb_nco;
        private System.Windows.Forms.CheckBox Cb_hst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

