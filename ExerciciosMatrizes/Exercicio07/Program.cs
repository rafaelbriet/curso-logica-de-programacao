using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
	class Program
	{
		// DESCRIÇÃO: Cria uma tabuleiro de xadrez
		// T = Torre
		// P = Peão
		// - = Vazio

		/*** 
			ENTRADAS VÁLIDAS

			- - - - - - - P
			P - - - - - - -
			- - - - - - - -
			- - - - - - - -
			- - - - - - - -
			- - - - T - - -
			- - - - - - - -
			- P P - - - - -

			- - - - - - - -
			P - - - - - - -
			- - - - P - - -
			- - - - - - - -
			- - - - - - - -
			- - - P T - - -
			- - - - - - - -
			- - P - - - - -
		***/


		static void Main(string[] args)
		{
			char[,] tabuleiro = new char[8, 8];
			bool[,] movimentosValidos = new bool[8, 8];

			// Cria o tabuleiro
			for (int i = 0; i < 8; i++)
			{
				string[] entrada = Console.ReadLine().Split(' ');

				for (int j = 0; j < 8; j++)
				{
					tabuleiro[i, j] = char.Parse(entrada[j]);
				}
			}

			// Encontra a posição da torre
			int torreLinha = 0;
			int torreColuna = 0;

			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (tabuleiro[i, j] == char.Parse("T"))
					{
						torreLinha = i;
						torreColuna = j;
					}
				}
			}

			Console.WriteLine();
			Console.WriteLine(torreLinha);
			Console.WriteLine(torreColuna);

			// Verifica quais são os movimentos válidos
			// Verifica as casa à direita
			for (int j = torreColuna + 1; j < 8; j++)
			{
				movimentosValidos[torreLinha, j] = true;

				if (tabuleiro[torreLinha, j] == char.Parse("P"))
				{
					break;
				}
			}

			// Verifica as casas à esquerda
			for (int j = torreColuna - 1; j >= 0; j--)
			{
				movimentosValidos[torreLinha, j] = true;

				if (tabuleiro[torreLinha, j] == char.Parse("P"))
				{
					break;
				}
			}

			// Verifica as casa à abaixo
			for (int i = torreLinha + 1; i < 8; i++)
			{
				movimentosValidos[i, torreColuna] = true;

				if (tabuleiro[i, torreColuna] == char.Parse("P"))
				{
					break;
				}
			}

			// Verifica as casa à acima
			for (int i = torreLinha - 1; i >= 0; i--)
			{
				movimentosValidos[i, torreColuna] = true;

				if (tabuleiro[i, torreColuna] == char.Parse("P"))
				{
					break;
				}
			}

			// Exibe os movimentos válidos
			Console.WriteLine();

			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (movimentosValidos[i, j] == true)
					{
						Console.Write("X ");
					} else
					{
						Console.Write("- ");
					}
				}

				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
