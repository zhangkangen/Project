using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02test
{
	public class Caipan
	{
		public string Panduan(int playerNumber, int computerNumber)
		{
			if(playerNumber - computerNumber == -1 || playerNumber - computerNumber == 2)
			{
				return "玩家胜利";
			}
			else if(playerNumber == computerNumber)
			{
				return "平局";
			}
			else
			{
				return "电脑胜利";
			}
		}
	}
}
