using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_up_for_Beauty
{
	class Program
	{
		static void Main(string[] args)
		{
			var date = "7/25/2019 13:45:00";

			var res1 = Appointment.Schedule(date);

			Console.WriteLine(res1);

			var res2 = Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0));
			Console.WriteLine(res2);
			
		}
	}

	static class Appointment
	{

		public static DateTime Schedule(string appointmentDateDescription)
		{
			var res=  Convert.ToDateTime(appointmentDateDescription);

			return res;
		}

		public static bool HasPassed(DateTime appointmentDate)
		{
			var now = DateTime.Now;

			if(appointmentDate < now)
			{
				return true;
			}
			return false;
		}


		public static bool IsAfternoonAppointment(DateTime appointmentDate)
		{
			var hour = appointmentDate.Hour;

			if(12 <= hour && hour < 18)
			{
				return true;
			}

			return false;
		}

		public static string Description(DateTime appointmentDate)
		{
			return $"You have an appointment on {appointmentDate.ToString()}";
		}


		public static DateTime AnniversaryDate()
		{
			return new DateTime(2023, 9, 15, 0, 0, 0);
		}



	}
}
