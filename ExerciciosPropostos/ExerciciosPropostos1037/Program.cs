using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProposto1037
{
	class Program
	{
		static void Main(string[] args)
		{
			float valor;

			valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			if (valor >= 0f && valor <= 25f)
			{
				Console.WriteLine("Intervalo [0,25]");
			}
			else if (valor > 25f && valor <= 50f)
			{
				Console.WriteLine("Intervalo (25,50]");
			}
			else if (valor > 50f && valor <= 75f)
			{
				Console.WriteLine("Intervalo (50,75]");
			}
			else if (valor > 75f && valor <= 100f)
			{
				Console.WriteLine("Intervalo (75,100]");
			} else
			{
				Console.WriteLine("Fora de intervalo");
			}

			var info = Console.ReadKey();
			if (info.Key == ConsoleKey.R)
			{
				System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
				Environment.Exit(0);
			}
		}
	}
}
