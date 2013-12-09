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
				LoadCategory(GetCategoryBytParentId(item.TId), tn.Nodes);//递归加载所有的节点
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

		private void tvCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			//绑定listbox的数据为方法中得到的contentinfo的对象的集合
			listBox1.DataSource = GetContentNameBytId(Convert.ToInt32(tvCategory.SelectedNode.Tag));
			//控件显示的是contentinfo的DName属性的值
			listBox1.DisplayMember = "dname";
		}
		private List<ContentInfo> GetContentNameBytId(int p)
		{
			List<ContentInfo> list = new List<ContentInfo>();
			//要执行的sql语句
			string sql = "select did,dname from contentinfo where dtid=" + p;

			SqlDataReader sdReader = SQLHelper.ExecuteReader(sql);
			if(sdReader.HasRows)
			{
				while(sdReader.Read())
				{
					ContentInfo content = new ContentInfo();
					content.DId = Convert.ToInt32(sdReader["did"]);
					content.DName = sdReader["dname"].ToString();
					list.Add(content);
				}
			}
			return list;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ContentInfo content = listBox1.SelectedItem as ContentInfo;
			textBox1.Text = GetContentInfoDcontent(content.DId);
		}

		/// <summary>
		/// 通过列表contentinfo中的did获取对应的dcontent的内容
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		private string GetContentInfoDcontent(int p)
		{
			string sql = "select dcontent from contentinfo where did=" + p;
			return SQLHelper.ExecuteScalar(sql).ToString();
		}
	}
}
