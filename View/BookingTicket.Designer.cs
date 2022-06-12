
namespace LTWin_Last
{
    partial class Book
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.dgv_BookingTicket = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_C_phone_number = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbx_Day = new System.Windows.Forms.ComboBox();
			this.cbx_Month = new System.Windows.Forms.ComboBox();
			this.cbx_Year = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_Booking = new System.Windows.Forms.Button();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_BookingTicket)).BeginInit();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.panel5.Controls.Add(this.dgv_BookingTicket);
			this.panel5.Location = new System.Drawing.Point(268, 131);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(557, 347);
			this.panel5.TabIndex = 24;
			// 
			// dgv_BookingTicket
			// 
			this.dgv_BookingTicket.AllowUserToAddRows = false;
			this.dgv_BookingTicket.AllowUserToDeleteRows = false;
			this.dgv_BookingTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_BookingTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dgv_BookingTicket.Location = new System.Drawing.Point(17, 25);
			this.dgv_BookingTicket.Name = "dgv_BookingTicket";
			this.dgv_BookingTicket.ReadOnly = true;
			this.dgv_BookingTicket.RowHeadersWidth = 51;
			this.dgv_BookingTicket.Size = new System.Drawing.Size(540, 298);
			this.dgv_BookingTicket.TabIndex = 0;
			this.dgv_BookingTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BookingTicket_CellClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Name";
			this.Column1.HeaderText = "Tên Phim";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 250;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "BeginDate";
			this.Column2.FillWeight = 150F;
			this.Column2.HeaderText = "Giờ chiếu";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "countSeats";
			this.Column3.HeaderText = "Ghế trống";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 80;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Id";
			this.Column4.HeaderText = "ID SC";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 50;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(39, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(353, 92);
			this.label7.TabIndex = 36;
			this.label7.Text = "Thông tin khách hàng \r\nvà vé";
			// 
			// txt_C_phone_number
			// 
			this.txt_C_phone_number.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_C_phone_number.Location = new System.Drawing.Point(54, 198);
			this.txt_C_phone_number.Name = "txt_C_phone_number";
			this.txt_C_phone_number.Size = new System.Drawing.Size(179, 25);
			this.txt_C_phone_number.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(50, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 23);
			this.label1.TabIndex = 38;
			this.label1.Text = "Số điện thoại KH";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Be Vietnam Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(449, 73);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 32);
			this.label2.TabIndex = 40;
			this.label2.Text = "🔎︎";
			// 
			// cbx_Day
			// 
			this.cbx_Day.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Day.FormattingEnabled = true;
			this.cbx_Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
			this.cbx_Day.Location = new System.Drawing.Point(54, 264);
			this.cbx_Day.Name = "cbx_Day";
			this.cbx_Day.Size = new System.Drawing.Size(47, 25);
			this.cbx_Day.TabIndex = 41;
			// 
			// cbx_Month
			// 
			this.cbx_Month.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Month.FormattingEnabled = true;
			this.cbx_Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
			this.cbx_Month.Location = new System.Drawing.Point(111, 264);
			this.cbx_Month.Name = "cbx_Month";
			this.cbx_Month.Size = new System.Drawing.Size(47, 25);
			this.cbx_Month.TabIndex = 42;
			// 
			// cbx_Year
			// 
			this.cbx_Year.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Year.FormattingEnabled = true;
			this.cbx_Year.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
			this.cbx_Year.Location = new System.Drawing.Point(173, 264);
			this.cbx_Year.Name = "cbx_Year";
			this.cbx_Year.Size = new System.Drawing.Size(60, 25);
			this.cbx_Year.TabIndex = 43;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(50, 238);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 23);
			this.label3.TabIndex = 44;
			this.label3.Text = "Ngày chiếu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Open Sans Condensed", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(50, 338);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 38);
			this.label4.TabIndex = 45;
			this.label4.Text = "*Vui lòng chọn lịch chiếu \r\n  trước khi chọn đặt vé";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.label5.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(284, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 23);
			this.label5.TabIndex = 46;
			this.label5.Text = "Chọn lịch chiếu";
			// 
			// btn_Booking
			// 
			this.btn_Booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Booking.FlatAppearance.BorderSize = 0;
			this.btn_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Booking.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Booking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Booking.Location = new System.Drawing.Point(54, 403);
			this.btn_Booking.Name = "btn_Booking";
			this.btn_Booking.Size = new System.Drawing.Size(179, 36);
			this.btn_Booking.TabIndex = 47;
			this.btn_Booking.Text = "Đặt vé";
			this.btn_Booking.UseVisualStyleBackColor = false;
			this.btn_Booking.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// txt_search
			// 
			this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txt_search.Location = new System.Drawing.Point(532, 81);
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(278, 21);
			this.txt_search.TabIndex = 48;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Be Vietnam Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.button1.Location = new System.Drawing.Point(54, 300);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 26);
			this.button1.TabIndex = 49;
			this.button1.Text = "Lọc theo ngày";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_2);
			// 
			// Book
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(886, 530);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_search);
			this.Controls.Add(this.btn_Booking);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbx_Year);
			this.Controls.Add(this.cbx_Month);
			this.Controls.Add(this.cbx_Day);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_C_phone_number);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel5);
			this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Book";
			this.Text = "Booking";
			this.Load += new System.EventHandler(this.Book_Load);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_BookingTicket)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgv_BookingTicket;
		private System.Windows.Forms.TextBox txt_C_phone_number;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbx_Day;
		private System.Windows.Forms.ComboBox cbx_Month;
		private System.Windows.Forms.ComboBox cbx_Year;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_Booking;
		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}