using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03图片浏览
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AddPhoto();
			//将图片的名字显示到listbox上
			List<Photo> list = GetPhotoList();
			listBox1.DataSource = list;
			listBox1.DisplayMember = "photoname";
			listBox1.ValueMember = "Id";
		}

		/// <summary>
		/// 获取list<photo>的方法
		/// </summary>
		/// <returns></returns>
		private static List<Photo> GetPhotoList()
		{
			List<Photo> list = new List<Photo>();
			string sql = "Select id,photoname from photos";
			SqlDataReader sdReader = SQLHelper.ExecuteReader(sql);
			if(sdReader.HasRows)
			{
				while(sdReader.Read())
				{
					Photo photo = new Photo();
					photo.Id = Convert.ToInt32(sdReader["id"]);
					photo.PhotoName = sdReader["photoname"].ToString();
					list.Add(photo);
				}
			}
			return list;
		}
		/// <summary>
		/// 向表中添加图片名字的方法
		/// </summary>
		private void AddPhoto()
		{
			string path = Path.GetFullPath(@".\Image");
			string[] filePaths = Directory.GetFiles(path);
			for(int i = 0;i < filePaths.Length;i++)
			{
				string fileName = Path.GetFileNameWithoutExtension(filePaths[i]);
				if(!IsHasPic(fileName))//如果表中不存在
				{
					string sql = string.Format("insert into photos(photoname) values('{0}')", fileName);
					SQLHelper.ExecuteNonQuery(sql);
				}
			}
		}
		/// <summary>
		/// 表中是否存在图片
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		private bool IsHasPic(string fileName)
		{
			string sql = string.Format("select * from photos where photoName='{0}'", fileName);
			SqlDataReader sdReader = SQLHelper.ExecuteReader(sql);
			if(sdReader.HasRows)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 双击显示图片
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//获取文件名
			string fileName = GetPhotoNameById(Convert.ToInt32(listBox1.SelectedValue));
			string fileFullPath = Path.Combine(Path.GetFullPath(@".\Image"), fileName + ".jpg");
			pictureBox1.ImageLocation = fileFullPath;

		}
		/// <summary>
		/// 根据id获取图片的名字
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		private string GetPhotoNameById(int p)
		{
			string sql = "select photoName from photos where id=" + p;
			return (string)SQLHelper.ExecuteScalar(sql);
		}
	}
}
