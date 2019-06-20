using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
	class Program
	{
		// DESCRIÇÃO: Cria um vetor com N elementos, em seguida exibe a média entre eles e todos os valores que estão abaixo da média.

		static void Main(string[] args)
		{
			// Cria o vetor
			int n = int.Parse(Console.ReadLine());
			double[] valores = new double[n];

			// Preenche o vetor
			string[] entrada = Console.ReadLine().Split(' ');

			for (int i = 0; i < n; i++)
			{
				valores[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
			}

			// Calcula a média
			double soma = 0.0;
			double media;

			foreach (var valor in valores)
			{
				soma += valor;
			}

			media = soma / n;

			Console.WriteLine(media.ToString(CultureInfo.InvariantCulture));

			// Exibe os valores abaixo da média
			foreach (var valor in valores)
			{
				if (valor < media)
				{
					Console.WriteLine(valor.ToString(CultureInfo.InvariantCulture));
				}
			}

			Console.ReadLine();
		}
	}
}
