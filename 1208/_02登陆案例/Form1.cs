using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _02登陆案例
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string pwd = txtPwd.Text;

			string strConn = "Data Source=ZHANGKANG;Initial Catalog=DBTest;Integrated Security=true";
			string sql = "SELECT COUNT(*) FROM users WHERE loginId=@name AND loginPwd=@pwd";//登陆是否成功

			int count = -1;
			using (SqlConnection conn = new SqlConnection(strConn))
			{
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					conn.Open();
					cmd.Parameters.AddWithValue("@name", name);
					cmd.Parameters.AddWithValue("@pwd", pwd);
					count = Convert.ToInt32(cmd.ExecuteScalar());
				}
			}//end using
			if (count > 0)
			{
				MessageBox.Show("登陆成功");
			}
			else
			{
				int n = -1;
				string sql1 = "select count(*) from users where loginid=@name";
				using (SqlConnection conn = new SqlConnection(strConn))
				{
					using (SqlCommand cmd = new SqlCommand(sql1, conn))
					{
						conn.Open();
						cmd.Parameters.AddWithValue("@name", name);
						n = Convert.ToInt32(cmd.ExecuteScalar());
					}
				}
				if (n>0)
				{
					MessageBox.Show("密码错误");
				}
				else
				{
					MessageBox.Show("用户名不存在");
				}
			}
		}
	}
}
