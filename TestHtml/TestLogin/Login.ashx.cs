using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLogin
{
	/// <summary>
	/// Login 的摘要说明
	/// </summary>
	public class Login:IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";
			string username = context.Request["username"];
			string password = context.Request["password"];
			if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
			{
				context.Response.Write("<html>");
				context.Response.Write("<head></head>");
				context.Response.Write("<body><form action='Login.ashx' method='get'>用户名：<input type='text' name='username'/><br/>密&nbsp;&nbsp;&nbsp;&nbsp;码：<input type='password' name='password'/><br/><input type='submit' value='登陆'/></form></body>");
				context.Response.Write("</html>");
			}
			else
			{
				if(username == "admin" && password == "123")
				{
					context.Response.Write("<html><head></head><body>登陆成功</body></html>");
				}
				else
				{
					context.Response.Write("<html><head></head><body>用户名或密码错误</body></html>");
				}
			}


		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}