using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTryParse
{
	class Program
	{
		static void Main(string[] args)
		{

		}

		public static bool MyTryParse(string str, out int n)
		{
			try
			{
				n = int.Parse(str);
				return true;
			}
			catch
			{
				n = 0;
				return false;
			}
		}
	}
}
