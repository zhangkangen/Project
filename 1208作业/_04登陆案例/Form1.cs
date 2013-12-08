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

namespace _04登陆案例
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			//autoid loginid loginpwd ErrorCount lastLoginTime
			string loginId = txtLoginId.Text;
			string Pwd = txtPwd.Text;
			string sql = "SELECT loginpwd,errorcount,DATEDIFF(MINUTE,lastlogintime,GETDATE()) AS diffMinute FROM users WHERE loginid=@loginid";
			SqlParameter[] param = { new SqlParameter("@loginid", loginId) };
			SqlDataReader sda = SQLHelper.ExecuteReader(sql, param);
			#region 用户名存在
			if(sda.HasRows)//用户名存在
			{
				while(sda.Read())
				{
					//获取用户名下的密码
					string loginPwd = sda["loginPwd"].ToString();
					//错误的次数
					int ErrorCount = Convert.ToInt32(sda["ErrorCount"]);
					//获取分钟差
					int diffMinute = Convert.ToInt32(sda["diffMinute"]);

					#region 时间差超过一天就，清空错误次数
					if(diffMinute > 60 * 24)
					{
						ErrorCountReset(loginId);
					}
					#endregion

					#region 错误次数是三次
					if(ErrorCount == 3)//错误次数是三次
					{
						#region 离最后一次登录超过十五分钟
						if(diffMinute > 15)//超过十五分钟
						{
							if(Pwd == loginPwd)//密码正确
							{
								//刷新时间
								RefreshTime(loginId);
								//错误次数清零
								ErrorCountReset(loginId);
								MessageBox.Show("登陆成功");
							}
							else//登陆失败
							{
								//刷新时间
								RefreshTime(loginId);
								MessageBox.Show("登陆失败");
							}
						}
						#endregion
						//离最后一次输入的时间少于十五分钟
						else
						{
							//提示用户用户**分钟后再登陆
							MessageBox.Show((15 - diffMinute) + "分钟后再登陆");
						}
					}
					#endregion
					else//错误次数不是三次
					{
						if(Pwd == loginPwd)//登陆成功
						{
							//错误次数清零
							ErrorCountReset(loginId);
							//刷新时间
							RefreshTime(loginId);
							MessageBox.Show("登陆成功");
						}
						else//登陆失败
						{
							//错误次数加一次，
							ErrorCountAdd(loginId);
							//刷新时间
							RefreshTime(loginId);
							MessageBox.Show("登陆失败");
						}

					}

				}

			}
			#endregion
			else//用户名不存在
			{
				MessageBox.Show("用户名或密码错误");
			}
		}

		/// <summary>
		/// 错误登陆次数加一
		/// </summary>
		private void ErrorCountAdd(string loginid)
		{
			string sqlErrorCountAdd = string.Format("UPDATE users SET ErrorCount=ErrorCount+1 WHERE loginid='{0}'", loginid);

			SQLHelper.ExecuteNonQuery(sqlErrorCountAdd);
		}

		/// <summary>
		/// 重置错误登陆次数
		/// </summary>
		private static void ErrorCountReset(string loginid)
		{
			string sqlErrorCountReset = string.Format("UPDATE users SET ErrorCount=0 WHERE loginid='{0}'", loginid);

			SQLHelper.ExecuteNonQuery(sqlErrorCountReset);
		}

		/// <summary>
		/// 刷新最后一次登录时间的方法
		/// </summary>
		private static void RefreshTime(string loginid)
		{
			string sqlRefreshTime = string.Format("UPDATE users SET LastLoginTime=GETDATE() WHERE loginid='{0}'", loginid);

			SQLHelper.ExecuteNonQuery(sqlRefreshTime);
		}
	}
}
