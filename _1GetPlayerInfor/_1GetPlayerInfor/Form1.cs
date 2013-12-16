using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1GetPlayerInfor
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGetPlayerDetails_Click(object sender, EventArgs e)
		{
			#region 这个要联网
			////战斗力的html========================<span title='其中基础分1549 胜率加成分1032 胜场加成分429'>3010</span>
			////===================================<span title='其中基础分\d+ 胜率加成分\d+ 胜场加成分\d+'>(\d+)</span>

			////经典模式</td>          regex:经典模式</td>\s+<td>\s+\d+</td>\s+<td>.+?</td>\s+<td>\d+</td>\s+<td>\d+</td>
			//<td>
			//387</td>
			//<td>50.4%</td>
			//<td>195</td>
			//<td>192</td>

			//人机对战</td>          regex:人机对战</td>\s+<td>\s+\d+\s+</td>\s+<td>.+?</td>\s+<td>\d+</td>\s+<td>\d+</td>
			//  <td>
			//  63              </td>
			//  <td>93.7%</td>
			//  <td>59</td>
			//  <td>4</td>

			//string url = "http://lolbox.duowan.com/playerDetail.php?serverName=%E6%89%AD%E6%9B%B2%E4%B8%9B%E6%9E%97&playerName=%E9%9D%92%E6%98%A5%E4%B8%BF%E7%81%AC%E9%BB%91%E9%A9%AC";
			////string url = "http://lolbox.duowan.com/playerDetail.php?serverName=" + txtServerName + "&playerName=" + txtPlayerName;
			//WebClient wc = new WebClient();
			//wc.Encoding = Encoding.UTF8;
			//string contents = wc.DownloadString(url); 
			#endregion
			string contents = File.ReadAllText("1.txt", Encoding.Default);

			Match m = Regex.Match(contents, @"<span title='其中基础分\d+ 胜率加成分\d+ 胜场加成分\d+'>(\d+)</span>");
			Match m1 = Regex.Match(contents, @"经典模式</td>\s+<td>\s+(\d+)</td>\s+<td>(.+?)</td>\s+<td>(\d+)</td>\s+<td>(\d+)</td>");
			Match m2 = Regex.Match(contents, @"人机对战</td>\s+<td>\s+(\d+)\s+</td>\s+<td>(.+?)</td>\s+<td>(\d+)</td>\s+<td>(\d+)</td>");
			//MessageBox.Show(m.Groups[1].Value);
			//MessageBox.Show(m1.Groups[1].Value + m1.Groups[2].Value + m1.Groups[3].Value + m1.Groups[4].Value);
			//MessageBox.Show(m2.Groups[1].Value + m2.Groups[2].Value + m2.Groups[3].Value + m2.Groups[4].Value);
			label18.Text = m.Value;
			label9.Text = m1.Groups[1].Value;
			label10.Text = m1.Groups[2].Value;
			label11.Text = m1.Groups[3].Value;
			label12.Text = m1.Groups[4].Value;
			label13.Text = m2.Groups[1].Value;
			label14.Text = m2.Groups[2].Value;
			label15.Text = m2.Groups[3].Value;
			label16.Text = m2.Groups[4].Value;
		}
	}
}
