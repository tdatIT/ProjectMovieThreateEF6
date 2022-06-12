using LTWin_Last.Model;
using Project_LT_Windows_EF6.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last.Controller
{
	public class QueryData
	{
		const int MAXSEATS = 30;
		public IList<Room> GetRoomData()
		{
			using (MovieTheaterContext context = new MovieTheaterContext())
			{
				try
				{
					var roomIdList = context.Rooms.ToList();
					return roomIdList;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return null;
				}
			}

		}
		public IList<Movie> GetFilmAvailable()
		{
			using (MovieTheaterContext context = new MovieTheaterContext())
			{
				try
				{
					var roomIdList = context.Movies.Where(u => u.Status == true).ToList();
					return roomIdList;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return null;
				}
			}

		}
		public IList GetDataFilmAndScheduled(DateTime curTime)
		{
			using (MovieTheaterContext context = new MovieTheaterContext())
			{
				DateTime nextday = curTime.AddDays(1);
				var dataSchedule = from i in context.ScheduledMovies
								   join j in context.Movies on i.MovieId equals j.Id
								   where i.Begindate >= curTime && i.Begindate <= nextday
								   select new
								   {
									   j.Name,
									   i.Begindate,
									   i.Id,
									   avalibleS=30
								   } into info
								   select info;

				var noseat = from i in context.Tickets
							 group i by i.ScheduledMovideId into scheduleId
							 select new { scheduleId.Key, countSeats= scheduleId.Count() };

				var data = from u in dataSchedule
						   join v in noseat on u.Id equals v.Key into snt
						   from i in snt.DefaultIfEmpty()
						   select new
						   {
							   u.Name,
							   u.Begindate,
							   u.Id,
							   seats = i.Key == null ? MAXSEATS:u.avalibleS-i.countSeats
							};
				return data.ToList();
			};
		
		}

		public bool DeleteCustomerUseTrans(Customer cs)
		{
			return true;
		}
		public List<Employee> GetAllEmployee()
		{
			using (MovieTheaterContext dbcontext = new MovieTheaterContext())
			{
				var data = dbcontext.Employees.ToList();
				return data;
			}
		}
		public bool DelScheduledByTrans()
		{
			return true;
		}
		public List<ENoSeats> NoSeatsNotAva(int id)
		{
			using (var context = new MovieTheaterContext())
			{
				var list = context.Tickets.Where(t => t.ScheduledMovideId == id).Select(u => u.No_seat).ToList();
				List<ENoSeats> lstSeats = null;
				if (list!=null)
				{
					lstSeats = new List<ENoSeats>();
					ENoSeats seats;
					foreach (string i in list)
					{
						Enum.TryParse(i, out seats);
						lstSeats.Add(seats);
					}
				}
				return lstSeats;
			}
		}
	}
}
