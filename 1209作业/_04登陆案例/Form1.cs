﻿using System;
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
			string userName = txtName.Text;
			string userPwd = txtPwd.Text;
			string sql = "SELECT autoid,loginPwd,ErrorCount,DATEDIFF(MINUTE,lastloginTime,GETDATE()) AS diffMinute FROM users WHERE loginid=@loginId";
			SqlParameter[] param ={
									  new SqlParameter("@loginId",userName)
								 };
			DataTable dt = SQLHelper.ExecuteAdapter(sql, param);
			if(dt.Rows.Count > 0)
			{
				foreach(DataRow item in dt.Rows)
				{
					int autoId = Convert.ToInt32(item["autoid"]);
					string loginPwd = item["loginPwd"].ToString();
					int errorCount = Convert.ToInt32(item["errorcount"]);
					int diffMinute = Convert.ToInt32(item["diffMinute"]);

					if(diffMinute > 60 * 24)//超过一天
					{
						ErrorCountReset(autoId);
					}
					if(errorCount == 3 && diffMinute < 15)//登陆了三次，这次登陆少于15分钟
					{
						MessageBox.Show("你已经错误三次请" + (15 - diffMinute) + "分钟后再试");
					}
					else if(errorCount == 3 && diffMinute >= 15)
					{
						if(userPwd == loginPwd)//密码正确
						{
							//错误次数重置
							ErrorCountReset(autoId);
							//刷新时间
							RefreshLastLoginTime(autoId);
							MessageBox.Show("登陆成功");
						}
						else
						{
							//刷新时间
							RefreshLastLoginTime(autoId);
							MessageBox.Show("登陆失败");
						}
					}
					else if(errorCount < 3)//错误次数小于三次
					{
						if(userPwd == loginPwd)//密码正确
						{
							//错误次数重置
							ErrorCountReset(autoId);
							//刷新时间
							RefreshLastLoginTime(autoId);
							MessageBox.Show("登陆成功");
						}
						else
						{
							//错误次数加1
							ErrorCountAdd(autoId);
							//刷新时间
							RefreshLastLoginTime(autoId);
							MessageBox.Show("密码错误");
						}
					}
				}
			}
			else
			{
				MessageBox.Show("用户名不存在");
			}
		}
		/// <summary>
		/// 根据autoid增加错误次数加1的方法
		/// </summary>
		/// <param name="p"></param>
		private void ErrorCountAdd(int p)
		{
			string sql = "update users set errorcount=errorcount+1 where autoid=" + p;
			SQLHelper.ExecuteNonQuery(sql);
		}

		/// <summary>
		/// 根据autoid更新最后一次登陆时间
		/// </summary>
		/// <param name="p"></param>
		private void RefreshLastLoginTime(int p)
		{
			string sql = "update users set lastlogintime=getdate() where autoid=" + p;
			int n = SQLHelper.ExecuteNonQuery(sql);
		}

		/// <summary>
		/// 根据autoid将errorcount设置为0
		/// </summary>
		/// <param name="p">loginid</param>
		private void ErrorCountReset(int p)
		{
			string sql = "update users set errorcount=0 where autoid=" + p;
			int n = SQLHelper.ExecuteNonQuery(sql);
		}
	}
}
