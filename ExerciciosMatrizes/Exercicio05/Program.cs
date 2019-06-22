using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
	class Program
	{
		// DESCRIÇÃO: Lê dois valores que represeta o número de linhas e colunas de uma matriz.
		// Em seguida, ler um número de uma linha que deve ser invertida.

		static void Main(string[] args)
		{
			string[] entrada;
			int linha, coluna;

			linha = int.Parse(Console.ReadLine());
			coluna = int.Parse(Console.ReadLine());

			int[,] matriz = new int[linha, coluna];

			for (int i = 0; i < linha; i++)
			{
				entrada = Console.ReadLine().Split(' ');
				for (int j = 0; j < coluna; j++)
				{
					matriz[i, j] = int.Parse(entrada[j]);
				}
			}

			// Inverte a linha selecionada
			int linhaParaInverter = int.Parse(Console.ReadLine()) - 1;

			int ultimoDaColuna = matriz[linhaParaInverter, coluna - 1];

			for (int i = coluna - 1; i > 0; i--)
			{
				matriz[linhaParaInverter, i] = matriz[linhaParaInverter, i - 1];
			}

			matriz[linhaParaInverter, 0] = ultimoDaColuna;

			for (int i = 0; i < linha; i++)
			{
				for (int j = 0; j < coluna; j++)
				{
					Console.Write($"{matriz[i, j]} ");
				}
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
