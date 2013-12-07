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

namespace _03增删改查
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 像数据库表中添加一条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtAddName.Text;
            int gender = txtAddGender.Text == "男" ? 1 : txtAddGender.Text == "女" ? 0 : 2;//判断用户输入的性别是不是正确的
            int age = Convert.ToInt32(txtAddAge.Text);
            string phone = txtAddPhone.Text;

            //创建连接字符串
            string strConn = "Data Source=ZHANGKANG;Initial Catalog=DBTest;Integrated Security=true";
            //创建sql语句
            string sql = string.Format("INSERT INTO student(name,gender,age,phonenumber) VALUES('{0}',{1},{2},'{3}')", name, gender, age, phone);
            int count = -1;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                }
            }
            if (count > 0)
            {
                MessageBox.Show("添加成功");
            }
            //刷新数据
            LoadDGV();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void LoadDGV()
        {
            //创建一个集合用来存放student对象
            List<Student> list = new List<Student>();
            //数据库连接字符串
            string strConn = "Data Source=ZHANGKANG;Initial Catalog=DBTest;Integrated Security=true";
            //数据库操作语句
            string sql = "SELECT id,name,gender,age,phoneNumber FROM student";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //打开数据库
                    conn.Open();
                    using (SqlDataReader sdReader = cmd.ExecuteReader())
                    {
                        if (sdReader.HasRows)
                        {
                            while (sdReader.Read())
                            {
                                Student stu = new Student();
                                stu.Id = sdReader.GetInt32(0);
                                stu.Name = sdReader.GetString(1);
                                stu.Gender = sdReader.GetBoolean(2) == true ? '男' : '女';
                                stu.Age = sdReader.GetInt32(3);
                                stu.Phone = sdReader.GetString(4);
                                list.Add(stu);
                            }
                        }
                    }
                }
            }//第一个using
            dgv.DataSource = list;
        }

        /// <summary>
        /// 删除选中的数据行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string strConn = "Data Source=ZHANGKANG;Initial Catalog=DBTest;Integrated Security=true";
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string sql = "DELETE from student WHERE id=" + id;
                int count = -1;
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        count = cmd.ExecuteNonQuery();
                    }//end using

                }//end using
                if (count > 0)
                {
                    LoadDGV();//重新加载
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }//end if
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
            FormUpdate fu = new FormUpdate(id, LoadDGV);
            fu.Show();
        }
        /// <summary>
        /// 查询班级人数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentCount_Click(object sender, EventArgs e)
        {
            LoadDGV();
            string strConn = "Data Source=ZHANGKANG;Initial catalog=DBTest;Integrated Security=true";
            string sql = "select count(*) from student";
            string count = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = cmd.ExecuteScalar().ToString();
                }

            }//end using
            MessageBox.Show("班级人数是" + count + "人");
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            FormUpdate fuAdd = new FormUpdate("add", LoadDGV);
            fuAdd.Show();
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


    }
}
