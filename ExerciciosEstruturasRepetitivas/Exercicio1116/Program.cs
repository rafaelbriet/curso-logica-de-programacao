using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1116
{
	// DESCRIÇÃO: Lê um número que define a quantidade de entrada a seguir.
	// Depois, realiza a divisão entre os valores inseridos, 
	// e exibe uma mensagem caso não seja possivel realizar o calculo.

	class Program
	{
		static void Main(string[] args)
		{
			int n;
			string[] entrada;
			double x, y, resultado;

			n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');
				x = double.Parse(entrada[0]);
				y = double.Parse(entrada[1]);

				if (y == 0)
				{
					Console.WriteLine("divisao impossivel");
				}
				else
				{
					resultado = x / y;
					Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
				}
			}

			Console.ReadLine();
		}
	}
}
