using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLine
{
	class Program
	{
		static void Main(string[] args)
		{

			var res = LogLine.Message("[WARNING]: Disk almost full\r\n");

			Console.WriteLine(res);


			var res1 = LogLine.LogLevel("[ERROR]: Invalid Operation");
			Console.WriteLine(res1);
		}
	}

	static class LogLine
	{

		public static string Message(string logLine)
		{

			if (!String.IsNullOrWhiteSpace(logLine))
			{
				string res = "";
				if (logLine.Contains("[ERROR]:"))
				{
					var startIndex = logLine.IndexOf(":") + 1;
					res = logLine.Substring(startIndex).Trim();
					return res;
				}
				else if (logLine.Contains("[WARNING]:"))
				{
					var startIndex = logLine.IndexOf(":")+ 1;
					res = logLine.Substring(startIndex).Trim();
					return res;
				}
				else if (logLine.Contains("[INFO]:"))
				{
					var startIndex = logLine.IndexOf(":") + 1;
					res = logLine.Substring(startIndex).Trim();
					return res;
				}
				return res;
			}

			return "Invalid Input";
		}


		public static string LogLevel(string logLine)
		{
			if (!String.IsNullOrWhiteSpace(logLine))
			{
				string res = "";
				if (logLine.Contains("[ERROR]:"))
				{
					var startIndex = logLine.IndexOf("[") + 1;
					var endIndex = logLine.LastIndexOf("]") - 1;
					res = logLine.Substring(startIndex , endIndex ).Trim();
					return res;
				}
				else if (logLine.Contains("[WARNING]:"))
				{
					var startIndex = logLine.IndexOf("[") + 1;
					var endIndex = logLine.LastIndexOf("]") - 1;
					res = logLine.Substring(startIndex, endIndex).Trim();
					return res;
				}
				else if (logLine.Contains("[INFO]:"))
				{
					var startIndex = logLine.IndexOf("[") + 1;
					var endIndex = logLine.LastIndexOf("]") - 1;
					res = logLine.Substring(startIndex, endIndex).Trim();
					return res;
				}
				return res;
			}

			return "Invalid Input";
		}




	}
}
