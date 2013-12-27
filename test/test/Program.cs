using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			new B().PrintFields();
			Console.ReadKey();
		}
	}

	public abstract class A
	{
		public A()
		{
			PrintFields();
		}

		public virtual void PrintFields()
		{
			Console.WriteLine("I am  parent");
		}
	}

	public class B:A
	{
		private int x = 1;
		private int y;

		public B()
		{
			y = -1;
		}

		public override void PrintFields()
		{
			Console.WriteLine("x={0},y={1}", x, y);
		}
	}
}
