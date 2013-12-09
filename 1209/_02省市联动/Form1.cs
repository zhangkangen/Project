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

namespace _02省市联动
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add(new Area() { AreaId = -1, AreaName = "请选择" });
			comboBox1.SelectedIndex = 0;
			LoadArea();
		}

		private void LoadArea()
		{
			string sql = "select areaid,areaname from tblarea where areapid=0";
			SqlDataReader sdReader = SQLHelper.ExecuteReader(sql);
			if(sdReader.HasRows)
			{
				while(sdReader.Read())
				{
					Area area = new Area();
					area.AreaId = Convert.ToInt32(sdReader["areaid"]);
					area.AreaName = sdReader["areaname"].ToString();
					comboBox1.Items.Add(area);
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox2.Items.Clear();
			comboBox2.Items.Add(new Area() { AreaId = -1, AreaName = "请选择" });
			comboBox2.SelectedIndex = 0;
			Area areas = comboBox1.SelectedItem as Area;
			string sql = "select areaid,areaname from tblarea where areapid=" + areas.AreaId;
			SqlDataReader sdReader = SQLHelper.ExecuteReader(sql);
			if(sdReader.HasRows)
			{				
				while(sdReader.Read())
				{
					Area area = new Area();
					area.AreaId = Convert.ToInt32(sdReader["areaid"]);
					area.AreaName = sdReader["areaname"].ToString();
					comboBox2.Items.Add(area);
				}
			}
		}
	}
}
