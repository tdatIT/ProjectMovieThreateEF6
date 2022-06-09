
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
            this.btn_Yes = new System.Windows.Forms.RadioButton();
            this.btn_No = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_Poster = new System.Windows.Forms.PictureBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Rating = new System.Windows.Forms.TextBox();
            this.Rt_Description = new System.Windows.Forms.RichTextBox();
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
            this.label6.Location = new System.Drawing.Point(315, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
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
            this.btn_Add.Location = new System.Drawing.Point(609, 441);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(195, 49);
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
            this.label8.Location = new System.Drawing.Point(212, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "THÔNG TIN PHIM";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(109, 123);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(120, 29);
            this.txt_ID.TabIndex = 10;
            // 
            // txt_Category
            // 
            this.txt_Category.Location = new System.Drawing.Point(319, 123);
            this.txt_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(143, 29);
            this.txt_Category.TabIndex = 11;
            // 
            // txt_Minutes
            // 
            this.txt_Minutes.Location = new System.Drawing.Point(319, 218);
            this.txt_Minutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Minutes.Name = "txt_Minutes";
            this.txt_Minutes.Size = new System.Drawing.Size(143, 29);
            this.txt_Minutes.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Yes);
            this.panel1.Controls.Add(this.btn_No);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbx_Poster);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_Rating);
            this.panel1.Controls.Add(this.Rt_Description);
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
            this.panel1.Location = new System.Drawing.Point(121, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 541);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Yes
            // 
            this.btn_Yes.AutoSize = true;
            this.btn_Yes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Yes.Location = new System.Drawing.Point(253, 495);
            this.btn_Yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(57, 30);
            this.btn_Yes.TabIndex = 23;
            this.btn_Yes.TabStop = true;
            this.btn_Yes.Text = "Có";
            this.btn_Yes.UseVisualStyleBackColor = true;
            // 
            // btn_No
            // 
            this.btn_No.AutoSize = true;
            this.btn_No.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_No.Location = new System.Drawing.Point(367, 495);
            this.btn_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(87, 30);
            this.btn_No.TabIndex = 23;
            this.btn_No.TabStop = true;
            this.btn_No.Text = "Không";
            this.btn_No.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(105, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Trạng thái PV:";
            // 
            // pbx_Poster
            // 
            this.pbx_Poster.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Poster.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Poster.Image")));
            this.pbx_Poster.Location = new System.Drawing.Point(565, 46);
            this.pbx_Poster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbx_Poster.Name = "pbx_Poster";
            this.pbx_Poster.Size = new System.Drawing.Size(293, 350);
            this.pbx_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Poster.TabIndex = 21;
            this.pbx_Poster.TabStop = false;
            this.pbx_Poster.Click += new System.EventHandler(this.ptb_Anh_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(107, 46);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(352, 29);
            this.txt_Name.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(101, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 26);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tên Phim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(139, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 26);
            this.label11.TabIndex = 18;
            // 
            // txt_Rating
            // 
            this.txt_Rating.Location = new System.Drawing.Point(107, 218);
            this.txt_Rating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Rating.Name = "txt_Rating";
            this.txt_Rating.Size = new System.Drawing.Size(120, 29);
            this.txt_Rating.TabIndex = 17;
            // 
            // Rt_Description
            // 
            this.Rt_Description.Location = new System.Drawing.Point(107, 321);
            this.Rt_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rt_Description.Name = "Rt_Description";
            this.Rt_Description.Size = new System.Drawing.Size(352, 149);
            this.Rt_Description.TabIndex = 16;
            this.Rt_Description.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(105, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 26);
            this.label13.TabIndex = 4;
            this.label13.Text = "Đánh giá";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(315, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Thể loại";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(101, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã phim";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(472, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 41);
            this.label7.TabIndex = 18;
            this.label7.Text = "THÊM PHIM MỚI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 81);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.lb_time);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 711);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1181, 39);
            this.panel3.TabIndex = 20;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_time.Location = new System.Drawing.Point(979, 11);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(63, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1181, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RichTextBox Rt_Description;
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
		private System.Windows.Forms.RadioButton btn_Yes;
		private System.Windows.Forms.RadioButton btn_No;
		private System.Windows.Forms.Label label1;
	}
}