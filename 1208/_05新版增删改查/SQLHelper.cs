using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace _05新版增删改查
{
	public class SQLHelper
	{
		//获取配置文件中的数据库连接字符串
		private static readonly string strConn = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
		/// <summary>
		/// 执行增删改的方法
		/// </summary>
		/// <param name="sql">要执行的sql语句</param>
		/// <param name="param">如果sql语句中有参数，传入参数，没有的话，可以不传</param>
		/// <returns>受影响的行数</returns>
		public static int ExecuteNonQuery(string sql, params SqlParameter[] param)
		{
			using (SqlConnection conn = new SqlConnection(strConn))
			{
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					conn.Open();
					if (param != null)
					{
						cmd.Parameters.AddRange(param);
					}
					return cmd.ExecuteNonQuery();
				}
			}
		}
	
		public static object ExecuteScalar(string sql, params SqlParameter[] param)
		{
			using (SqlConnection conn = new SqlConnection(strConn))
			{
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					conn.Open();
					if (param != null)
					{
						cmd.Parameters.AddRange(param);
					}
					return cmd.ExecuteScalar();
				}
			}
		}
		/// <summary>
		/// 从数据库中查询的方法
		/// </summary>
		/// <param name="sql">要执行的sql语句</param>
		/// <param name="param">sql语句中参数</param>
		/// <returns>读取的数据</returns>
		public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] param)
		{
			SqlConnection conn = new SqlConnection(strConn);
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				if (param != null)
				{
					cmd.Parameters.AddRange(param);
				}
				try
				{
					conn.Open();
					return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
				}
				catch (Exception e)
				{
					conn.Close();
					conn.Dispose();
					throw e;
				}
			}
		}
	}
}
