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
			//获取根目录
			List<Category> list = GetCategoryBytParentId(-1);
			//根据获取的对象添加到treeview节点
			LoadCategory(list, treeView1.Nodes);

		}

		/// <summary>
		/// 添加节点的方法
		/// </summary>
		/// <param name="list">要添加的节点对象</param>
		/// <param name="treeNodeCollection">当前节点</param>
		private void LoadCategory(List<Category> list, TreeNodeCollection treeNodeCollection)
		{
			foreach(Category item in list)
			{
				//添加的节点显示为对象的tname属性
				TreeNode tn = treeNodeCollection.Add(item.TName);
				//tag属性存储对象的tid属性
				tn.Tag = item.TId;
				//递归添加子节点
				LoadCategory(GetCategoryBytParentId(item.TId), tn.Nodes);
			}
		}
		/// <summary>
		/// 根据tParentId列获取category的方法
		/// </summary>
		/// <param name="p">tparentId</param>
		/// <returns>查询到的行转换为category对象的集合</returns>
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

		/// <summary>
		/// 双击显示节点中的文本名到listbox中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			List<ContentInfo> content = GetContentInfo(Convert.ToInt32(treeView1.SelectedNode.Tag));
			listBox1.DataSource = content;
			listBox1.DisplayMember = "dname";//显示成员为content的dname属性
			listBox1.ValueMember = "dcontent";//value成员是content的dcontent属性
		}

		/// <summary>
		/// 根据dtid获取contentinfo
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		private List<ContentInfo> GetContentInfo(int p)
		{
			string sql = "SELECT dId,dname,dcontent FROM contentinfo WHERE dtid=" + p;
			List<ContentInfo> list = new List<ContentInfo>();
			SqlDataReader sdReader = SqlHelper.ExecuteReader(sql);
			if(sdReader.HasRows)
			{
				while(sdReader.Read())
				{
					ContentInfo content = new ContentInfo();
					content.DId = Convert.ToInt32(sdReader["did"]);
					content.DName = sdReader["dname"].ToString();
					content.DContent = sdReader["dcontent"].ToString();
					list.Add(content);
				}
			}
			return list;
		}
		/// <summary>
		/// 显示文本名下的内容
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

			textBox1.Text = listBox1.SelectedValue.ToString();
		}
	}
}
