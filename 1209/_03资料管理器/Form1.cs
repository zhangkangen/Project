using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03资料管理器
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
			LoadCategory(list, tvCategory.Nodes);

		}

		private void LoadCategory(List<Category> list, TreeNodeCollection treeNodeCollection)
		{
			foreach(Category item in list)
			{
				TreeNode tn = treeNodeCollection.Add(item.TName);
				tn.Tag = item.TId;
				LoadCategory(GetCategoryBytParentId(item.TId), tn.Nodes);
			}
		}

		private List<Category> GetCategoryBytParentId(int p)
		{
			List<Category> list = new List<Category>();
			string sql = "select tid,tname from category where tparentid =" + p;
			SqlDataReader sdReader = SQLHelper.ExecuteReader(sql);
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
