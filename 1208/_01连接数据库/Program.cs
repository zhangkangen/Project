using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01连接数据库
{
	class Program
	{
		static void Main(string[] args)
		{
			string strconn = "Data Source=ZHANGKANG;Initial catalog=DBtest;Integrated Security=true";//连接数据库的语句
			string sql = "select tsname from tblstudent where tsid=1";//要执行的sql语句
			//SELECT tsname FROM tblstudent WHERE tsid=1
			
			using (SqlConnection conn= new SqlConnection(strconn))//数据库连接对象
			{
				using (SqlCommand cmd = new SqlCommand(sql,conn))
				{
					conn.Open();
					using (SqlDataReader sdr = cmd.ExecuteReader())
					{
						if (sdr.HasRows)//
						{
							while (sdr.Read())
							{
								Console.WriteLine(sdr.GetString(0)); 
							}
						}
					}
				}
			}//end using
			Console.ReadKey();
		}
	}
}
