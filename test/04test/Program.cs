using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04test
{
	class Program
	{
		static void Main(string[] args)
		{
			//请编程程序把下面字符串中的数字提取出来。必须使用正则表达式。【20】

			//  “大家好呀，副本对象中的引用类型的55555数据成员与888源对象的数据成员指向相同的对象。而如果是深拷贝，则必须创建整个9对象的结构，33副本对象中的引用类型的数据成员与源对象的数据成员指向不同的对象。0
			//浅拷贝是容易实现的，就是使用前面提到的MemberwiseClone方法。开发人员往往希望使用的类型能够实现深拷贝，但会发现这样的类型并不 多。这种
			//，hello,2010年10月10日是个好日子。恩，9494.吼吼！886.”

			//思路：使用\d+而不是\d,\d只能提取单个的数字字符。

			string msg = "“大家好呀，副本对象中的引用类型的55555数据成员与888源对象的数据成员指向相同的对象。而如果是深拷贝，则必须创建整个9对象的结构，33副本对象中的引用类型的数据成员与源对象的数据成员指向不同的对象。0浅拷贝是容易实现的，就是使用前面提到的MemberwiseClone方法。开发人员往往希望使用的类型能够实现深拷贝，但会发现这样的类型并不 多。这种，hello,2010年10月10日是个好日子。恩，9494.吼吼！886.”";
			MatchCollection mc = Regex.Matches(msg, @"\d+");
			foreach(Match item in mc)
			{
				Console.WriteLine(item.Value);
			}
			Console.ReadKey();
		}
	}
}
