﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SQLHelper
{
	class Program
	{
		static void Main(string[] args)
		{
			string sql = "select count(*) from tblclass";
			int count = (int)SQLHelper.ExecuteScalar(sql);
			Console.WriteLine(count);
			Console.ReadKey();
		}
	}
}
