using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1143
{
	// DESCRIÇÃO: Lê um um número que representa a quantidade de saída.

	class Program
	{
		static void Main(string[] args)
		{
			int n, quadrado, cubo;

			n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				quadrado = (int)Math.Pow((double)i, 2.0);
				cubo = (int)Math.Pow((double)i, 3.0);

				Console.WriteLine(i + " " + quadrado + " " + cubo);
			}

			Console.ReadLine();
		}
	}
}
