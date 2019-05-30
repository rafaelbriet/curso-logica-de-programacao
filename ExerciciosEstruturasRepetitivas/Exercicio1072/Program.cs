using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1072
{
	// DESCRIÇÃO: Lê um valor que irá determinar quantos números serão lidos em seguida, e exibe quantos deles estão dentro do limite 10-20 e quantos estão fora.

	class Program
	{
		static void Main(string[] args)
		{
			int n, x, dentro = 0, fora = 0;

			n = int.Parse(Console.ReadLine());

				for (int i = 0; i < n; i++)
				{
					x = int.Parse(Console.ReadLine());

					if (x >= 10 && x <= 20)
					{
						dentro++;
					}
					else
					{
						fora++;
					}
				}		

			Console.WriteLine(dentro + " in");
			Console.WriteLine(fora + " out");

			Console.ReadLine();
		}
	}
}
