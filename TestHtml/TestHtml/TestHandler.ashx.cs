using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestHtml
{
	/// <summary>
	/// TestHandler 的摘要说明
	/// </summary>
	public class TestHandler:IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";
			string action = context.Request["name"];
			int age = Convert.ToInt32(context.Request["age"]);
			context.Response.Write("Hello World<font color='green'>hahha</font>    name=" + action + "        age=" + age);
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