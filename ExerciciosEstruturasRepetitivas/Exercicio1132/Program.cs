using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1132
{
	// DESCRIÇÃO: Lê dois valores e soma todos os números que não são múltiplos de 13 entre eles.

	class Program
	{
		static void Main(string[] args)
		{
			int x, y, maior, menor, soma = 0;

			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());

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
				if (i % 13 != 0)
				{
					soma += i;
				}
			}

			Console.WriteLine(soma);

			Console.ReadLine();
		}
	}
}
