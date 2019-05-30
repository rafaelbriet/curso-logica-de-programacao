using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1067
{
	// DESCRIÇÃO: Lê um número e exibe todos os números até ele.

	class Program
	{
		static void Main(string[] args)
		{

			int x = int.Parse(Console.ReadLine());

			for (int i = 1; i <= x; i++)
			{
				if (i % 2 != 0)
				{
					Console.WriteLine(i);
				}
			}

			Console.ReadLine();
		}
	}
}
