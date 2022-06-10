
namespace LTWin_Last
{
    partial class Analystic
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgv_Result = new System.Windows.Forms.DataGridView();
			this.btn_export = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_Search = new System.Windows.Forms.Button();
			this.cbx_Func = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(111, 120);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 24);
			this.label1.TabIndex = 52;
			this.label1.Text = "Kết quả";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.dgv_Result);
			this.panel1.Location = new System.Drawing.Point(93, 134);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(700, 313);
			this.panel1.TabIndex = 51;
			// 
			// dgv_Result
			// 
			this.dgv_Result.AllowUserToAddRows = false;
			this.dgv_Result.AllowUserToDeleteRows = false;
			this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Result.Location = new System.Drawing.Point(23, 26);
			this.dgv_Result.Name = "dgv_Result";
			this.dgv_Result.ReadOnly = true;
			this.dgv_Result.RowHeadersWidth = 51;
			this.dgv_Result.Size = new System.Drawing.Size(656, 260);
			this.dgv_Result.TabIndex = 0;
			// 
			// btn_export
			// 
			this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btn_export.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_export.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_export.Location = new System.Drawing.Point(394, 464);
			this.btn_export.Margin = new System.Windows.Forms.Padding(2);
			this.btn_export.Name = "btn_export";
			this.btn_export.Size = new System.Drawing.Size(127, 37);
			this.btn_export.TabIndex = 50;
			this.btn_export.Text = "Xuất File";
			this.btn_export.UseVisualStyleBackColor = false;
			this.btn_export.Click += new System.EventHandler(this.btn_Output_Click);
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(886, 47);
			this.panel2.TabIndex = 53;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
			this.panel3.Controls.Add(this.btn_Search);
			this.panel3.Controls.Add(this.cbx_Func);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 47);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(886, 58);
			this.panel3.TabIndex = 54;
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Search.Font = new System.Drawing.Font("Be Vietnam Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
			this.btn_Search.Location = new System.Drawing.Point(674, 14);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(40, 31);
			this.btn_Search.TabIndex = 2;
			this.btn_Search.Text = "🔎";
			this.btn_Search.UseVisualStyleBackColor = false;
			// 
			// cbx_Func
			// 
			this.cbx_Func.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Func.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Func.FormattingEnabled = true;
			this.cbx_Func.Items.AddRange(new object[] {
            "Xem tất cả nhân viên"});
			this.cbx_Func.Location = new System.Drawing.Point(308, 16);
			this.cbx_Func.Name = "cbx_Func";
			this.cbx_Func.Size = new System.Drawing.Size(349, 27);
			this.cbx_Func.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.label2.Font = new System.Drawing.Font("Be Vietnam Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.label2.Location = new System.Drawing.Point(164, 15);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(1);
			this.label2.Size = new System.Drawing.Size(117, 31);
			this.label2.TabIndex = 0;
			this.label2.Text = "Chức năng";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Title = "Lưu file tại vị trí";
			// 
			// Analystic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(886, 609);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_export);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Analystic";
			this.Text = "ANALYTIC";
			this.Load += new System.EventHandler(this.Analystic_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgv_Result;
		private System.Windows.Forms.Button btn_export;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox cbx_Func;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}