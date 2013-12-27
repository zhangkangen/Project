using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02test
{
	public class Computer
	{
		private int _fist;

		public int Fist
		{
			get { return _fist; }
			set { _fist = value; }
		}
		public Computer()
		{
			Random r = new Random();
			int rNum = r.Next(1, 4);
			this.Fist = rNum;
		}

		public string showFist()
		{
			string res = "";
			switch(this.Fist)
			{
				case 1: res = "石头"; break;
				case 2: res = "剪刀"; break;
				case 3: res = "布"; break;
			}
			return res;
		}
	}
}
