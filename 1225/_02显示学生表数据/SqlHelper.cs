using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace _02显示学生表数据
{
	public class SqlHelper
	{
		private static readonly string connStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
		public static int ExecuteNonQuery(string sql, params SqlParameter[] param)
		{
			using(SqlConnection conn = new SqlConnection(connStr))
			{
				using(SqlCommand cmd = new SqlCommand(sql, conn))
				{
					conn.Open();
					cmd.Parameters.AddRange(param);
					return cmd.ExecuteNonQuery();
				}
			}
		}

		public static object ExecuteScalar(string sql, params SqlParameter[] param)
		{
			using(SqlConnection conn = new SqlConnection(connStr))
			{
				using(SqlCommand cmd = new SqlCommand(sql, conn))
				{
					conn.Open();
					cmd.Parameters.AddRange(param);
					return cmd.ExecuteScalar();
				}
			}
		}

		public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] param)
		{
			SqlConnection conn = new SqlConnection(connStr);
			using(SqlCommand cmd = new SqlCommand(sql, conn))
			{
				try
				{
					conn.Open();
					cmd.Parameters.AddRange(param);
					return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
				}
				catch(Exception e)
				{
					conn.Close();
					conn.Dispose();
					throw e;
				}
			}
		}

		public static DataTable GetTable(string sql, params SqlParameter[] param)
		{
			DataTable dt = new DataTable();
			using(SqlDataAdapter sda = new SqlDataAdapter(sql, connStr))
			{
				sda.SelectCommand.Parameters.AddRange(param);
				sda.Fill(dt);
			}
			return dt;
		}
	}
}
