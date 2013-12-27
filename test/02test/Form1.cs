using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02test
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnStone_Click(object sender, EventArgs e)
		{
			PlayGame(btnStone);

		}

		private void PlayGame(Button btn)
		{
			Player player = new Player(btn.Text);
			int playerNumber = player.ShowFist();
			lblPlayer.Text = player.Fist;

			Computer com = new Computer();
			string comFist = com.showFist();
			lblComputer.Text = comFist;

			int computerNumber = com.Fist;

			Caipan cp = new Caipan();

			lblRes.Text = cp.Panduan(playerNumber, computerNumber);
		}

		private void btnCut_Click(object sender, EventArgs e)
		{
			PlayGame(btnCut);
		}

		private void btnCloth_Click(object sender, EventArgs e)
		{
			PlayGame(btnCloth);
		}
	}
}
