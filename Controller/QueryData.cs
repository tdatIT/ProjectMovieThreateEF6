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
					var roomIdList = context.Movies.Where(u=>u.Status==true).ToList();
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
			using(MovieTheaterContext context = new MovieTheaterContext())
			{
				DateTime nextday = curTime.AddDays(1);
				var dataSchedule = from i in context.ScheduledMovies
						   join j in context.Movies on i.MovieId equals j.Id
						   where i.Begindate >=curTime && i.Begindate<=nextday
						   select new
						   {
							   j.Name,
							   i.Begindate,
							   i.Id
						   } into info
						   select info;

				var noseat = from i in context.Tickets
							 group i by i.ScheduledMovideId into scheduleId
							 select new { scheduleId.Key, countSeats = 30 - scheduleId.Count() };

				var data = from u in dataSchedule
						   join v in noseat on u.Id equals v.Key
						   select new
						   {
							   u.Name,
							   u.Begindate,
							   v.countSeats,
							   v.Key
						   };
				return dataSchedule.ToList();
			}
		}
		public bool DeleteCustomerUseTrans(Customer cs)
		{
			return true;
		}
		public List<Employee> GetAllEmployee()
		{
			using (MovieTheaterContext dbcontext =new MovieTheaterContext())
			{
				var data = dbcontext.Employees.ToList();
				return data;
			}
		}
		public bool DelScheduledByTrans()
		{
			return true;
		}
	}
}
