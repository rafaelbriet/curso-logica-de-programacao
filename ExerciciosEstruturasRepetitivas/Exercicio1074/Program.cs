using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1074
{

	// DESCRIÇÃO: Lê um número, correspondente à quantidade de entradas que será aceito a seguir. 
	// Após isso, exibe se o novo número é par ou impar, positivo ou negativo.
	// Caso o número seja 0 será exibido NULL.

	class Program
	{
		static void Main(string[] args)
		{

			int n, x;

			n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				x = int.Parse(Console.ReadLine());

				if (x == 0)
				{
					Console.WriteLine("NULL");
				}
				else if (x % 2 == 0 && x > 0)
				{
					// O número é par e positivo
					Console.WriteLine("EVEN POSITIVE");
				}
				else if (x % 2 == 0 && x < 0)
				{
					// O número é par e negativo
					Console.WriteLine("EVEN NEGATIVE");
				}
				else if (x % 2 != 0 && x > 0)
				{
					// O número é impar e positivo
					Console.WriteLine("ODD POSITIVE");
				}
				else
				{
					// O número é impar e negativo
					Console.WriteLine("ODD NEGATIVE");
				}
			}

			Console.ReadLine();
		}
	}
}
