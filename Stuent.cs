using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _14_02_23
{
	internal class Stuent
	{public static bool CheckNo(string groupNo)
		{
			if (groupNo == null)
				return false;
			if (groupNo.Length != 4)
				return  false;
			if (char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[1])&& char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]))
			return true;

			return false;
		}
	     

		public string Fullname;
		public byte GroupNo;
		public int Age;

		
	}
}
