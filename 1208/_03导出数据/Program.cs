using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace _03导出数据
{
	class Program
	{
		static void Main(string[] args)
		{
			string strConn = "Data Source=ZHANGKANG;Initial Catalog=DBTest;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(strConn))
			{
				string sql = "select tclassid,tclassname,tclassdesc from tblclass";
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					conn.Open();
					using (SqlDataReader sdr = cmd.ExecuteReader())
					{
						if (sdr.HasRows)
						{
							using (StreamWriter sw = new StreamWriter("1.txt"))
							{
								sw.WriteLine("{0},{1},{2}", sdr.GetName(0), sdr.GetName(1), sdr.GetName(2));
								while (sdr.Read())
								{
									sw.WriteLine("{0},{1},{2}", sdr[ "tclassid" ], sdr[ "tclassname" ], sdr[ "tclassdesc" ]);
								}
							}
						}
					}

				}//end using
			}//end using
			Console.WriteLine("成功");
			Console.ReadKey();
		}
	}
}
