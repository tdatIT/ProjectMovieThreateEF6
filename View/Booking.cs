using LTWin_Last.Controller;
using LTWin_Last.Model;
using Project_LT_Windows_EF6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last.View
{
	public partial class BookingTicket : Form
	{
		private List<ENoSeats> NoSeats;
		private string sdt;
		private ScheduledMovie SelectSche;
		private Movie movie;
		private QueryData query;
		private int price = 0;

		public BookingTicket(ScheduledMovie sc, string sdt)
		{
			InitializeComponent();
			SelectSche = sc;
			NoSeats = new List<ENoSeats>();
			query = new QueryData();
			this.sdt = sdt+" ";
			StatusSeatsAva();
		}
		private void LoadDataMovieOnForm()
		{
			using (var context = new MovieTheaterContext())
			{
				try
				{
					//load data film
					string id = SelectSche.MovieId;
					movie = context.Movies.Find(id);
					lb_namefilm.Text = movie.Name;
					lb_Rating.Text = movie.Rating + "/5";
					lb_Category.Text = movie.Catagory;
					lb_Minutes.Text = movie.Minutes + "min";
					pbx_Poster.Image = ByteArrayToImage(movie.Poster);
					//load data schedule
					lb_room.Text = SelectSche.RoomId + "";
					lb_time.Text = SelectSche.Begindate.ToString("hh:mm");
					lb_Day.Text = SelectSche.Begindate.ToString("dd");
					lb_Month.Text = SelectSche.Begindate.ToString("MM");
					lb_year.Text = SelectSche.Begindate.ToString("yyyy");
					lb_sdt.Text += "  " + sdt;
				}
				catch (Exception)
				{
					MessageBox.Show("Load dữ liệu phim không thành công !!!", "Thông báo",
					   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void BookTickets()
		{

		}
		private void StatusSeatsAva()
		{
			List<ENoSeats> es = query.NoSeatsNotAva(SelectSche.Id);
			foreach (var seats in es)
			{
				string CtrlName = "btn_" + seats.ToString();
				(this.Controls.Find(CtrlName, true).First()).BackColor = Color.Yellow;
				(this.Controls.Find(CtrlName, true).First()).Enabled = false;

			}
		}
		private Image ByteArrayToImage(byte[] byteArr)
		{
			MemoryStream ms = new MemoryStream(byteArr);
			Image image = Image.FromStream(ms);
			return image;
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void BookingTicket_Load(object sender, EventArgs e)
		{
			LoadDataMovieOnForm();
			
		}

		private void btn_Insert_Click(object sender, EventArgs e)
		{

		}

		private void button33_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

			NoSeats.Add(ENoSeats.A00);
			lb_seat.Text += "/" + ENoSeats.A00.ToString();
			btn_A00.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.A01);
			lb_seat.Text += "/" + ENoSeats.A01.ToString();
			btn_A01.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";

		}

		private void btn_VIP1_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.VIP01);
			lb_seat.Text += "/" + ENoSeats.VIP01.ToString();
			btn_VIP01.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_A2_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.A02);
			lb_seat.Text += "/" + ENoSeats.A02.ToString();
			btn_A02.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_A3_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.A03);
			lb_seat.Text += "/" + ENoSeats.A03.ToString();
			btn_A03.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_A4_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.A04);
			lb_seat.Text += "/" + ENoSeats.A04.ToString();
			btn_A04.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_A5_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.A05);
			lb_seat.Text += "/" + ENoSeats.A05.ToString();
			btn_A05.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_A6_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.A06);
			lb_seat.Text += "/" + ENoSeats.A06.ToString();
			btn_A06.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_A7_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.A07);
			lb_seat.Text += "/" + ENoSeats.A07.ToString();
			btn_A07.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_B0_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.B00);
			lb_seat.Text += "/" + ENoSeats.B00.ToString();
			btn_B00.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_B1_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.B01);
			lb_seat.Text += "/" + ENoSeats.B01.ToString();
			btn_B01.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_B2_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.B02);
			lb_seat.Text += "/" + ENoSeats.B02.ToString();
			btn_B02.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_B3_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.B03);
			lb_seat.Text += "/" + ENoSeats.B03.ToString();
			btn_B03.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_B4_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.B04);
			lb_seat.Text += "/" + ENoSeats.B04.ToString();
			btn_B04.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_B5_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.B05);
			lb_seat.Text += "/" + ENoSeats.B05.ToString();
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_B6_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.B06);
			lb_seat.Text += "/" + ENoSeats.B06.ToString();
			btn_B06.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_B7_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.B07);
			lb_seat.Text += "/" + ENoSeats.B07.ToString();
			btn_B07.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_C0_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.C00);
			lb_seat.Text += "/" + ENoSeats.C00.ToString();
			btn_C00.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_C1_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.C01);
			lb_seat.Text += "/" + ENoSeats.C01.ToString();
			btn_C01.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_C2_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.C02);
			lb_seat.Text += "/" + ENoSeats.C02.ToString();
			btn_C02.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_C3_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.C03);
			lb_seat.Text += "/" + ENoSeats.C03.ToString();
			btn_C03.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_C4_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.C04);
			lb_seat.Text += "/" + ENoSeats.C04.ToString();
			btn_C04.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_C5_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.C05);
			lb_seat.Text += "/" + ENoSeats.C05.ToString();
			btn_C05.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_C6_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.C06);
			lb_seat.Text += "/" + ENoSeats.C06.ToString();
			btn_C06.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_C7_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.C07);
			lb_seat.Text += "/" + ENoSeats.C07.ToString();
			btn_C07.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_VIP2_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.VIP02);
			lb_seat.Text += "/" + ENoSeats.VIP02.ToString();
			btn_VIP02.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_VIP3_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.VIP03);
			lb_seat.Text += "/" + ENoSeats.VIP03.ToString();
			btn_VIP03.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_VIP4_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.VIP04);
			lb_seat.Text += "/" + ENoSeats.VIP04.ToString();
			btn_VIP04.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_VIP5_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.VIP05);
			lb_seat.Text += "/" + ENoSeats.VIP05.ToString();
			btn_VIP05.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void btn_VIP6_Click(object sender, EventArgs e)
		{
			NoSeats.Add(ENoSeats.VIP06);
			lb_seat.Text += "/" + ENoSeats.VIP06.ToString();
			btn_VIP06.BackColor = Color.Yellow;
			price += 80000;
			lb_total.Text = price + "";
		}

		private void bnt_Booking_Click(object sender, EventArgs e)
		{
			using (var context = new MovieTheaterContext())
			{
				using (var trans = context.Database.BeginTransaction())
				{
					try
					{
						foreach (var item in NoSeats)
						{
							Ticket ticket = new Ticket
							{
								C_phone_number = sdt,
								Price = 80000.0,
								ScheduledMovideId = SelectSche.Id,
								No_seat = item.ToString()
							};
							context.Tickets.Add(ticket);
							context.SaveChanges();
						}
						trans.Commit();
						if (MessageBox.Show("Đặt vé thành công", "Thông báo",
									MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
							this.Dispose();

					}
					catch (DbEntityValidationException ex)
					{
						MessageBox.Show("Đặt vé không thành công !!!", "Thất bại",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
						foreach (var eve in ex.EntityValidationErrors)
						{
							MessageBox.Show("Entity of type " + eve.Entry.Entity.GetType().Name +
								" has the following validation errors: " + eve.Entry.State + "\n");
							foreach (var ve in eve.ValidationErrors)
							{
								MessageBox.Show("- Property:" + ve.PropertyName +
									" Error: +ve.ErrorMessage\n");

							}
						}
						trans.Rollback();
					}
				}
			}
		}
	}
}
