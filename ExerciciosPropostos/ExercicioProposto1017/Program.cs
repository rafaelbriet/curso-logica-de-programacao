using System;
using System.Globalization;

namespace ExercicioProposto1017
{
	class Program
	{
		static void Main(string[] args)
		{
			int tempo, velocidade, distancia;
			float litros;

			tempo = int.Parse(Console.ReadLine());
			velocidade = int.Parse(Console.ReadLine());

			distancia = tempo * velocidade;
			litros = (float) distancia / 12;

			Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}
