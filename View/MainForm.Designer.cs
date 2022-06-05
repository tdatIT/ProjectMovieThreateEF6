
namespace LTWin_Last
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pn_title = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.bnt_Back = new System.Windows.Forms.Button();
			this.pn_menu = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_Ptich = new System.Windows.Forms.Button();
			this.btn_KH = new System.Windows.Forms.Button();
			this.btn_Phim = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Suat = new System.Windows.Forms.Button();
			this.pn_child = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.lb_Time = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pn_title.SuspendLayout();
			this.pn_menu.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pn_child.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pn_title
			// 
			this.pn_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
			this.pn_title.Controls.Add(this.button5);
			this.pn_title.Controls.Add(this.btn_Exit);
			this.pn_title.Controls.Add(this.lbl_Title);
			this.pn_title.Controls.Add(this.bnt_Back);
			this.pn_title.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_title.Location = new System.Drawing.Point(188, 0);
			this.pn_title.Margin = new System.Windows.Forms.Padding(2);
			this.pn_title.Name = "pn_title";
			this.pn_title.Size = new System.Drawing.Size(840, 62);
			this.pn_title.TabIndex = 7;
			this.pn_title.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_title_Paint);
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Right;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(701, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(70, 62);
			this.button5.TabIndex = 3;
			this.button5.Text = "🢓";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click_1);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
			this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
			this.btn_Exit.FlatAppearance.BorderSize = 0;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btn_Exit.Location = new System.Drawing.Point(771, 0);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(69, 62);
			this.btn_Exit.TabIndex = 2;
			this.btn_Exit.Text = "✖";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.button5_Click);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.Font = new System.Drawing.Font("Be Vietnam Pro Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_Title.Location = new System.Drawing.Point(66, 10);
			this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(179, 41);
			this.lbl_Title.TabIndex = 1;
			this.lbl_Title.Text = "TRANG CHỦ";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bnt_Back
			// 
			this.bnt_Back.BackColor = System.Drawing.Color.Transparent;
			this.bnt_Back.FlatAppearance.BorderSize = 0;
			this.bnt_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnt_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.bnt_Back.Location = new System.Drawing.Point(4, 7);
			this.bnt_Back.Margin = new System.Windows.Forms.Padding(2);
			this.bnt_Back.Name = "bnt_Back";
			this.bnt_Back.Size = new System.Drawing.Size(58, 50);
			this.bnt_Back.TabIndex = 0;
			this.bnt_Back.Text = "🔙";
			this.bnt_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnt_Back.UseVisualStyleBackColor = false;
			this.bnt_Back.Click += new System.EventHandler(this.bnt_Back_Click);
			// 
			// pn_menu
			// 
			this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.pn_menu.Controls.Add(this.panel2);
			this.pn_menu.Controls.Add(this.btn_Ptich);
			this.pn_menu.Controls.Add(this.btn_KH);
			this.pn_menu.Controls.Add(this.btn_Phim);
			this.pn_menu.Controls.Add(this.label1);
			this.pn_menu.Controls.Add(this.btn_Suat);
			this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pn_menu.Location = new System.Drawing.Point(0, 0);
			this.pn_menu.Margin = new System.Windows.Forms.Padding(2);
			this.pn_menu.Name = "pn_menu";
			this.pn_menu.Size = new System.Drawing.Size(188, 609);
			this.pn_menu.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(188, 112);
			this.panel2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(8, 20);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 62);
			this.label4.TabIndex = 2;
			this.label4.Text = "DHD\r\n Movie Threater";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Ptich
			// 
			this.btn_Ptich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Ptich.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Ptich.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ptich.Image")));
			this.btn_Ptich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Ptich.Location = new System.Drawing.Point(9, 503);
			this.btn_Ptich.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Ptich.Name = "btn_Ptich";
			this.btn_Ptich.Size = new System.Drawing.Size(164, 66);
			this.btn_Ptich.TabIndex = 4;
			this.btn_Ptich.Text = "      Phân       tích";
			this.btn_Ptich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_Ptich.UseVisualStyleBackColor = false;
			this.btn_Ptich.Click += new System.EventHandler(this.btn_Ptich_Click);
			// 
			// btn_KH
			// 
			this.btn_KH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_KH.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_KH.Image = ((System.Drawing.Image)(resources.GetObject("btn_KH.Image")));
			this.btn_KH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_KH.Location = new System.Drawing.Point(9, 273);
			this.btn_KH.Margin = new System.Windows.Forms.Padding(2);
			this.btn_KH.Name = "btn_KH";
			this.btn_KH.Size = new System.Drawing.Size(164, 61);
			this.btn_KH.TabIndex = 2;
			this.btn_KH.Text = "    Khách     hàng";
			this.btn_KH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_KH.UseVisualStyleBackColor = false;
			this.btn_KH.Click += new System.EventHandler(this.btn_KH_Click);
			// 
			// btn_Phim
			// 
			this.btn_Phim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Phim.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Phim.Image = ((System.Drawing.Image)(resources.GetObject("btn_Phim.Image")));
			this.btn_Phim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Phim.Location = new System.Drawing.Point(9, 389);
			this.btn_Phim.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Phim.Name = "btn_Phim";
			this.btn_Phim.Size = new System.Drawing.Size(164, 63);
			this.btn_Phim.TabIndex = 3;
			this.btn_Phim.Text = "      Phim";
			this.btn_Phim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_Phim.UseVisualStyleBackColor = false;
			this.btn_Phim.Click += new System.EventHandler(this.btn_Phim_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Brown;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(37, 692);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Verson 0.0";
			// 
			// btn_Suat
			// 
			this.btn_Suat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Suat.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Suat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Suat.Image")));
			this.btn_Suat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Suat.Location = new System.Drawing.Point(14, 159);
			this.btn_Suat.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Suat.Name = "btn_Suat";
			this.btn_Suat.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Suat.Size = new System.Drawing.Size(160, 64);
			this.btn_Suat.TabIndex = 1;
			this.btn_Suat.Text = "    Suất      chiếu";
			this.btn_Suat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_Suat.UseVisualStyleBackColor = false;
			this.btn_Suat.Click += new System.EventHandler(this.btn_Suat_Click);
			// 
			// pn_child
			// 
			this.pn_child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.pn_child.Controls.Add(this.label9);
			this.pn_child.Controls.Add(this.panel4);
			this.pn_child.Controls.Add(this.panel3);
			this.pn_child.Controls.Add(this.panel1);
			this.pn_child.Controls.Add(this.button4);
			this.pn_child.Controls.Add(this.button3);
			this.pn_child.Controls.Add(this.button2);
			this.pn_child.Controls.Add(this.button1);
			this.pn_child.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pn_child.Location = new System.Drawing.Point(188, 62);
			this.pn_child.Margin = new System.Windows.Forms.Padding(2);
			this.pn_child.Name = "pn_child";
			this.pn_child.Size = new System.Drawing.Size(840, 547);
			this.pn_child.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.label9.Font = new System.Drawing.Font("Open Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.Location = new System.Drawing.Point(656, 31);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 31);
			this.label9.TabIndex = 10;
			this.label9.Text = "Phim Hot";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.panel4.Controls.Add(this.webView21);
			this.panel4.Location = new System.Drawing.Point(385, 61);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(369, 211);
			this.panel4.TabIndex = 9;
			// 
			// webView21
			// 
			this.webView21.AllowExternalDrop = true;
			this.webView21.CreationProperties = null;
			this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webView21.Location = new System.Drawing.Point(0, 0);
			this.webView21.Name = "webView21";
			this.webView21.Size = new System.Drawing.Size(369, 211);
			this.webView21.Source = new System.Uri("https://www.youtube.com/embed/nBNtRvpCmms", System.UriKind.Absolute);
			this.webView21.TabIndex = 8;
			this.webView21.ZoomFactor = 1D;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.lb_Time);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(86, 61);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(266, 211);
			this.panel3.TabIndex = 5;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Open Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(27, 140);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 19);
			this.label8.TabIndex = 11;
			this.label8.Text = "▶";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb_Time
			// 
			this.lb_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lb_Time.AutoSize = true;
			this.lb_Time.Font = new System.Drawing.Font("Open Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lb_Time.Location = new System.Drawing.Point(51, 131);
			this.lb_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Time.Name = "lb_Time";
			this.lb_Time.Size = new System.Drawing.Size(55, 31);
			this.lb_Time.TabIndex = 10;
			this.lb_Time.Text = "00:00";
			this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Open Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(27, 90);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 19);
			this.label7.TabIndex = 9;
			this.label7.Text = "▶";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Open Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(51, 83);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 31);
			this.label6.TabIndex = 8;
			this.label6.Text = "Nguyễn Văn A";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Be Vietnam Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(25, 36);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 36);
			this.label5.TabIndex = 7;
			this.label5.Text = "Xin chào";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 515);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 32);
			this.panel1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(307, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "By Tien Dat - Thanh Danh - Ngoc Hai";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(767, 6);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ver 1.0.2a";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button4.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(613, 325);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(95, 147);
			this.button4.TabIndex = 3;
			this.button4.Text = "Thêm Phim";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button3.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(448, 325);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(107, 147);
			this.button3.TabIndex = 2;
			this.button3.Text = "Thêm Xuất Chiếu";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button2.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(245, 325);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 147);
			this.button2.TabIndex = 1;
			this.button2.Text = "Thêm \r\nKhách Hàng\r\n";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(86, 325);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 147);
			this.button1.TabIndex = 0;
			this.button1.Text = "Đặt \r\nphim";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 609);
			this.Controls.Add(this.pn_child);
			this.Controls.Add(this.pn_title);
			this.Controls.Add(this.pn_menu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.pn_title.ResumeLayout(false);
			this.pn_title.PerformLayout();
			this.pn_menu.ResumeLayout(false);
			this.pn_menu.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pn_child.ResumeLayout(false);
			this.pn_child.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Button btn_Ptich;
        private System.Windows.Forms.Button btn_KH;
        private System.Windows.Forms.Button btn_Phim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Suat;
        private System.Windows.Forms.Button bnt_Back;
        private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pn_child;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel4;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lb_Time;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
	}
}

