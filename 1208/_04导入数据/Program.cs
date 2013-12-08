using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace _04导入数据
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader sr = new StreamReader("1.txt"))
			{
				string line = sr.ReadLine();

				string strConn = "Data Source = ZHANGKANG;Initial Catalog = DBTest;Integrated Security=true";
				using (SqlConnection conn = new SqlConnection(strConn))
				{
					string sql = "insert into tblclass(tclassName,tclassDesc) values(@tclassName,@tclassDesc) ";
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						conn.Open();
						//设置每个参数的类型
						SqlParameter[] sp = new SqlParameter[] 
						{
							new SqlParameter("@tclassName", System.Data.SqlDbType.NVarChar),
							new SqlParameter("@tclassDesc", System.Data.SqlDbType.NVarChar)
						};
						cmd.Parameters.AddRange(sp);
						while ((line = sr.ReadLine()) != null)//读取每一行
						{
							string[] temps = line.Split(',');
							sp[0].Value = temps[1];
							sp[1].Value = temps[2];
							cmd.ExecuteNonQuery();
						}//end while
					}//end using
				}//end using
			}//end 流
			Console.WriteLine("成功了");
			Console.ReadKey();
		}
	}
}
