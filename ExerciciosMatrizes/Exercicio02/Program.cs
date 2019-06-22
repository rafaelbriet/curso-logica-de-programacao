using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
	class Program
	{
		// DESCRIÇÃO: Lê duas matrizes e cria uma terceira matriz com a soma dos elementos das duas primeiras.

		static void Main(string[] args)
		{
			string[] entrada;
			int linha, coluna;

			entrada = Console.ReadLine().Split(' ');
			linha = int.Parse(entrada[0]);
			coluna = int.Parse(entrada[1]);

			// Cria a primeira matriz
			int[,] matrizA = new int[linha, coluna];
			for (int i = 0; i < linha; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				for (int j = 0; j < coluna; j++)
				{
					matrizA[i, j] = int.Parse(entrada[j]);
				}
			}

			// Cria a segunda matriz
			int[,] matrizB = new int[linha, coluna];
			for (int i = 0; i < linha; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				for (int j = 0; j < coluna; j++)
				{
					matrizB[i, j] = int.Parse(entrada[j]);
				}
			}

			// Cria a terceira matriz com com a soma dos elementos da matrizA e matrizB
			int[,] matrizC = new int[linha, coluna];
			for (int i = 0; i < linha; i++)
			{
				for (int j = 0; j < coluna; j++)
				{
					matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
				}
			}

			// Exibe o resultado da matrizC
			for (int i = 0; i < linha; i++)
			{
				for (int j = 0; j < coluna; j++)
				{
					Console.Write($"{matrizC[i, j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
