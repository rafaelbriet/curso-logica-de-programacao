using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
	class Program
	{
		// DESCRIÇÃO: Lê uma matriz quadrada e exibe a soma dos elementos acima da diagonal principal.

		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[,] matriz = new int[n, n];

			string[] entrada;
			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');
				for (int j = 0; j < n; j++)
				{
					matriz[i, j] = int.Parse(entrada[j]);
				}
			}

			int soma = 0;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					soma += matriz[i, j];
				}
			}

			Console.WriteLine(soma);

			Console.ReadLine();
		}
	}
}
