
namespace LTWin_Last.View
{
    partial class AddFilm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilm));
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPhim = new System.Windows.Forms.TextBox();
			this.txtCatagory = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ptb_Anh = new System.Windows.Forms.PictureBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Rt_info = new System.Windows.Forms.RichTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lb_time = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label6.Location = new System.Drawing.Point(236, 153);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "Thời lượng";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(169)))), ((int)(((byte)(67)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(457, 358);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 40);
			this.button1.TabIndex = 7;
			this.button1.Text = "THÊM PHIM";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label8.Location = new System.Drawing.Point(159, 229);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(126, 22);
			this.label8.TabIndex = 8;
			this.label8.Text = "THÔNG TIN PHIM";
			// 
			// txtPhim
			// 
			this.txtPhim.Location = new System.Drawing.Point(82, 100);
			this.txtPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPhim.Name = "txtPhim";
			this.txtPhim.Size = new System.Drawing.Size(91, 25);
			this.txtPhim.TabIndex = 10;
			// 
			// txtCatagory
			// 
			this.txtCatagory.Location = new System.Drawing.Point(239, 100);
			this.txtCatagory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtCatagory.Name = "txtCatagory";
			this.txtCatagory.Size = new System.Drawing.Size(108, 25);
			this.txtCatagory.TabIndex = 11;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(239, 177);
			this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(108, 25);
			this.textBox7.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.ptb_Anh);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.Rt_info);
			this.panel1.Controls.Add(this.textBox7);
			this.panel1.Controls.Add(this.txtCatagory);
			this.panel1.Controls.Add(this.txtPhim);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(91, 98);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(702, 412);
			this.panel1.TabIndex = 16;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// ptb_Anh
			// 
			this.ptb_Anh.BackColor = System.Drawing.Color.Transparent;
			this.ptb_Anh.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Anh.Image")));
			this.ptb_Anh.Location = new System.Drawing.Point(424, 37);
			this.ptb_Anh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ptb_Anh.Name = "ptb_Anh";
			this.ptb_Anh.Size = new System.Drawing.Size(220, 284);
			this.ptb_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptb_Anh.TabIndex = 21;
			this.ptb_Anh.TabStop = false;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(80, 37);
			this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(265, 25);
			this.textBox5.TabIndex = 20;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label12.Location = new System.Drawing.Point(76, 13);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 22);
			this.label12.TabIndex = 19;
			this.label12.Text = "Tên Phim";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label11.Location = new System.Drawing.Point(104, 13);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(0, 22);
			this.label11.TabIndex = 18;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 177);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(91, 25);
			this.textBox1.TabIndex = 17;
			// 
			// Rt_info
			// 
			this.Rt_info.Location = new System.Drawing.Point(80, 261);
			this.Rt_info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Rt_info.Name = "Rt_info";
			this.Rt_info.Size = new System.Drawing.Size(265, 122);
			this.Rt_info.TabIndex = 16;
			this.Rt_info.Text = "";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label13.Location = new System.Drawing.Point(79, 153);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(71, 22);
			this.label13.TabIndex = 4;
			this.label13.Text = "Đánh giá";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label10.Location = new System.Drawing.Point(236, 76);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 22);
			this.label10.TabIndex = 1;
			this.label10.Text = "Thể loại";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label9.Location = new System.Drawing.Point(76, 76);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 22);
			this.label9.TabIndex = 0;
			this.label9.Text = "Mã phim";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label7.Location = new System.Drawing.Point(354, 16);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(218, 32);
			this.label7.TabIndex = 18;
			this.label7.Text = "THÊM PHIM MỚI";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
			this.panel2.Controls.Add(this.label7);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(886, 66);
			this.panel2.TabIndex = 19;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
			this.panel3.Controls.Add(this.lb_time);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 577);
			this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(886, 32);
			this.panel3.TabIndex = 20;
			// 
			// lb_time
			// 
			this.lb_time.AutoSize = true;
			this.lb_time.Font = new System.Drawing.Font("DS-Digital", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lb_time.Location = new System.Drawing.Point(734, 9);
			this.lb_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_time.Name = "lb_time";
			this.lb_time.Size = new System.Drawing.Size(52, 13);
			this.lb_time.TabIndex = 0;
			this.lb_time.Text = "lb_time";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// AddFilm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(886, 609);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AddFilm";
			this.Text = "AddFilm";
			this.Load += new System.EventHandler(this.AddFilm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhim;
        private System.Windows.Forms.TextBox txtCatagory;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Rt_info;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox ptb_Anh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer1;
    }
}