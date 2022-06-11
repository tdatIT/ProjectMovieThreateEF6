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
	public partial class AddSuat : Form
	{
		public AddSuat()
		{
			InitializeComponent();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			
			DateTime date = DateTime.ParseExact(txt_day.Text + "-" + txt_month.Text + "-" + txt_year.Text + " " + txt_Time.Text,"dd-MM-yyyy HH:mm:ss",null);
			string maphim = txt_MovieID.Text;
			int maphong = int.Parse(txt_RoomID.Text);
			using (var context = new MovieTheaterContext())
			{
				try
				{
					var schedule = new ScheduledMovie
					{
						
						Begindate = date,
						MovieId = maphim,
						RoomId= maphong
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
			txt_MovieID.Text = "";
			txt_RoomID.Text = "";

		}
	}
}
