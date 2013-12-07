using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02再连接
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Data Source=ZHANGKANG;Initial Catalog=MySchool;Integrated Security=true";
            string sql = " UPDATE score SET stuenglish=50 WHERE SID=1";
            int count = -1;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
