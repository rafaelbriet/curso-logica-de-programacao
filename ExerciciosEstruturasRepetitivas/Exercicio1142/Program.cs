using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1142
{
	// DECRIÇÃO: Lê um número que representa a quantidade de saída que será exibida.

	class Program
	{
		static void Main(string[] args)
		{
			int n, x = 1;

			n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				for (int j = x; j <= x + 2; j++)
				{
					Console.Write(j + " ");
				}

				x += 4;

				Console.WriteLine("PUM");
			}

			Console.ReadLine();
		}
	}
}
