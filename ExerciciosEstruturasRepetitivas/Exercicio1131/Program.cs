using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1131
{
	// DESCRIÇÃO: Recebe o número de gols de uma série de partidas de futebol, ao final do programa exibe quandos jogos aconteceram e qual time ganhou mais. 

	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			int golsInter, golsGremio, jogos = 0, vitoriasInter = 0, vitoriasGremio = 0, empates = 0, continuar = 1;

			while (continuar == 1)
			{
				entrada = Console.ReadLine().Split(' ');
				golsInter = int.Parse(entrada[0]);
				golsGremio = int.Parse(entrada[1]);

				if (golsInter > golsGremio)
				{
					vitoriasInter++;
				}
				else if (golsInter < golsGremio)
				{
					vitoriasGremio++;
				}
				else
				{
					empates++;
				}

				jogos++;

				Console.WriteLine("Novo grenal (1-sim 2-nao)");
				continuar = int.Parse(Console.ReadLine());
				while (continuar != 1 && continuar != 2)
				{
					Console.WriteLine("Novo grenal (1-sim 2-nao)");
					continuar = int.Parse(Console.ReadLine());
				}
			}

			Console.WriteLine(jogos.ToString() + " grenais");
			Console.WriteLine("Inter:" + vitoriasInter.ToString());
			Console.WriteLine("Gremio:" + vitoriasGremio.ToString());
			Console.WriteLine("Empates:" + empates.ToString());

			if (vitoriasInter > vitoriasGremio)
			{
				Console.WriteLine("Inter venceu mais");
			}
			else
			{
				Console.WriteLine("Gremio venceu mais");
			}

			Console.WriteLine("PROGRAMA ENCERRADO");
			Console.ReadLine();
		}
	}
}
