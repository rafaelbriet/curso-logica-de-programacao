using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1117
{
	// DESCRIÇÃO: Recebe duas notas de um aluno e calcula a média.

	class Program
	{
		static void Main(string[] args)
		{
			double notaUm, notaDois, media;

			notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			while (notaUm < 0 || notaUm > 10)
			{
				Console.WriteLine("nota invalida");
				notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}

			notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			while (notaDois < 0 || notaDois > 10)
			{
				Console.WriteLine("nota invalida");
				notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}

			media = (notaUm + notaDois) / 2;

			Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}
