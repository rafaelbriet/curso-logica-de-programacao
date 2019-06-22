using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
	// DESCRIÇÃO: Cria uma matriz quadrada e realiza um série de ações.

	class Program
	{
		static void Main(string[] args)
		{
			// Cria a matriz
			int n = int.Parse(Console.ReadLine());
			double[,] matriz = new double[n, n];

			// Preenche a matriz
			string[] entrada;
			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				for (int j = 0; j < n; j++)
				{
					matriz[i, j] = double.Parse(entrada[j], CultureInfo.InvariantCulture);
				}
			}

			// Escolhe uma linha e uma coluna da matriz
			int linha = int.Parse(Console.ReadLine());
			int coluna = int.Parse(Console.ReadLine());

			// Soma todos os elementos positivos da matriz
			double soma = 0.0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (matriz[i, j] > 0)
					{
						soma += matriz[i, j];
					}
				}
			}

			Console.WriteLine($"SOMA DOS POSITIVOS: {soma.ToString("F1", CultureInfo.InvariantCulture)}");

			// Exibe a linha escolhida
			Console.Write("LINHA ESCOLHIDA: ");
			for (int i = 0; i < n; i++)
			{
				Console.Write($"{matriz[linha, i].ToString("F1", CultureInfo.InvariantCulture)} ");
			}

			Console.WriteLine();

			// Exibe a coluna escolhida
			Console.Write("COLUNA ESCOLHIDA: ");
			for (int i = 0; i < n; i++)
			{
				Console.Write($"{matriz[i, coluna].ToString("F1", CultureInfo.InvariantCulture)} ");
			}

			Console.WriteLine();

			// Exibe a diagonal principal
			Console.Write("DIAGONAL PRINCIPAL: ");
			for (int i = 0; i < n; i++)
			{
				Console.Write($"{matriz[i, i].ToString("F1", CultureInfo.InvariantCulture)} ");
			}

			Console.WriteLine();

			// Eleva ao quadrado todos os elementos negativos da matriz
			Console.WriteLine("MATRIZ ALTERADA:");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (matriz[i, j] < 0)
					{
						matriz[i, j] = Math.Pow(matriz[i, j], 2.0);
					}
				}
			}

			// Exibe a nova matriz
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write($"{matriz[i, j].ToString("F1", CultureInfo.InvariantCulture)} ");
				}

				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
