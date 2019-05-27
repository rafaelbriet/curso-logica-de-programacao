using System;
using System.Globalization;

namespace ExercicioProposto1011
{
	class Program
	{
		static void Main(string[] args)
		{

			double raio;
			double volume;

			raio = double.Parse(Console.ReadLine());

			volume = (4.0 / 3) * Math.PI * Math.Pow(raio, 3.0);

			Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}