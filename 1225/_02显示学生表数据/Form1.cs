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

namespace _02显示学生表数据
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadScore();
		}

		private void LoadScore()
		{

			string sql = "select * from tblscore";
			DataTable dt = SqlHelper.GetTable(sql);
			dataGridView1.DataSource = dt;
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
			string sql = "delete from tblscore where tScoreId=" + id;
			int count = SqlHelper.ExecuteNonQuery(sql);
			if(count > 0)
			{
				LoadScore();
				MessageBox.Show("删除成功");
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int tsid = Convert.ToInt32(txtTSId.Text);
			int tenglish = Convert.ToInt32(txtEnglish.Text);
			int tmath = Convert.ToInt32(txtMath.Text);
			string sql = "insert into tblscore(tsid,tenglish,tmath) values(@tsid,@tenglish,@tmath)";
			SqlParameter[] param =  { 
				new SqlParameter("@tsid",tsid),
				new SqlParameter("@tenglish",tenglish),
				new SqlParameter("@tmath",tmath)
			};
			int count = SqlHelper.ExecuteNonQuery(sql, param);
			if(count > 0)
			{
				LoadScore();
				MessageBox.Show("添加成功");
			}
		}
	}
}
