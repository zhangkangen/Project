using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace _03SqlHelper练习
{
	public class SQLHelper
	{
		/// <summary>
		/// 获取配置文件中的数据库连接字符串
		/// </summary>
		private static readonly string str = ConfigurationManager.ConnectionStrings[ "strConn" ].ConnectionString;
		/// <summary>
		/// 增删改的方法
		/// </summary>
		/// <param name="sql">要执行的sql语句</param>
		/// <param name="param">sql语句中的参数</param>
		/// <returns>返回受影响的行数</returns>
		public static int ExecuteNonQuery(string sql, params SqlParameter[] param)
		{
			using (SqlConnection conn = new SqlConnection(str))
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
		/// <summary>
		/// 返回第一行第一列的方法
		/// </summary>
		/// <param name="sql">要执行的sql语句</param>
		/// <param name="param">sql语句中的参数</param>
		/// <returns>读取的第一行第一列的内容</returns>
		public static object ExecuteScalar(string sql, params SqlParameter[] param)
		{
			using (SqlConnection conn = new SqlConnection(str))
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
		/// 查询数据库中数据的方法
		/// </summary>
		/// <param name="sql">要执行的sql语句</param>
		/// <param name="param">sql语句中参数，没有的话不传</param>
		/// <returns>返回SqlDateReader对象</returns>
		public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] param)
		{
			SqlConnection conn = new SqlConnection(str);
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				try
				{
					conn.Open();
					if (param != null)
					{
						cmd.Parameters.AddRange(param);
					}
					return cmd.ExecuteReader();
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
