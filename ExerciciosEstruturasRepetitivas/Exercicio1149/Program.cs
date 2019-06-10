using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1149
{
	// DESCRIÇÃO: Lê dois valores A e N. Em seguida exibe a multiplicação desse valores, mais a soma dos número d 0 até N - 1;
	// Caso o N seja igual ou menor que zero deve ser solicitado uma nova entrada para N;

	class Program
	{
		static void Main(string[] args)
		{
			string[] entrada;
			int a, n, multiplação, soma;

			entrada = Console.ReadLine().Split(' ');

			a = int.Parse(entrada[0]);

			int i = 1;

			while (int.Parse(entrada[i]) <= 0)
			{
				i++;
			}

			n = int.Parse(entrada[i]);

			multiplação = a * n;

			soma = multiplação;
			for (i = 0; i < n; i++)
			{
				soma += i;
			}

			Console.WriteLine(soma.ToString());

			Console.ReadLine();
		}
	}
}
