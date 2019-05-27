using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1115
{

	// DESCRIÇÃO: Recebe dois pontos do sistema cartesiano e determina à qual quadrante pertence as coordenadas.

	class Program
	{
		static void Main(string[] args)
		{
			string[] coordenadas;
			string mensagem;
			int x, y;

			coordenadas = Console.ReadLine().Split(' ');

			x = int.Parse(coordenadas[0]);
			y = int.Parse(coordenadas[1]);

			while (x != 0 && y != 0)
			{

				if (x > 0 && y > 0)
				{
					mensagem = "primeiro";
				}
				else if (x < 0 && y > 0)
				{
					mensagem = "segundo";
				}
				else if (x < 0 && y < 0)
				{
					mensagem = "terceiro";
				}
				else
				{
					mensagem = "quarto";
				}

				Console.WriteLine(mensagem);

				coordenadas = Console.ReadLine().Split(' ');

				x = int.Parse(coordenadas[0]);
				y = int.Parse(coordenadas[1]);
			}

			Console.ReadLine();
		}
	}
}
