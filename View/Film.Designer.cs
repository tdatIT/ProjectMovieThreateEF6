
namespace LTWin_Last
{
    partial class FilmForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmForm));
			this.panel5 = new System.Windows.Forms.Panel();
			this.btn_Detail = new System.Windows.Forms.Button();
			this.pbx_Poster = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Add = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cbx_search = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Search = new System.Windows.Forms.Button();
			this.btn_Previous = new System.Windows.Forms.Button();
			this.btn_Foward = new System.Windows.Forms.Button();
			this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_Poster)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.panel5.Controls.Add(this.btn_Detail);
			this.panel5.Controls.Add(this.pbx_Poster);
			this.panel5.Location = new System.Drawing.Point(203, 155);
			this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(208, 305);
			this.panel5.TabIndex = 40;
			// 
			// btn_Detail
			// 
			this.btn_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Detail.Font = new System.Drawing.Font("Open Sans Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Detail.Location = new System.Drawing.Point(56, 232);
			this.btn_Detail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Detail.Name = "btn_Detail";
			this.btn_Detail.Size = new System.Drawing.Size(105, 27);
			this.btn_Detail.TabIndex = 29;
			this.btn_Detail.Text = "Chi tiết";
			this.btn_Detail.UseVisualStyleBackColor = false;
			this.btn_Detail.Click += new System.EventHandler(this.button5_Click);
			// 
			// pbx_Poster
			// 
			this.pbx_Poster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_Poster.BackgroundImage")));
			this.pbx_Poster.Image = global::LTWin_Last.Properties.Resources.tải_xuống;
			this.pbx_Poster.Location = new System.Drawing.Point(32, 21);
			this.pbx_Poster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pbx_Poster.Name = "pbx_Poster";
			this.pbx_Poster.Size = new System.Drawing.Size(147, 185);
			this.pbx_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbx_Poster.TabIndex = 42;
			this.pbx_Poster.TabStop = false;
			this.pbx_Poster.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.btn_Add);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(466, 155);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(205, 305);
			this.panel1.TabIndex = 41;
			// 
			// btn_Add
			// 
			this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Add.Font = new System.Drawing.Font("Open Sans Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Add.Location = new System.Drawing.Point(59, 230);
			this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(99, 27);
			this.btn_Add.TabIndex = 29;
			this.btn_Add.Text = "Thêm phim";
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(30, 21);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(147, 185);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(886, 40);
			this.panel2.TabIndex = 42;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
			this.panel3.Controls.Add(this.cbx_search);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.btn_Search);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(886, 78);
			this.panel3.TabIndex = 43;
			// 
			// cbx_search
			// 
			this.cbx_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbx_search.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_search.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.cbx_search.FormattingEnabled = true;
			this.cbx_search.Location = new System.Drawing.Point(212, 23);
			this.cbx_search.Name = "cbx_search";
			this.cbx_search.Size = new System.Drawing.Size(431, 32);
			this.cbx_search.TabIndex = 40;
			this.cbx_search.Text = "Tên phim";
			this.cbx_search.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.cbx_search.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			this.cbx_search.Click += new System.EventHandler(this.comboBox1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Be Vietnam Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(144, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 32);
			this.label2.TabIndex = 39;
			this.label2.Text = "🔎︎";
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Search.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Search.Location = new System.Drawing.Point(666, 26);
			this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(96, 31);
			this.btn_Search.TabIndex = 38;
			this.btn_Search.Text = "Tìm kiếm";
			this.btn_Search.UseVisualStyleBackColor = false;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// btn_Previous
			// 
			this.btn_Previous.FlatAppearance.BorderSize = 0;
			this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Previous.Font = new System.Drawing.Font("Be Vietnam Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Previous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Previous.Location = new System.Drawing.Point(126, 239);
			this.btn_Previous.Name = "btn_Previous";
			this.btn_Previous.Size = new System.Drawing.Size(72, 122);
			this.btn_Previous.TabIndex = 44;
			this.btn_Previous.Text = "ᐸ";
			this.btn_Previous.UseVisualStyleBackColor = true;
			this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
			// 
			// btn_Foward
			// 
			this.btn_Foward.FlatAppearance.BorderSize = 0;
			this.btn_Foward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Foward.Font = new System.Drawing.Font("Be Vietnam Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Foward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Foward.Location = new System.Drawing.Point(676, 239);
			this.btn_Foward.Name = "btn_Foward";
			this.btn_Foward.Size = new System.Drawing.Size(72, 122);
			this.btn_Foward.TabIndex = 45;
			this.btn_Foward.Text = "ᐳ";
			this.btn_Foward.UseVisualStyleBackColor = true;
			this.btn_Foward.Click += new System.EventHandler(this.btn_Foward_Click);
			// 
			// entityCommand1
			// 
			this.entityCommand1.CommandTimeout = 0;
			this.entityCommand1.CommandTree = null;
			this.entityCommand1.Connection = null;
			this.entityCommand1.EnablePlanCaching = true;
			this.entityCommand1.Transaction = null;
			// 
			// FilmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(886, 609);
			this.Controls.Add(this.btn_Foward);
			this.Controls.Add(this.btn_Previous);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel5);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FilmForm";
			this.Text = "FILM";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbx_Poster)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.PictureBox pbx_Poster;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Button btn_Previous;
		private System.Windows.Forms.Button btn_Foward;
		private System.Windows.Forms.ComboBox cbx_search;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}