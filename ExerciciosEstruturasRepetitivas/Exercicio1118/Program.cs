using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1118
{
	// DESCRIÇÃO: Recebe duas notas de um aluno e calcula a média. Depois de se calculada a média o usúario é perguntado se deseja continuar (1. SIM | 2. NÃO). 

	class Program
	{
		static void Main(string[] args)
		{
			double notaUm, notaDois, media;
			int continuar = 1;

			while (continuar == 1)
			{
				// Calcula a primeira nota
				notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				while (notaUm < 0.0 || notaUm > 10.0)
				{
					Console.WriteLine("nota invalida");
					notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				}

				// Calcula a segunda nota
				notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				while (notaDois < 0.0 || notaDois > 10.0)
				{
					Console.WriteLine("nota invalida");
					notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				}

				// Calcula a média das notas
				media = (notaUm + notaDois) / 2.0;
				Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));


				// O programa deve continuar rodando?
				Console.WriteLine("novo calculo (1-sim 2-nao)");
				continuar = int.Parse(Console.ReadLine());
				while (continuar != 1 && continuar != 2)
				{
					Console.WriteLine("novo calculo (1-sim 2-nao)");
					continuar = int.Parse(Console.ReadLine());
				}
			}

			Console.WriteLine("PROGRAMA ENCERRADO");
			Console.ReadLine();
		}
	}
}
