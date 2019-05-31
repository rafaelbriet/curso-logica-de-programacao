using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1073
{
	class Program
	{

		// DESCRIÇÃO: Lê um valor e exebibe o quadrado dos números pares até ele.

		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				if (i % 2 == 0)
				{
					int quadrado = (int)Math.Pow(i, 2.0);
					Console.WriteLine(i + "^2 = " + quadrado);
				}
			}

			Console.ReadLine();
		}
	}
}