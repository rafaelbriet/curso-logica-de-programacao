using System;
using System.Globalization;

namespace ExercicioProposto1015
{
	class Program
	{
		static void Main(string[] args)
		{

			double x1, y1, x2, y2;
			double distancia;
			string[] input;

			input = Console.ReadLine().Split(' ');

			x1 = double.Parse(input[0]);
			y1 = double.Parse(input[1]);

			input = Console.ReadLine().Split(' ');

			x2 = double.Parse(input[0]);
			y2 = double.Parse(input[1]);

			distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

			Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}