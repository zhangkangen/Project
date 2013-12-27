using System.Web;
using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;

namespace TestLogin2
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
			string msg = context.Request["msg"];

			if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
			{
				VelocityEngine vltEngine = new VelocityEngine();
				vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
				vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模版文件所在的文件夹
				vltEngine.Init();

				VelocityContext vltContext = new VelocityContext();
				vltContext.Put("username", "");//设置参数，在模版文件中通过$data来引用
				vltContext.Put("password", "");
				vltContext.Put("msg", "");


				Template vltTemplate = vltEngine.GetTemplate("login.html");//获取模版文件
				System.IO.StringWriter vltWriter = new System.IO.StringWriter();
				vltTemplate.Merge(vltContext, vltWriter);
				string html = vltWriter.GetStringBuilder().ToString();

				context.Response.Write(html);

			}
			else
			{
				if(username=="admin"&&password=="123")
				{
					context.Response.Write("登陆成功");
				}
				else
				{

					VelocityEngine vltEngine = new VelocityEngine();
					vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
					vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模版文件所在的文件夹
					vltEngine.Init();

					VelocityContext vltContext = new VelocityContext();
					vltContext.Put("username", username);//设置参数，在模版文件中通过$data来引用
					vltContext.Put("password", password);
					vltContext.Put("msg", "用户名或者密码错误");


					Template vltTemplate = vltEngine.GetTemplate("login.html");//获取模版文件
					System.IO.StringWriter vltWriter = new System.IO.StringWriter();
					vltTemplate.Merge(vltContext, vltWriter);
					string html = vltWriter.GetStringBuilder().ToString();

					context.Response.Write(html);
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