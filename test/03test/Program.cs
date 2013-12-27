using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03test
{
	class Program
	{
		static void Main(string[] args)
		{
			//定义一个鸭子（IDuck）的接口，接口中有两个方法：Swim()、Shout()
			//定义实现上面IDuck接口的三个类：
			//橡皮鸭子类（RubberDuck）、木鸭子(WookDuck)、真实的鸭子(RealDuck)。

			//请酌情实现三个子类的方法：鸭子都会游泳，而橡皮鸭子和真实的鸭子都会叫，只是叫声不一样，橡皮鸭子“唧唧”叫，真实地鸭子“嘎嘎”叫，木鸭子不会叫.【25分】

			RealDuck realDuck = new RealDuck();
			realDuck.Swim();
			realDuck.Shout();

			RubberDuck rubber = new RubberDuck();
			rubber.Swim();
			rubber.Shout();

			WoodDuck woodDuck = new WoodDuck();
			woodDuck.Swim();

			Console.ReadKey();
		}
	}
}
