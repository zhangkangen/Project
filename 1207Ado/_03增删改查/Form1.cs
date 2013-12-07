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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtAddName.Text;
            int gender = txtAddGender.Text == "男" ? 1 : txtAddGender.Text == "女" ? 0 : 2;//判断用户输入的性别是不是正确的
            int age = Convert.ToInt32(txtAddAge.Text);
            string phone = txtAddPhone.Text;

            //创建连接字符串
            string strConn = "Data Source=ZHANGKANG;Initial Catalog=DbTest;Integrated Security=true";
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
        }
    }
}
