using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
	// DESCRIÇÃO: Cria um vetor de tamanho N e exibe qual o maior número armazenado nele e qual sua posição.

	class Program
	{
		static void Main(string[] args)
		{
			int n;
			n = int.Parse(Console.ReadLine());

			string[] entrada;
			entrada = Console.ReadLine().Split(' ');


			int posição = 0;
			double maior = 0f;

			for (int i = 0; i < n; i++)
			{
				if (double.Parse(entrada[i], CultureInfo.InvariantCulture) > maior)
				{
					maior = double.Parse(entrada[i], CultureInfo.InvariantCulture);
					posição = i;
				}
			}

			Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
			Console.WriteLine(posição);

			Console.ReadLine();
		}
	}
}
