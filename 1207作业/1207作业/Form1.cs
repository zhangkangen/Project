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

namespace _1207作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GB.Visible = false;//默认的不显示GB控件
            lblId.Visible = false;//不显示lblId控件

            LoadDGV();//加载数据
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadDGV()
        {
            List<TheClass> list = new List<TheClass>();
            string strConn = "Data Source = ZHANGKANG;Initial catalog=DBTest;Integrated Security=true";//数据库连接字符串
            string sql = "select * from tblclass";//查询的语句
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                TheClass cla = new TheClass();//创建一个班级对象
                                cla.Id = sdr.GetInt32(0).ToString();
                                cla.ClassName = sdr.GetString(1);
                                cla.ClassDesc = sdr.GetString(2);
                                list.Add(cla);
                            }
                        }
                    }
                }
            }//end using
            dGV.DataSource = list;
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            if (tsmiAdd.Text == "增加")
            {
                GB.Visible = true;//显示控件
                GB.Text = "增加";
                btn.Text = "增加";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        /// <summary>
        /// 处理数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = ZHANGKANG;Initial catalog=dbtest;integrated security=true";//数据库连接字符串

            if (btn.Text == "增加")
            {
                int count = -1;
                string sql = string.Format("insert into tblclass(tclassname,tclassdesc) values('{0}','{1}')", textBox1.Text, textBox2.Text);
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        count = cmd.ExecuteNonQuery();
                    }
                }//end using
                if (count > 0)
                {
                    LoadDGV();
                    GB.Visible = false;
                    MessageBox.Show("添加成功");
                }
            }//end if
            else if (btn.Text == "更改")
            {
                string sql = string.Format("update tblclass set tclassname='{0}',tclassdesc='{1}' where tclassid={2}", textBox1.Text, textBox2.Text, lblId.Text);
                int count = -1;
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        count = cmd.ExecuteNonQuery();
                    }
                }//end using
                if (count > 0)
                {
                    LoadDGV();
                    MessageBox.Show("更改成功");
                    GB.Visible = false;
                }
                else
                {
                    MessageBox.Show("更改失败");
                }
            }
        }

        /// <summary>
        /// 更改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (tsmiUpdate.Text == "更改")
            {
                GB.Visible = true;
                GB.Text = "更改";
                btn.Text = "更改";
            }
        }
        /// <summary>
        /// 删除选中行数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            string id = dGV.SelectedRows[0].Cells[0].Value.ToString();

            string strConn = "Data Source=ZHANGKANG;Initial catalog=DBTest;Integrated Security=true";
            string sql = "delete from tblclass where tclassId=" + id;
            int count = -1;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                }
            }//end using
            if (count > 0)
            {
                LoadDGV();
                MessageBox.Show("删除成功");
            }
        }
        /// <summary>
        /// 刷新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }
        /// <summary>
        /// 行改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV.SelectedRows.Count > 0)
            {
                lblId.Text = dGV.SelectedRows[0].Cells[0].Value.ToString();//选中行的id存在lblId中
                textBox1.Text = dGV.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dGV.SelectedRows[0].Cells[2].Value.ToString();
            }
            GB.Visible = false;
        }


    }
}
