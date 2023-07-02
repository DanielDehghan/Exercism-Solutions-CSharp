using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_sToys
{
	class Program
	{
		static void Main(string[] args)
		{

            var res1 = RemoteControlCar.Buy();

			Console.WriteLine(res1.BatteryDisplay());
			Console.WriteLine(res1.DistanceDisplay());

            res1.Drive();
            res1.Drive();

            Console.WriteLine(res1.BatteryDisplay());
            Console.WriteLine(res1.DistanceDisplay());

            var car = new RemoteControlCar();
            for (var i = 0; i < 100; i++)
            {
                car.Drive();
            }

            car.Drive();
			Console.WriteLine(car.BatteryDisplay());
			Console.WriteLine(car.DistanceDisplay());
        }

	}

	class RemoteControlCar
    {
        private int meterDriven = 0;
        private int battery = 100;
        public static RemoteControlCar Buy()
        {

            RemoteControlCar car = new RemoteControlCar();
            return car;
        }

        public string DistanceDisplay()
        {
 
            return $"Driven {meterDriven} meters" ;
        }

        public string BatteryDisplay()
        {
            if(battery != -1)
			{
            return $"Battery at {battery}%";
			}
			else
			{
                return $"Battery empty";
            }
            
        }

        public void Drive()
        {
            meterDriven += 20;
            battery -= 1;
            if(battery == -1)
			{
                meterDriven -= 20;
			}
        }


    }
}
