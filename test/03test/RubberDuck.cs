using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03test
{
	public class RubberDuck:Duck, IShout
	{
		public override void Swim()
		{
			Console.WriteLine("我是橡皮鸭子，我会游泳");
		}

		public void Shout()
		{
			Console.WriteLine("我是橡皮鸭子。。。。唧唧。。。。");
		}
	}
}
