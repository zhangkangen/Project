using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03test
{
	public class RealDuck:Duck, IShout
	{
		public override void Swim()
		{
			Console.WriteLine("我是真鸭子，会游泳");
		}

		public void Shout()
		{
			Console.WriteLine("我是真鸭子。。。嘎嘎嘎嘎。。。");
		}
	}
}
