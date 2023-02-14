using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace _14_02_23
{
	internal static class ExtentıonMethods
	{
		public static bool IsContainsDigit(this string str)
		{
			if (str == null) return false;
			foreach (var cr in str)
			{
				if (char.IsDigit(cr))
					return true;
			}
			return false;
		}
		public static string ToCapitalize(this string str)
		{
			string newStr = Char.ToUpper(str[0]) + str.Substring(1).ToLower();
			return newStr;
		}
		public static bool IsOdd(this int num1)
		{
			if (num1 % 2 != 0) return true;
			else
			{
				return false;
			}
		}
		public static bool IsEven (this int num2)
		{
			if (num2 % 2 == 0) 
				return true;
			else
			{
				return false;
			}
		}
			


	}
}
