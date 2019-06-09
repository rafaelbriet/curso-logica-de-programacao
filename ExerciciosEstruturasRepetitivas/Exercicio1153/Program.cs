using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1153
{
	// DESCRIÇÃO: Calcula o fatorial de um número

	class Program
	{
		static void Main(string[] args)
		{
			int n, fatorial;

			n = int.Parse(Console.ReadLine());

			fatorial = n;

			for (int i = n - 1; i > 1; i--)
			{
				fatorial *= i;
			}

			Console.WriteLine(fatorial.ToString());
			Console.ReadLine();
		}
	}
}
