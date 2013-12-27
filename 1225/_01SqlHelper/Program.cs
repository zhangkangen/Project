using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SqlHelper
{
	class Program
	{
		static void Main(string[] args)
		{
			string sql = "select count(*) from tblstudent";
			int count = Convert.ToInt32(SqlHelper.ExecuteScalar(sql));
			Console.WriteLine(count);
			Console.ReadKey();
		}
	}
}
