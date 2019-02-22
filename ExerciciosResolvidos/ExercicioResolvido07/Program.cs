using System;
using System.Globalization;

namespace ExercicioResolvido07
{
	class Program
	{
		static void Main(string[] args)
		{

			double a, b, c, delta, r1, r2;
			string[] input;

			input = Console.ReadLine().Split(' ');

			a = double.Parse(input[0]);
			b = double.Parse(input[1]);
			c = double.Parse(input[2]);

			delta = Math.Pow(b, 2.0) - 4 * a * c;

			if (delta < 0.0	|| a == 0.0)
			{
				Console.WriteLine("Impossivel calcular");
			} 
			else
			{
				r1 = (-b + Math.Sqrt(delta)) / (2 * a);
				r2 = (-b - Math.Sqrt(delta)) / (2 * a);

				Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
				Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
			}

			Console.ReadLine();
		}
	}
}
