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

namespace _05新版增删改查
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 加载数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			LoadAllStudent();
		}
		/// <summary>
		/// 加载数据的方法
		/// </summary>
		private void LoadAllStudent()
		{
			List<Student> list = new List<Student>();
			string sql = "select tsid,tsname,tsgender,tsage,tsclassid from tblstudent";
			SqlDataReader sdReader = SQLHelper.ExecuteReader(sql);
			if (sdReader.HasRows)
			{
				while (sdReader.Read())
				{
					Student stu = new Student();
					stu.TsAge = Convert.ToInt32(sdReader["tsage"]);
					stu.TsClassId = Convert.ToInt32(sdReader["tsclassid"]);
					stu.TsGender = sdReader["tsgender"].ToString()[0];
					stu.TsId = Convert.ToInt32(sdReader["tsid"]);
					stu.TsName = sdReader["tsname"].ToString();
					list.Add(stu);
				}
			}
			dGV.DataSource = list;
		}
		/// <summary>
		/// 添加数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string sql = "insert into tblstudent(tsname,tsgender,tsage,tsclassid) values(@tsname,@tsgender,@tsage,@tsclassid)";
			string name = txtName.Text;
			string gender = rbMan.Checked == true ? "男" : "女";
			int age = int.Parse(txtAge.Text);
			int classid = int.Parse(txtClassId.Text);
			SqlParameter[] param = 
			{
				new SqlParameter("@tsname",name),
				new SqlParameter("@tsgender",gender),
				new SqlParameter("@tsage",age),
				new SqlParameter("@tsclassid",classid)
			};
			int count = SQLHelper.ExecuteNonQuery(sql, param);
			if (count > 0)
			{
				LoadAllStudent();
				MessageBox.Show("添加成功");
			}
			else
			{
				MessageBox.Show("添加失败");
			}

		}
		/// <summary>
		/// 删除数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			if (dGV.SelectedRows.Count > 0)
			{
				//获取选中行的id
				string id = dGV.SelectedRows[0].Cells[0].Value.ToString();
				//添加sql语句
				string sql = "delete from tblstudent where tsid=" + id;
				int count = SQLHelper.ExecuteNonQuery(sql);
				if (count > 0)
				{
					LoadAllStudent();//重新加载数据
					MessageBox.Show("删除成功");

				}
				else
				{
					MessageBox.Show("删除失败");
				}
			}//count>0
		}
		/// <summary>
		/// 选中行变化，将行中的数据显示到groupbox中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dGV_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dGV.SelectedRows.Count > 0)//选中行
			{
				//学生id
				lblId.Text = dGV.SelectedRows[0].Cells[0].Value.ToString();
				//学生姓名
				txtUpName.Text = dGV.SelectedRows[0].Cells[1].Value.ToString();
				if (dGV.SelectedRows[0].Cells[2].Value.ToString() == "男")
				{
					rdoUpMan.Checked = true;
				}
				else
				{
					rdoUpWoman.Checked = true;
				}
				//学生年龄
				txtUpAge.Text = dGV.SelectedRows[0].Cells[3].Value.ToString();
				//班级id
				txtUpClassId.Text = dGV.SelectedRows[0].Cells[4].Value.ToString();
			}


		}
		/// <summary>
		/// 修改数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUp_Click(object sender, EventArgs e)
		{
			string id = lblId.Text;
			string sql = "update tblstudent set tsname=@tsname,tsgender=@tsgender,tsage=@tsage,tsclassid=@tsclassid where tsid=@tsid";
			string gender = rdoUpMan.Checked == true ? "男" : "女";
			SqlParameter[] param =
			{
				new SqlParameter("@tsname",txtUpName.Text),
				new SqlParameter("@tsgender",gender),
				new SqlParameter("@tsage",txtUpAge.Text),
				new SqlParameter("@tsclassid",txtUpClassId.Text),
				new SqlParameter("@tsid",id)
			};
			int count = SQLHelper.ExecuteNonQuery(sql, param);
			if (count > 0)
			{
				LoadAllStudent();
				MessageBox.Show("更改成功");
			}
			else
			{
				MessageBox.Show("更改失败");
			}
		}

	}
}
