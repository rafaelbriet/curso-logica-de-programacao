using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1158
{
	// DESCRIÇÃO: Lê um valor inteiro N que é a quantidade de casos de teste que vem a seguir. 
	// Cada caso de teste consiste de dois inteiros X e Y.Em seguida apresenta a soma de Y ímpares 
	// consecutivos a partir de X inclusive o próprio X se ele for ímpar.
	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			int n, x, y, soma = 0;

			n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				x = int.Parse(entrada[0]);
				y = int.Parse(entrada[1]);

				for (int j = 0, k = x; j < y; k++)
				{
					if (k % 2 != 0)
					{
						soma += k;
						j++;
					}
				}

				Console.WriteLine(soma);

				soma = 0;
			}

			Console.ReadLine();
		}
	}
}
