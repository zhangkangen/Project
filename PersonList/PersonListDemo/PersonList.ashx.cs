using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PersonListDemo
{
	/// <summary>
	/// PersonList 的摘要说明
	/// </summary>
	public class PersonList:IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";

			DataTable dt =
				SqlHelper.ExecuteDataTable("select * from tblperson");
			//DataTable不是集合，所以无法foreach遍历，DataTable的Rows属性
			//代表表格中的数据行的集合（DataRow的集合），一般传递DataRowCollection
			//给模板方便遍历
			string html = CommonHelper.RenderHtml("PersonList.htm", dt.Rows);

			context.Response.Write(html);

			//MVC：
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