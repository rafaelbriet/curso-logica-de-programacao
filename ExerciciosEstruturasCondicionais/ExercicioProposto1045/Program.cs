using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1045
{

	// DESCRIÇÃO: Recebe três valores inteiros, ordena-os em ordem decrescente, e apresenta que tipo de triângulo esses valores formam.

	class Program
	{
		static void Main(string[] args)
		{

			string[] entrada;
			double a, b, c, ladoA, ladoB, ladoC;

			entrada = Console.ReadLine().Split(' ');

			a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
			b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
			c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

			// Ordena os três valores em ordem decrescente.
			if (a >= b && b >= c)
			{
				ladoA = a;
				ladoB = b;
				ladoC = c;
			}
			else if (a <= b && b <= c)
			{
				ladoA = c;
				ladoB = b;
				ladoC = a;
			}
			else if (a <= b && b <= c)
			{
				ladoA = b;
				ladoB = c;
				ladoC = a;
			}
			else if (a >= b && b <= c)
			{
				ladoA = a;
				ladoB = c;
				ladoC = b;
			}
			else if (a <= b && b >= c)
			{
				ladoA = b;
				ladoB = a;
				ladoC = c;
			}
			else
			{
				ladoA = c;
				ladoB = a;
				ladoC = b;
			}

			Console.WriteLine(ladoA);
			Console.WriteLine(ladoB);
			Console.WriteLine(ladoC);

			// Verifica qual o tipo de triângulo.
			if (ladoA >= ladoB + ladoC)
			{
				Console.WriteLine("NAO FORMA TRIANGULO");
			}
			else
			{
				if (Math.Pow(ladoA, 2.0) == Math.Pow(ladoB, 2.0) + Math.Pow(ladoC, 2.0))
				{
					Console.WriteLine("TRIANGULO RETANGULO");
				}

				if (Math.Pow(ladoA, 2.0) > Math.Pow(ladoB, 2.0) + Math.Pow(ladoC, 2.0))
				{
					Console.WriteLine("TRIANGULO OBTUSANGULO");
				}
				else if (Math.Pow(ladoA, 2.0) < Math.Pow(ladoB, 2.0) + Math.Pow(ladoC, 2.0))
				{
					Console.WriteLine("TRIANGULO ACUTANGULO");
				}

				if (ladoA == ladoB && ladoB == ladoC && ladoC == ladoA)
				{
					Console.WriteLine("TRIANGULO EQUILATERO");
				}
				else if (ladoA == ladoB || ladoB == ladoC || ladoC == ladoA)
				{
					Console.WriteLine("TRIANGULO ISOSCELES");
				}
			}

			Console.ReadLine();
		}
	}
}
