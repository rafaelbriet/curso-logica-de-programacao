using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
	class Program
	{
		// DESCRIÇÃO: Lê uma matriz quadrada e exibe o maior elemento de cada linha

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

			for (int i = 0; i < n; i++)
			{
				int maior = 0;
				for (int j = 0; j < n; j++)
				{
					if (matriz[i, j] > maior)
					{
						maior = matriz[i, j];
					}
				}

				Console.WriteLine($"{maior}");
			}

			Console.ReadLine();
		}
	}
}
