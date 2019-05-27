using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1043
{

	// DESCRIÇÃO: Lê três valores e se formarem um triângulo o programa calcula o perímentro do triângulo, caso contrário é calculado a áera de um trapézio.

	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			double a, b, c, perimetro, area;

			entrada = Console.ReadLine().Split(' ');
			a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
			b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
			c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

			if (a + b > c && b + c > a && a + c > b)
			{
				perimetro = a + b + c;
				Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
			}
			else
			{
				area = (a + b) * c / 2;
				Console.WriteLine("Area = " + area.ToString("F1"));
			}

			Console.ReadLine();
		}
	}
}
