
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
			this.btn_Add = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_ID = new System.Windows.Forms.TextBox();
			this.txt_Category = new System.Windows.Forms.TextBox();
			this.txt_Minutes = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbtn_Yes = new System.Windows.Forms.RadioButton();
			this.rbtn_No = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.pbx_Poster = new System.Windows.Forms.PictureBox();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_Rating = new System.Windows.Forms.TextBox();
			this.rtxt_Description = new System.Windows.Forms.RichTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lb_time = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_Poster)).BeginInit();
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
			// btn_Add
			// 
			this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(169)))), ((int)(((byte)(67)))));
			this.btn_Add.FlatAppearance.BorderSize = 0;
			this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_Add.Location = new System.Drawing.Point(457, 358);
			this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(146, 40);
			this.btn_Add.TabIndex = 7;
			this.btn_Add.Text = "THÊM PHIM";
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.button1_Click);
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
			// txt_ID
			// 
			this.txt_ID.Location = new System.Drawing.Point(82, 100);
			this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_ID.Name = "txt_ID";
			this.txt_ID.Size = new System.Drawing.Size(91, 25);
			this.txt_ID.TabIndex = 10;
			// 
			// txt_Category
			// 
			this.txt_Category.Location = new System.Drawing.Point(239, 100);
			this.txt_Category.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Category.Name = "txt_Category";
			this.txt_Category.Size = new System.Drawing.Size(108, 25);
			this.txt_Category.TabIndex = 11;
			// 
			// txt_Minutes
			// 
			this.txt_Minutes.Location = new System.Drawing.Point(239, 177);
			this.txt_Minutes.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Minutes.Name = "txt_Minutes";
			this.txt_Minutes.Size = new System.Drawing.Size(108, 25);
			this.txt_Minutes.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.rbtn_Yes);
			this.panel1.Controls.Add(this.rbtn_No);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pbx_Poster);
			this.panel1.Controls.Add(this.txt_Name);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.txt_Rating);
			this.panel1.Controls.Add(this.rtxt_Description);
			this.panel1.Controls.Add(this.txt_Minutes);
			this.panel1.Controls.Add(this.txt_Category);
			this.panel1.Controls.Add(this.txt_ID);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.btn_Add);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(85, 98);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(702, 440);
			this.panel1.TabIndex = 16;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// rbtn_Yes
			// 
			this.rbtn_Yes.AutoSize = true;
			this.rbtn_Yes.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rbtn_Yes.Location = new System.Drawing.Point(190, 402);
			this.rbtn_Yes.Name = "rbtn_Yes";
			this.rbtn_Yes.Size = new System.Drawing.Size(48, 26);
			this.rbtn_Yes.TabIndex = 23;
			this.rbtn_Yes.TabStop = true;
			this.rbtn_Yes.Text = "Có";
			this.rbtn_Yes.UseVisualStyleBackColor = true;
			// 
			// rbtn_No
			// 
			this.rbtn_No.AutoSize = true;
			this.rbtn_No.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rbtn_No.Location = new System.Drawing.Point(275, 402);
			this.rbtn_No.Name = "rbtn_No";
			this.rbtn_No.Size = new System.Drawing.Size(72, 26);
			this.rbtn_No.TabIndex = 23;
			this.rbtn_No.TabStop = true;
			this.rbtn_No.Text = "Không";
			this.rbtn_No.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(79, 404);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 22);
			this.label1.TabIndex = 22;
			this.label1.Text = "Trạng thái PV:";
			// 
			// pbx_Poster
			// 
			this.pbx_Poster.BackColor = System.Drawing.Color.Transparent;
			this.pbx_Poster.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Poster.Image")));
			this.pbx_Poster.Location = new System.Drawing.Point(424, 37);
			this.pbx_Poster.Margin = new System.Windows.Forms.Padding(2);
			this.pbx_Poster.Name = "pbx_Poster";
			this.pbx_Poster.Size = new System.Drawing.Size(220, 284);
			this.pbx_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbx_Poster.TabIndex = 21;
			this.pbx_Poster.TabStop = false;
			this.pbx_Poster.Click += new System.EventHandler(this.ptb_Anh_Click);
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(80, 37);
			this.txt_Name.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(265, 25);
			this.txt_Name.TabIndex = 20;
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
			// txt_Rating
			// 
			this.txt_Rating.Location = new System.Drawing.Point(80, 177);
			this.txt_Rating.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Rating.Name = "txt_Rating";
			this.txt_Rating.Size = new System.Drawing.Size(91, 25);
			this.txt_Rating.TabIndex = 17;
			// 
			// rtxt_Description
			// 
			this.rtxt_Description.Location = new System.Drawing.Point(80, 261);
			this.rtxt_Description.Margin = new System.Windows.Forms.Padding(2);
			this.rtxt_Description.Name = "rtxt_Description";
			this.rtxt_Description.Size = new System.Drawing.Size(265, 122);
			this.rtxt_Description.TabIndex = 16;
			this.rtxt_Description.Text = "";
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
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(886, 66);
			this.panel2.TabIndex = 19;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
			this.panel3.Controls.Add(this.lb_time);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 577);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(886, 32);
			this.panel3.TabIndex = 20;
			// 
			// lb_time
			// 
			this.lb_time.AutoSize = true;
			this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lb_time.Location = new System.Drawing.Point(734, 9);
			this.lb_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_time.Name = "lb_time";
			this.lb_time.Size = new System.Drawing.Size(53, 17);
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
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AddFilm";
			this.Text = "AddFilm";
			this.Load += new System.EventHandler(this.AddFilm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_Poster)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.TextBox txt_Minutes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxt_Description;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Rating;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbx_Poster;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.RadioButton rbtn_Yes;
		private System.Windows.Forms.RadioButton rbtn_No;
		private System.Windows.Forms.Label label1;
	}
}