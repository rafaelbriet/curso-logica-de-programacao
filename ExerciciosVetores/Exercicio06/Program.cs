using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
	class Program
	{
		// DESCRIÇÃO: Cria um vetor de pessoa e suas idades e em seguida exibe a pessoa mais velha.

		static void Main(string[] args)
		{
			// Cria os vetores
			int n = int.Parse(Console.ReadLine());
			int[] idades = new int[n];
			string[] nomes = new string[n];

			// Preenche cada vetor com seus respectivos dados.
			string[] entrada;
			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				idades[i] = int.Parse(entrada[1]);
				nomes[i] = entrada[0];
			}

			// Determina quem é o mais velho
			int maior = 0;
			string maisVelho = "";
			for (int i = 0; i < n; i++)
			{
				if (idades[i] > maior)
				{
					maior = idades[i];
					maisVelho = nomes[i];
				}
			}

			Console.WriteLine("Pessoa mais velha: " + maisVelho);

			Console.ReadLine();
		}
	}
}
