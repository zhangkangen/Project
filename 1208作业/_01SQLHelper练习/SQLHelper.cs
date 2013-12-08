using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace _01SQLHelper练习
{
	public class SQLHelper
	{
		public static readonly string strConn = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;

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
