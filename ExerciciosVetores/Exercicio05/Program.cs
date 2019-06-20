using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
	class Program
	{
		// DESCRIÇÃO: Cria um vetor com N elementos e exibe a média dos elementos pares.

		static void Main(string[] args)
		{
			// Cria o vetor
			int n = int.Parse(Console.ReadLine());
			int[] valores = new int[n];

			// Preenche o vetor com os valores inseridos
			string[] entrada = Console.ReadLine().Split(' ');
			for (int i = 0; i < n; i++)
			{
				valores[i] = int.Parse(entrada[i]);
			}

			// Calcula a média dos elementos pares
			int soma = 0;
			int quantidade = 0;
			foreach (var valor in valores)
			{
				if (valor % 2 == 0)
				{
					soma += valor;
					quantidade++;
				}
			}

			double media = soma / quantidade;
			Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

			Console.ReadLine();
		}
	}
}
