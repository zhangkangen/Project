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

namespace _02资料管理器
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List<Category> list = GetCategoryBytParentId(-1);

		}

		private List<Category> GetCategoryBytParentId(int p)
		{
			List<Category> list = new List<Category>();
			string sql = "select tid,tname from category where tparentid=" + p;
			SqlDataReader sdReader = SqlHelper.ExecuteReader(sql);
			if(sdReader.HasRows)
			{
				while(sdReader.Read())
				{
					Category category = new Category();
					category.TId = Convert.ToInt32(sdReader["tid"]);
					category.TName = sdReader["tname"].ToString();
					list.Add(category);
				}
			}
			return list;
		}
	}
}
