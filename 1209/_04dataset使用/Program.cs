using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _04dataset使用
{
	class Program
	{
		static void Main(string[] args)
		{
			DataSet ds = new DataSet("School");//临时数据库
			DataTable dt = new DataTable("Class");//表

			DataColumn dcId = new DataColumn("id", typeof(int));
			DataColumn dcName = new DataColumn("name", typeof(string));
			dt.Columns.Add(dcId);
			dt.Columns.Add(dcName);
			dt.Rows.Add(1, "张三");
			dt.Rows.Add(2, "李四");
			ds.Tables.Add(dt);

			foreach(DataTable item in ds.Tables)
			{
				foreach(DataRow row in item.Rows)
				{
					Console.WriteLine(row[dcId].ToString()+row[dcName]);
				}
			}
			Console.ReadKey();


		}
	}
}
