using System;
using System.Globalization;

namespace ExercicioProposto1014
{
	class Program
	{
		static void Main(string[] args)
		{

			int X;
			float Y, average;

			X = int.Parse(Console.ReadLine());
			Y = float.Parse(Console.ReadLine());

			average = X / Y;

			Console.WriteLine(average.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
			Console.ReadLine();
		}
	}
}
