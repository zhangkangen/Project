using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _03SqlHelper练习
{
	class Program
	{
		static void Main(string[] args)
		{
			string sql = "select * from tblstudent";
			SqlDataReader sda = SQLHelper.ExecuteReader(sql);
			if (sda.HasRows)
			{

				while (sda.Read())
				{
					for (int i = 0; i < sda.FieldCount; i++)
					{
						Console.Write(sda[ sda.GetName(i) ].ToString() + ",");
					}
					Console.WriteLine();
				}
			}
			Console.ReadKey();
		}
	}
}
