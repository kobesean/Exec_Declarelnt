using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//第三題
			//int zero = 0;
			int number4 = 9 % 2;
			int number5 = 202 % 2;
			//bool answer1 = (number4 == zero);
			//Console.WriteLine(answer1 + "答為奇數");
			//bool answer2 = (number5 == zero);
			//Console.WriteLine(answer2 + "答為偶數");
			if (number4 != 0)
			{
				Console.WriteLine("9為奇數");
			}
			else
			{
				Console.WriteLine("9為偶數");
			}
			if (number5 != 0)
			{
				Console.WriteLine("202為奇數");
			}
			else
			{
				Console.WriteLine("202為偶數");
			}
		}
	}
}
