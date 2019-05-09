using System;

namespace ExercicioResolvido1113
{

	// DESCRIÇÃO: Recebe uma dubla de valores e determina se eles estão em ordem crescente ou decrescente.

	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			int x, y;

			entrada = Console.ReadLine().Split(' ');

			x = int.Parse(entrada[0]);
			y = int.Parse(entrada[1]);

			while(x != y)
			{
				if (x > y)
				{
					Console.WriteLine("Decrescente");
				}
				else
				{
					Console.WriteLine("Crescente");
				}

				entrada = Console.ReadLine().Split(' ');

				x = int.Parse(entrada[0]);
				y = int.Parse(entrada[1]);
			}


			Console.ReadLine();
		}
	}
}
