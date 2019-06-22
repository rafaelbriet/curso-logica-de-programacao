using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
	class Program
	{
		// DESCRIÇÃO: Cria uma matriz de 8x8 e lê a poscição de uma torre, em seguida verifica se a torre tem condição de capturar alguma peça.

		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[,] tabuleiro = new int[8, 8];
			string[] entrada;

			for (int k = 0; k < n; k++)
			{
				for (int i = 0; i < 8; i++)
				{
					entrada = Console.ReadLine().Split(' ');

					for (int j = 0; j < 8; j++)
					{
						tabuleiro[i, j] = int.Parse(entrada[j]);
					}
				}

				entrada = Console.ReadLine().Split(' ');
				int linha = int.Parse(entrada[0]);
				int coluna = int.Parse(entrada[1]);
				bool podeCapturar = false;

				for (int i = 0; i < 8; i++)
				{
					if (tabuleiro[i, coluna - 1] == 1)
					{
						podeCapturar = true;
					}
					else if (tabuleiro[linha - 1, i] == 1)
					{
						podeCapturar = true;
					}
				}

				if (podeCapturar)
				{
					Console.WriteLine("S");
				} else
				{
					Console.WriteLine("N");
				}
			}

			Console.ReadLine();
		}
	}
}
