using LTWin_Last.Controller;
using LTWin_Last.View;
using Project_LT_Windows_EF6.Model;
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
		private QueryData query;
		private ScheduledMovie scheduled=null;

		public Book()
        {
            InitializeComponent();
			initStyleDataGridView();
			query = new QueryData();
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
			DateTime getNow = DateTime.Now;
			cbx_Day.Text = getNow.ToString("dd");
			cbx_Month.Text = getNow.ToString("MM");
			cbx_Year.Text = getNow.ToString("yyyy");
			button1_Click_2(sender, e);
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
			string sdt = txt_C_phone_number.Text ;
			if (scheduled != null && sdt != "")
			{
				BookingTicket bookingTicket = new BookingTicket(scheduled,sdt);
				bookingTicket.Show();
			}
			else
				MessageBox.Show("Vui lòng chọn suất chiếu hoặc số điện thoại", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			try
			{
				string date = cbx_Year.Text + "-" + cbx_Month.Text +"-"+ cbx_Day.Text;
				DateTime dateFilter = DateTime.Parse(date);
				dgv_BookingTicket.DataSource = query.GetDataFilmAndScheduled(dateFilter);
			}
			catch (Exception)
			{
				MessageBox.Show("Kiểm tra lại ngày tháng !!!", "Thất bại", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgv_BookingTicket_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgv_BookingTicket.Rows[e.RowIndex];
				int id = (int)row.Cells[3].Value;
				using (var context = new MovieTheaterContext())
				{
					scheduled = context.ScheduledMovies.Find(id);
				}
			}
			
		}
	}
}
