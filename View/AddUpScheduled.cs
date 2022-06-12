using LTWin_Last.Controller;
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
	public partial class AddUpScheduled : Form
	{
		QueryData queryData;
		private ScheduledMovie scheduledEdit;
		private int request=0;

		public AddUpScheduled()
		{
			InitializeComponent();
			queryData = new QueryData();
		}
		public AddUpScheduled(ScheduledMovie scheduledEdit,int request)
		{
			InitializeComponent();
			this.scheduledEdit = scheduledEdit;
			this.request = request;
			queryData = new QueryData();
		}
		private void btn_Add_Click(object sender, EventArgs e)
		{
			switch (request)
			{
				case 0:
					{
						AddScheduled();
					}
					break;
				case 1:
					{
						UpdateScheduled();
					}
					break;
				default:
					break;
			}

		}

		private void AddSuat_Load(object sender, EventArgs e)
		{
			if(request == 1)
			{
				LoadDataForUpdate();
			}
			LoadDataRoomAndMovieId();
		}
		private void LoadDataForUpdate()
		{
			string dateStr =
			cbx_MovieId.Text = scheduledEdit.MovieId;
			cbx_RoomId.Text = scheduledEdit.RoomId + "";
			txt_day.Text = scheduledEdit.Begindate.ToString("dd");
			txt_month.Text = scheduledEdit.Begindate.ToString("MM");
			txt_year.Text = scheduledEdit.Begindate.ToString("yyyy");
			txt_Time.Text = scheduledEdit.Begindate.TimeOfDay + "";
		}
		private void LoadDataRoomAndMovieId()
		{

			try
			{
				var roomIdList = queryData.GetRoomData();
				var movieIdList = queryData.GetFilmAvailable();
				foreach (var i in roomIdList)
				{
					cbx_RoomId.Items.Add(i.Id);
				}
				foreach (var i in movieIdList)
				{
					cbx_MovieId.Items.Add(i.Id);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Load dữ liệu không thành công");
			}
		}
		private void AddScheduled()
		{
			DateTime date = DateTime.ParseExact(txt_day.Text + "-" + txt_month.Text + "-" + txt_year.Text + " " + txt_Time.Text, "dd-MM-yyyy HH:mm", null);
			string maphim = cbx_MovieId.Text;
			int maphong = int.Parse(cbx_RoomId.Text);
			using (var context = new MovieTheaterContext())
			{
				try
				{
					var schedule = new ScheduledMovie
					{

						Begindate = date,
						MovieId = maphim,
						RoomId = maphong
					};
					context.ScheduledMovies.Add(schedule);
					context.SaveChanges();
					MessageBox.Show("Thêm vào thành công !!!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception)
				{
					MessageBox.Show("Kiểm tra lại dữ liệu !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			txt_day.Text = "";
			txt_month.Text = "";
			txt_year.Text = "";
			txt_Time.Text = "";
			cbx_MovieId.Text = "";
			cbx_RoomId.Text = "";
		}
		private void UpdateScheduled()
		{
			DateTime date = DateTime.ParseExact(txt_day.Text + "-" + txt_month.Text + "-" + txt_year.Text + " " + txt_Time.Text, "dd-MM-yyyy HH:mm:ss", null);
			string maphim = cbx_MovieId.Text;
			int maphong = int.Parse(cbx_RoomId.Text);
			//set values for variable to update
			scheduledEdit.MovieId = maphim;
			scheduledEdit.RoomId = maphong;
			scheduledEdit.Begindate = date;
			//update
			using (var context = new MovieTheaterContext())
			{
				try
				{
					context.ScheduledMovies.Attach(scheduledEdit);
					context.Entry(scheduledEdit).State = System.Data.Entity.EntityState.Modified;

					context.SaveChanges();
					MessageBox.Show("Cập nhật thành công !!!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception)
				{
					MessageBox.Show("Kiểm tra lại dữ liệu !!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}

