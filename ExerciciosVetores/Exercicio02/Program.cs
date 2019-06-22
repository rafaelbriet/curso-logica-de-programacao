using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
	// DESCRIÇÃO: Cira um vetor de tamanho N e exibe todos os números pares e a quantidade de números pares armazenados nele.

	class Program
	{
		static void Main(string[] args)
		{
			// Cria o vetor
			int n;
			int[] vetores;

			n = int.Parse(Console.ReadLine());
			vetores = new int[n];

			// Valores que serão inseridos no vetor de inteiros
			string[] entrada;
			entrada = Console.ReadLine().Split(' ');
			for (int i = 0; i < n; i++)
			{
				vetores[i] = int.Parse(entrada[i]);
			}

			// Determina quais dos números são pares e a quantidade de números pares
			int quantidade = 0;
			foreach (var vetor in vetores)
			{
				if (vetor % 2 == 0)
				{
					Console.Write(vetor + " ");
					quantidade++;
				}
			}
			Console.WriteLine();
			Console.WriteLine(quantidade);

			Console.ReadLine();
		}
	}
}
