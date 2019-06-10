using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1160
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			int n, populaçãoA, populaçãoB, tempo;
			double crescimentoA, crescimentoB;

			n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				populaçãoA = int.Parse(entrada[0]);
				populaçãoB = int.Parse(entrada[1]);
				crescimentoA = double.Parse(entrada[2], CultureInfo.InvariantCulture);
				crescimentoB = double.Parse(entrada[3], CultureInfo.InvariantCulture);

				tempo = 0;

				while (populaçãoA <= populaçãoB && tempo <= 100) 
				{
					populaçãoA = (int)(populaçãoA * (100.0 + crescimentoA) / 100.0);
					populaçãoB = (int)(populaçãoB * (100.0 + crescimentoB) / 100.0);
					tempo++;
				}
				
				if (tempo <= 100)
				{
					Console.WriteLine(tempo.ToString() + " anos.");
				}
				else
				{
					Console.WriteLine("Mais de 1 seculo.");
				}
			}

			Console.ReadLine();
		}
	}
}
