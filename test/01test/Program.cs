using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01test
{
	class Program
	{
		static void Main(string[] args)
		{
			//给一个无序的List<int>类型的集合，请自己编写一个冒泡排序算法实现对List<int>集合中的数据进行排序。【20分】
			////给定集合：List<int> numList =new List<int>(){5,9,10,22,1,32,2,4};
			List<int> numList = new List<int>() { 5, 9, 10, 22, 1, 32, 2, 4 };

			for(int i = 0;i < numList.Count - 1;i++)
			{
				for(int j = 0;j < numList.Count - 1 - i;j++)
				{
					if(numList[j] > numList[j + 1])
					{
						int temp = numList[j];
						numList[j] = numList[j + 1];
						numList[j + 1] = temp;
					}
				}
			}
			//输出排序好的数组
			foreach(int item in numList)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}

	}
}
