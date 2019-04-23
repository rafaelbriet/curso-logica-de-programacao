using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1042
{
	// DESCRIÇÃO: Lê três valores inteiros e ordena em ordem crescente.

	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			double a, b, c;

			entrada = Console.ReadLine().Split(' ');

			a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
			b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
			c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

			if (a < b && a < c)
			{
				Console.WriteLine(a);

				if (b < c)
				{
					Console.WriteLine(b);
					Console.WriteLine(c);
				} else
				{
					Console.WriteLine(c);
					Console.WriteLine(b);
				}
			} else if (b < a && b < c)
			{
				Console.WriteLine(b);

				if (a < c)
				{
					Console.WriteLine(a);
					Console.WriteLine(c);
				} else
				{
					Console.WriteLine(c);
					Console.WriteLine(a);
				}
			} else
			{
				Console.WriteLine(c);

				if (a < b)
				{
					Console.WriteLine(a);
					Console.WriteLine(b);
				} else
				{
					Console.WriteLine(b);
					Console.WriteLine(a);
				}
			}

			Console.WriteLine();
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);

			Console.ReadLine();
		}
	}
}
