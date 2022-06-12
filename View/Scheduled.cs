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
	public partial class Suat : Form
	{
		ScheduledMovie scheduledSelected;
		public Suat()
		{
			InitializeComponent();
			scheduledSelected = new ScheduledMovie();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
		private void Suat_Load(object sender, EventArgs e)
		{
			initStyleDataGridView();
			txt_search.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
			XuatThongTin();
		}
		public void XuatThongTin()
		{
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				var data = dbcontext.ScheduledMovies.ToList();
				dgv_Schedule.DataSource = data;
				dgv_Schedule.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
				dgv_Schedule.Columns[7].DefaultCellStyle.Format = "HH:mm";
			}

		}

		void initStyleDataGridView()
		{

			dgv_Schedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
			dgv_Schedule.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
			dgv_Schedule.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
			dgv_Schedule.BackgroundColor = Color.White;
			//style rows
			dgv_Schedule.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgv_Schedule.EnableHeadersVisualStyles = false;
			dgv_Schedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			//style header
			dgv_Schedule.ColumnHeadersDefaultCellStyle.Font = new Font("Be VietNam Pro", 10);
			dgv_Schedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 33, 59);
			dgv_Schedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			XuatThongTin();
			MessageBox.Show("Cập nhật thành công !!!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txt_search_Click(object sender, EventArgs e)
		{

		}

		private void txt_search_TextChanged(object sender, EventArgs e)
		{
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				var data = dbcontext.ScheduledMovies.Where(x => x.Begindate.ToString().Contains(txt_search.Text)).ToList();
				dgv_Schedule.DataSource = data;
			}
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				DateTime dateTimeNow = DateTime.ParseExact(txt_search.Text, "dd-MM-yyyy", null);
				DateTime dateTomorrow = dateTimeNow.AddDays(1);
				var data = dbcontext.ScheduledMovies.Where(x => x.Begindate <= dateTomorrow && x.Begindate >= dateTimeNow).ToList();
				dgv_Schedule.DataSource = data;
			}
		}

		private void dgv_Schedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				if (scheduledSelected.Id == 0)
				{
					MessageBox.Show("Vui lòng dòng cần thực hiện", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					if (MessageBox.Show("Có chắc muốn xóa xuất chiếu ID[" + scheduledSelected.Id + "]",
						"Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					dbcontext.ScheduledMovies.Attach(scheduledSelected);
					dbcontext.Entry(scheduledSelected).State = System.Data.Entity.EntityState.Deleted;
					dbcontext.SaveChanges();
				}
			}

		}

		private void dgv_Schedule_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgv_Schedule_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{

		}

		private void dgv_Schedule_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgv_Schedule.Rows[e.RowIndex];
				scheduledSelected.Id = (int)row.Cells[0].Value;
				scheduledSelected.Begindate = DateTime.Parse(row.Cells[1].Value.ToString());
				scheduledSelected.RoomId = (int)row.Cells[3].Value;
				scheduledSelected.MovieId = row.Cells[2].Value.ToString();
			}
		}

		private void scheduledMovieBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddUpScheduled addSuat = new AddUpScheduled();
			addSuat.Show();
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (scheduledSelected.Id == 0)
			{
				MessageBox.Show("Vui lòng dòng cần thực hiện", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				AddUpScheduled addSuat = new AddUpScheduled(scheduledSelected, 1);
				addSuat.Show();
			}
		}
	}
}
