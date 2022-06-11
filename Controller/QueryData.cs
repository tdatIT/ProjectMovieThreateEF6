using Project_LT_Windows_EF6.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTWin_Last.Controller
{
	public class QueryData
	{
		public IQueryable GetDataFilmAndScheduled(DateTime dateTime)
		{
			using(MovieTheaterContext context = new MovieTheaterContext())
			{
				var dataSchedule = from i in context.ScheduledMovies
						   join j in context.Movies on i.MovieId equals j.Id
						   where i.Begindate == dateTime
						   select new
						   {
							   j.Name,
							   i.Begindate,
							   i.Id
						   } into info
						   select info;

				var noseat = from i in context.Tickets
							 group i by i.ScheduledMovideId into scheduleId
							 select new { scheduleId.Key, countSeats = 30-scheduleId.Count() };

				var data = from u in dataSchedule
						   join v in noseat on u.Id equals v.Key
						   select new
						   {
							   u.Name,
							   u.Begindate,
							   v.countSeats,
							   v.Key
						   };
				return data;
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
	}
}
