using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Squeaky_Clean
{
	class Program
	{
		static void Main(string[] args)
		{
			var res = Identifier.Clean("The First Clean");
			Console.WriteLine(res);

			string input1 = "my\0Id";

			var res2 = Identifier.Clean(input1);
			Console.WriteLine(res2);

			var res3 = Identifier.Clean("a-bc");
		
			Console.WriteLine(res3);

			var res4 = Identifier.Clean("a-b1c-d_2e");

			Console.WriteLine(res4);

			var res5 = Identifier.Clean("9 -abcĐ😀ω\0");

			Console.WriteLine(res5);

	
		}
	}

	public static class Identifier
	{
		public static string Clean(string identifier)
		{
			StringBuilder builder = new StringBuilder();

			for (int i = 0; i < identifier.Length; i++)
			{
				char c = identifier[i];

				// Task 1: Replace spaces with underscores
				if (char.IsWhiteSpace(c))
				{
					builder.Append('_');
					continue;
				}

				// Task 2: Replace control characters with "CTRL"
				if (char.IsControl(c))
				{
					builder.Append("CTRL");
					continue;
				}

				// Task 3: Convert kebab-case to camelCase
				if (c == '-' && i < identifier.Length - 1 && char.IsLower(identifier[i + 1]))
				{
					builder.Append(char.ToUpper(identifier[++i]));
					continue;
				}

				// Task 4: Omit non-letter characters
				if (char.IsLetter(c) && !IsSpecialCharacter(c))
				{
					// Task 5: Omit Greek lowercase letters
					if ((c >= 'α' && c <= 'ω'))
					{
						continue;
					}

					builder.Append(c);
					continue;
				}
			}

			return builder.ToString();
		}

		private static bool IsSpecialCharacter(char c)
		{
			return !char.IsLetterOrDigit(c);
		}
	}
}
