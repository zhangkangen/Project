using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01数据库连接
{
    class Program
    {
        static void Main(string[] args)
        {
           // Data Source=
            string date = @"Data Source=ZHANGKANG;Initial Catalog=MySchool;Integrated Security=True";
           int number = -1;
           using (SqlConnection conn = new SqlConnection(date))
           {
               string sql = "SELECT * FROM score";
               using (SqlCommand cmd = new SqlCommand(sql,conn))
               {
                   conn.Open();
                   number=  cmd.ExecuteNonQuery();
               }
           }
           Console.WriteLine(number);
           Console.ReadKey();
        }
    }
}
