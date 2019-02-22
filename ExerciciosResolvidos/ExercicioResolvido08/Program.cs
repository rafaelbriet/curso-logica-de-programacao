using System;
namespace ExercicioResolvido08
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b, c;

			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());

			if (a < b && a < c)
			{
				Console.Write("MENOR = " + a);
			}
			else if (b < c)
			{
				Console.Write("MENOR = " + b);
			}
			else
			{
				Console.Write("MENOR = " + c);
			}

			Console.ReadLine();
		}
	}
}
