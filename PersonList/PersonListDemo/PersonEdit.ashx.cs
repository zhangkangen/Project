using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PersonListDemo
{
	/// <summary>
	/// PersonEdit 的摘要说明
	/// </summary>
	public class PersonEdit:IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";
			//PersonEdit.ashx?action=AddNew
			//PersonEdit.ashx?action=Edit&Id=3
			string action = context.Request["action"];
			if(action == "AddNew")
			{
				//判断是否含有Save并且等于true，如果是的话就说明是点击【保存】按钮请求来的
				bool save = Convert.ToBoolean(context.Request["Save"]);
				if(save)//是保存
				{
					string name = context.Request["Name"];
					int age = Convert.ToInt32(context.Request["Age"]);
					string email = context.Request["Email"];
					SqlHelper.ExecuteNonQuery("Insert into tblperson(Name,Age,Email) values(@uname,@uage,@uheight)", new SqlParameter("@uname", name)
						, new SqlParameter("@uage", age)
						, new SqlParameter("@uheight", email));
					context.Response.Redirect("PersonList.ashx");//保存成功返回列表页面
				}
				else
				{
					//string html = CommonHelper.RenderHtml("PersonEdit.htm", new { Name = "", Age = 20, Email = "@rupeng.com" });
					var data = new { Name = "", Age = 20, Email = "@rupeng.com" };
					string html = CommonHelper.RenderHtml("PersonEdit.htm", data);
					context.Response.Write(html);
				}
			}
			else if(action == "Edit")
			{
			}
			else
			{
				context.Response.Write("Action参数错误！");
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