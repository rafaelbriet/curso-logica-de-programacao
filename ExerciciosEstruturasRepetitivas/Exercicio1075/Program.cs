using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1075
{

	// DESCRIÇÃO: Lê um número é exibe todos os números entre 1 e 10000 que dividido por ele tenha resto 2.

	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i < 10000; i++)
			{
				if (i % n == 2)
				{
					Console.WriteLine(i);
				}
			}

			Console.ReadLine();
		}
	}
}
