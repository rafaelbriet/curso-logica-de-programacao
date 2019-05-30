using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido1071
{
	// DESCRIÇÃO: Lê 2 valores inteiros e calcula a soma dos números impares entre eles.

	class Program
	{
		static void Main(string[] args)
		{

			int x, y, min, max, soma = 0;

			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());

			if (x < y)
			{
				min = x;
				max = y;
			} else
			{
				min = y;
				max = x;
			}

			for (int i = min + 1; i < max; i++)
			{
				if (i % 2 != 0)
				{
					soma += i;
				}
			}

			Console.WriteLine(soma);

			Console.ReadLine();
		}
	}
}
