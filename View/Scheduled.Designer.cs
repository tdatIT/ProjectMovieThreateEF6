
namespace LTWin_Last
{
    partial class Suat
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
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Search = new System.Windows.Forms.Button();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgv_Schedule = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Schedule)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Add
			// 
			this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Add.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_Add.Location = new System.Drawing.Point(225, 449);
			this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(154, 51);
			this.btn_Add.TabIndex = 3;
			this.btn_Add.Text = "Thêm";
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btn_Update.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_Update.Location = new System.Drawing.Point(530, 449);
			this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(154, 51);
			this.btn_Update.TabIndex = 5;
			this.btn_Update.Text = "Cập nhật";
			this.btn_Update.UseVisualStyleBackColor = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.btn_Search);
			this.panel3.Controls.Add(this.txt_search);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(886, 78);
			this.panel3.TabIndex = 44;
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
			// 
			// txt_search
			// 
			this.txt_search.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.txt_search.Location = new System.Drawing.Point(225, 29);
			this.txt_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_search.Multiline = true;
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(409, 24);
			this.txt_search.TabIndex = 37;
			this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.dgv_Schedule);
			this.panel1.Location = new System.Drawing.Point(97, 117);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(700, 304);
			this.panel1.TabIndex = 45;
			// 
			// dgv_Schedule
			// 
			this.dgv_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dgv_Schedule.Location = new System.Drawing.Point(23, 26);
			this.dgv_Schedule.Name = "dgv_Schedule";
			this.dgv_Schedule.RowHeadersWidth = 51;
			this.dgv_Schedule.Size = new System.Drawing.Size(656, 260);
			this.dgv_Schedule.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Column1";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Column2";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Column3";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Column4";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Column5";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Column6";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.Width = 125;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.label1.Font = new System.Drawing.Font("Open Sans Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(115, 103);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 27);
			this.label1.TabIndex = 48;
			this.label1.Text = "Lịch chiếu trong ngày";
			// 
			// Suat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(886, 609);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.btn_Add);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Suat";
			this.Text = "SCHEDULED";
			this.Load += new System.EventHandler(this.Suat_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Schedule)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgv_Schedule;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}