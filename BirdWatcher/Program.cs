using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{
    class Program
    {
        static void Main(string[] args)
        {


         var counts = new int[]
        {
            0,
            0,
            1,
            0,
            0,
            1,
            0
        };

            var birdCount = new BirdCount(counts);
            var res = birdCount.CountForFirstDays(3);
            Console.WriteLine(res);
        }
    }

	class BirdCount
	{

        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            int[] lastWeek= new int[] {0,2,5,3,7,8,4 };
            return lastWeek;
        }

        public int Today()
        {
          var length =  birdsPerDay.Length;

            return birdsPerDay[length - 1];

        }

        public void IncrementTodaysCount()
        {
           
            var length = birdsPerDay.Length;
            var last = birdsPerDay[length - 1];
            var Incremented = last+= 1;

            birdsPerDay[length - 1] = Incremented;

            
 
        }

        public bool HasDayWithoutBirds()
        {
            for(int i = 0; i < birdsPerDay.Length; i++)
			{
               if( birdsPerDay[i] == 0)
				{
                    return true;
				}
        
			}
        return false;
        }

        public int CountForFirstDays(int numberOfDays)
        {
            var sum = 0;
            if(numberOfDays <= birdsPerDay.Length - 1) { 
            for(int i =0; i < numberOfDays; i++)
			{
                    sum += birdsPerDay[i];
                 
			}
            
           }

            return sum;
        }

        public int BusyDays()
        {
            var busyDays = 0;
            foreach(var birds in birdsPerDay)
			{
                if(birds >= 5)
				{
                    busyDays+= 1;
				}
			}
            return busyDays;
            
        }

    }
}
