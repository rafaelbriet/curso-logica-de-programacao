using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1079
{

	// DESCRIÇÃO: Lê um número inteiro que determina quantas entradas será possível a seguir.
	// Em seguida recebe 3 números reais e apresenta a média ponderada entre eles.
	// O primeiro valor tem peso 2.
	// O segundo valor tem peso 3.
	// O terceiro valor tem peso 5.

	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			double a, b, c, media;
			int n;

			n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
				b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
				c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

				media = (2 * a + 3 * b + 5 * c) / ( 2 + 3 + 5);

				Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
			}

			Console.ReadLine();
		}
	}
}
