using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLevels
{
	class Program
	{
		static void Main(string[] args)
		{

			var res = LogLine.Message("[WARNING]: Disk almost full\r\n");

			Console.WriteLine(res);


			var res1 = LogLine.LogLevel("[ERROR]: Invalid Operation");
			Console.WriteLine(res1);

			var res2 = LogLine.Reformat("[ERROR]: Invalid Operation");
			Console.WriteLine(res2);
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
					var startIndex = logLine.IndexOf(":") + 1;
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
					res = logLine.Substring(startIndex, endIndex).Trim().ToLower();
					return res;
				}
				else if (logLine.Contains("[WARNING]:"))
				{
					var startIndex = logLine.IndexOf("[") + 1;
					var endIndex = logLine.LastIndexOf("]") - 1;
					res = logLine.Substring(startIndex, endIndex).Trim().ToLower();
					return res;
				}
				else if (logLine.Contains("[INFO]:"))
				{
					var startIndex = logLine.IndexOf("[") + 1;
					var endIndex = logLine.LastIndexOf("]") - 1;
					res = logLine.Substring(startIndex, endIndex).Trim().ToLower();
					return res;
				}
				return res;
			}

			return "Invalid Input";
		}


		public static string Reformat(string logLine)
		{
			if (!String.IsNullOrWhiteSpace(logLine))
			{

				var startIndex = logLine.IndexOf("[") + 1;
				var endIndex = logLine.LastIndexOf("]") - 1;
				string res = "";
				if (logLine.Contains("[ERROR]:"))
				{
					var logLevel = logLine.Substring(startIndex, endIndex);
					var MessageStartIndex = logLine.IndexOf(":") + 1;
					res = logLine.Substring(MessageStartIndex).Trim() +" " +"("+logLevel.Trim().ToLower()+")";
					return res;
				}
				else if (logLine.Contains("[WARNING]:"))
				{
					var logLevel = logLine.Substring(startIndex, endIndex);
					var MessageStartIndex = logLine.IndexOf(":") + 1;
					res = logLine.Substring(MessageStartIndex).Trim() + " " + "(" + logLevel.Trim().ToLower() + ")";
					return res;
				}
				else if (logLine.Contains("[INFO]:"))
				{
					var logLevel = logLine.Substring(startIndex, endIndex);
					var MessageStartIndex = logLine.IndexOf(":") + 1;
					res = logLine.Substring(MessageStartIndex).Trim() + " " + "(" + logLevel.Trim().ToLower() + ")";
					return res;
				}
				return res;
			}

			return "Invalid Input";

		}
	}
}
