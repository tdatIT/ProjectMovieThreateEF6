using LTWin_Last.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
			initStyleDataGridView();
        }
		void initStyleDataGridView()
		{

			dgv_BookingTicket.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
			dgv_BookingTicket.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
			dgv_BookingTicket.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
			dgv_BookingTicket.BackgroundColor = Color.White;
			//style rows
			dgv_BookingTicket.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgv_BookingTicket.EnableHeadersVisualStyles = false;
			dgv_BookingTicket.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			//style header
			dgv_BookingTicket.ColumnHeadersDefaultCellStyle.Font = new Font("Be VietNam Pro", 10);
			dgv_BookingTicket.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 33, 59);
			dgv_BookingTicket.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			BookingTicket bookingTicket = new BookingTicket();
			bookingTicket.Visible = true;
		}
	}
}
