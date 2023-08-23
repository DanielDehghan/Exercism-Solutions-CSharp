using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_Is_Interesting
{
	class Program
	{
		static void Main(string[] args)
		{

			var bal2 = -10000.0m;
			var res2 =SavingAccount.Interest(bal2).ToString();
			Console.WriteLine(res2);

			var bal3 = 200.75m;
			var res3 = SavingAccount.AnnualBalanceUpdate(bal3).ToString();
			Console.WriteLine(res3);

			var bal4 = 200.75m;
			var target = 214.75m;
			var res4 = SavingAccount.YearsBeforeDesiredBalance(bal4, target).ToString();
			Console.WriteLine(res4);
		}
	}
	static class SavingAccount
	{
		public static float InterestRate(decimal balance)
		{
			if(balance < 0)
			{
				return 3.213f;
			}
			else if(balance < 1000)
			{
				return 0.5f;
			}
			else if( balance < 5000)
			{
				return 1.621f;
			}
			else if(balance >= 5000)
			{
				return 2.475f;
			}
			else
			{
				return 0;
			}
			
		}

		public static decimal Interest(decimal balance)
		{
			if (balance < 0)
			{
				var res = balance * Convert.ToDecimal(3.213f) / 100;
				return  Math.Round(res, 1);
			}
			else if (balance < 1000)
			{
				var res = balance * Convert.ToDecimal(0.5f) / 100;
				return Math.Round(res, 1);

			}
			else if (balance < 5000)
			{
				var res = balance * Convert.ToDecimal(1.621f) / 100;
				return Math.Round(res, 1);

			}
			else if (balance >= 5000)
			{
				var res = balance * Convert.ToDecimal(2.475f) / 100;
				return Math.Round(res, 1);
			}
			else
			{
				return 0;
			}
		}

		public static decimal AnnualBalanceUpdate(decimal balance)
		{
			decimal annualInterest;

			if (balance < 0)
			{
				annualInterest = balance * 0.03213m;
			}
			else if (balance < 1000)
			{
				annualInterest = balance * 0.005m;
			}
			else if (balance < 5000)
			{
				annualInterest = balance * 0.01621m;
			}
			else
			{
				annualInterest = balance * 0.02475m;
			}

			decimal newBalance = balance + annualInterest;
			return newBalance;
		}

		public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
		{
			int years = 0;

			do
			{
				balance = AnnualBalanceUpdate(balance);
				years++;
			}
			while (balance < targetBalance);

			return years;
		}
	}
}
