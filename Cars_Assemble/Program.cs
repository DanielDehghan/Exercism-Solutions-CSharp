using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Assemble
{
	class Program
	{
		static void Main(string[] args)
		{
			var res = AssembelyLine.SuccessRate(9);

			Console.WriteLine(res);

			var res2 = AssembelyLine.Productionrateperhour(3);

			Console.WriteLine(res2);

			var res3 = AssembelyLine.WorkingItemsPerMinute(6);
			Console.WriteLine(res3);

		}



		public class AssembelyLine
		{
			public static double SuccessRate(int speed)
			{
				if (speed == 0)
				{
					return 0.0;
				}
				else if (speed >= 1 && speed <= 4)
				{
					return 1;
				}
				else if (speed >= 5 && speed <= 8)
				{
					return 0.90;
				}
				else if ( speed == 9)
				{
					return 0.80;
				}
				else 
				{
					return 0.77;
				}

			}

			public static double Productionrateperhour(int speed)
			{
				var res = speed * 221;
				if (speed == 0)
				{
					return res;
				}
				else if (speed >= 1 && speed <= 4)
				{
					return res;
				}
				else if (speed >= 5 && speed <= 8)
				{
					return res * 0.90;
				}
				else if (speed == 9)
				{
					return res * 0.80;
				}
				else
				{
					return res * 0.77;
				}
			}

			public static int WorkingItemsPerMinute(int speed)
			{
				var res = speed * 221;
				if (speed == 0)
				{
					var mins = res / 60;
					return mins;
				}
				else if (speed >= 1 && speed <= 4)
				{
					var mins = res / 60;
					return mins;
				}
				else if (speed >= 5 && speed <= 8)
				{

					var mins = Math.Floor(res * 0.90 / 60);
					return Convert.ToInt32(mins);
				}
				else if (speed == 9)
				{
					var mins = Math.Floor(res * 0.80 / 60);
					return Convert.ToInt32(mins);
				}
				else
				{
					var mins = Math.Floor(res * 0.77 / 60);
					return Convert.ToInt32(mins);
				}
			}
		}

	}
}
