using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02test
{
	public class Player
	{
		private string _fist;

		public string Fist
		{
			get { return _fist; }
			set { _fist = value; }
		}

		public Player(string fist)
		{
			this.Fist = fist;
		}

		public int ShowFist()
		{
			int res = 0;
			switch(this.Fist)
			{
				case "石头": res = 1; break;
				case "剪刀": res = 2; break;
				case "布": res = 3; break;
			}
			return res;
		}
	}
}
