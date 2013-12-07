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

        private void btnUpdate_Click(object sender, EventArgs e)
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
    }
}
