using System;

namespace ExercicioProposto1007
{
	class Program
	{
		static void Main(string[] args)
		{
			int A, B, C, D, difference;

			A = int.Parse(Console.ReadLine());
			B = int.Parse(Console.ReadLine());
			C = int.Parse(Console.ReadLine());
			D = int.Parse(Console.ReadLine());

			difference = A * B - C * D;

			Console.WriteLine("DIFERENCA = " + difference);
			Console.ReadLine();
		}
	}
}
