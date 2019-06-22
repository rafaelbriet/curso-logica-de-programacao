using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1101
{
	class Program
	{
		// DESCRIÇÃO: Lê um conjunto não determinado de pares de valores. 
		// Para cada par lido, mostra a sequência do menor até o maior e
		// a soma dos inteiros consecutivos entre eles (incluindo o N e M). 
		// O programa para quando algum dos valores for menor ou igual a zero.

		static void Main(string[] args)
		{
			string[] entrada;
			int x, y, maior, menor, soma = 0;

			entrada = Console.ReadLine().Split(' ');

			x = int.Parse(entrada[0]);
			y = int.Parse(entrada[1]);

			while (x > 0 && y > 0)
			{
				if (x > y)
				{
					maior = x;
					menor = y;
				}
				else
				{
					maior = y;
					menor = x;
				}

				for (int i = menor; i <= maior; i++)
				{
					Console.Write(i + " ");
					soma += i;
				}

				Console.WriteLine("Sum=" + soma.ToString());
				soma = 0;

				entrada = Console.ReadLine().Split(' ');

				x = int.Parse(entrada[0]);
				y = int.Parse(entrada[1]);
			}

			Console.ReadLine();
		}
	}
}
