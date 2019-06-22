using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1157
{
	// DESCRIÇÃO: Lê um número e cacula todos os seus divisores

	class Program
	{
		static void Main(string[] args)
		{
			int n;

			n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					Console.WriteLine(i.ToString());
				}
			}

			Console.ReadLine();
		}
	}
}
