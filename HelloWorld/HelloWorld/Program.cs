using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello CSharp, Nice to meet you!");
			Console.WriteLine("What is your name human and how old are you?");
			string[] input = Console.ReadLine().Split(' ');
			string name = input[0];
			int age = int.Parse(input[1]);
			int year = 2019 - age - 1;
			Console.WriteLine("Hello " + name + ", so you were born in " + year + ".");
			Console.ReadLine();
		}
	}
}
