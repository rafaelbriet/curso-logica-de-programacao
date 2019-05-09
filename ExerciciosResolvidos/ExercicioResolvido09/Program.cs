using System;
using System.Globalization;

namespace ExercicioResolvido09
{

	//DESCRIÇÃO: Recebe uma série de números e calcula a média entre eles.

	class Program
	{
		static void Main(string[] args)
		{
			double idadeSomada = 0;
			int vezes = 0;
			double media;

			int idade = int.Parse(Console.ReadLine());

			if (idade < 0)
			{
				Console.WriteLine("impossivel calcular");
			}
			else
			{
				while (idade >= 0)
				{
					idadeSomada += idade;

					vezes++;

					idade = int.Parse(Console.ReadLine());
				}

				media = idadeSomada / vezes;

				Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
			}

			Console.ReadLine();
		}
	}
}
