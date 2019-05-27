using System;

namespace ExercicioProposto1013
{
	class Program
	{
		static void Main(string[] args)
		{

			int A, B, C;
			int maiorAB;
			string[] input;

			input = Console.ReadLine().Split(' ');

			A = int.Parse(input[0]);
			B = int.Parse(input[1]);
			C = int.Parse(input[2]);

			maiorAB = (A + B + Math.Abs(A - B)) / 2;
			maiorAB = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

			Console.WriteLine(maiorAB.ToString() + " eh o maior");
			Console.ReadLine();
		}
	}
}