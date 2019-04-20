using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1044
{

	// DESCRIÇÃO: Lê dois números inteiros e determina se são ou não múltiplos

	class Program
	{
		static void Main(string[] args)
		{

			string[] entrada;
			int a, b;

			entrada = Console.ReadLine().Split();

			a = int.Parse(entrada[0]);
			b = int.Parse(entrada[1]);

			if (a % b == 0 || b % a == 0)
			{
				Console.WriteLine("Sao Multiplos");
			}
			else
			{
				Console.WriteLine("Nao sao Multiplos");
			}

			Console.ReadLine();
		}
	}
}
