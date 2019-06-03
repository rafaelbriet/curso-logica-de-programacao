using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1133
{
	// DESCRIÇÃO: Lê dois números e exibe todos o números entre os 
	// valores que o resto da divisão dele por cinco for igual 2 ou 3.

	class Program
	{
		static void Main(string[] args)
		{
			int x, y, maior, menor, resultado;

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

			for (int i = menor + 1; i < maior; i++)
			{
				if (i % 5 == 2 || i % 5 == 3)
				{
					Console.WriteLine(i);
				}
			}

			Console.ReadLine();
		}
	}
}
