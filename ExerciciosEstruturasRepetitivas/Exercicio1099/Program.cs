using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1099
{
	// Lê um número que representa a quantidade de entradas. Em seguida, soma todos os números impares entre X e Y 

	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			int n, x, y, soma = 0, menor, maior;

			n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');
				x = int.Parse(entrada[0]);
				y = int.Parse(entrada[1]);

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

				for (int j = menor + 1; j < maior; j++)
				{
					if (j % 2 != 0)
					{
						soma += j;
					}
				}

				Console.WriteLine(soma.ToString());
				soma = 0;
			}

			Console.ReadLine();
		}
	}
}
