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

namespace _03增删改查
{
    public delegate void LoadDGV();
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }
        public FormUpdate(string str, LoadDGV lDGV)
            : base()
        {
            this.Id = str;
            this._lDGV = lDGV;
            InitializeComponent();
        }
        string id;

        LoadDGV _lDGV;//委托字段

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 更新或者添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.id == "add")
            {
                AddStudent();
            }
            else
            {
                UpdateStudent();
            }
        }
        /// <summary>
        /// 添加数据的方法
        /// </summary>
        private void AddStudent()
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
            _lDGV();
            this.Close();//关闭窗体
        }
        /// <summary>
        /// 更改数据库中数据的方法
        /// </summary>
        private void UpdateStudent()
        {
            string name = txtAddName.Text;
            int gender = txtAddGender.Text == "男" ? 1 : txtAddGender.Text == "女" ? 0 : 2;
            int age = int.Parse(txtAddAge.Text);
            string phone = txtAddPhone.Text;

            string strConn = "Data Source=ZHANGKANG;Initial Catalog=DBtest;Integrated Security=true";
            string sql = string.Format("update student set name='{0}',gender={1},age={2},phoneNumber='{3}' where id={4}", name, gender, age, phone, this.Id);
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
                MessageBox.Show("修改成功");
                _lDGV();
                this.Close();
            }
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            if (this.id == "add")
            {
                groupBox1.Text = "增加";
                btnUpdate.Text = "添加";
            }
        }
    }
}
