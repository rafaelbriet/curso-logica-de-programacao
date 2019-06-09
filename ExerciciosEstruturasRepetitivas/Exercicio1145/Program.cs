using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1145
{
	class Program
	{
		// DESCRIÇÃO: Lê dois valores X e Y. A seguir, mostra uma 
		// sequência de 1 até Y, passando para a próxima linha a cada X números.

		static void Main(string[] args)
		{
			string[] entrada;
			int x, y;

			entrada = Console.ReadLine().Split();

			x = int.Parse(entrada[0]);
			y = int.Parse(entrada[1]);

			for (int i = 1; i <= y; i++)
			{
				if (i % x == 0)
				{
					Console.WriteLine(i);
				}
				else
				{
					Console.Write(i + " ");
				}
			}

			Console.ReadLine();
		}
	}
}
