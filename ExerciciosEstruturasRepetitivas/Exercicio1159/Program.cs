using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1159
{

	// DESCRIÇÃO: Recebe um valor e calcula a soma dos dos próximos cinco números pares (incluindo ele caso seja par).

	class Program
	{
		static void Main(string[] args)
		{
			int soma;
			int x = int.Parse(Console.ReadLine());

			while (x != 0)
			{
				if (x % 2 != 0)
				{
					x += 1;
				}

				soma = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);

				Console.WriteLine(soma.ToString());
				x = int.Parse(Console.ReadLine());
			}

			Console.ReadLine();
		}
	}
}
