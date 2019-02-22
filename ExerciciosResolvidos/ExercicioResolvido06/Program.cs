using System;
using System.Globalization;

namespace ExercicioResolvido06
{
	class Program
	{
		static void Main(string[] args)
		{
			double notaUm, notaDois, notaFinal;

			notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			notaFinal = notaUm + notaDois;

			Console.WriteLine("NOTA FINAL: " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

			if (notaFinal < 60.0)
			{
				Console.WriteLine("REPROVADO");
			}

			Console.ReadLine();
		}
	}
}
