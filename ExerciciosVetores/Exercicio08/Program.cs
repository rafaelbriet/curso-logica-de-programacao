using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
	class Program
	{
		// DESCRIÇÃO: Cria um conjunto de alturas e sexos. Em seguida calcula a média de alturas das mulheres, a maior e menor altura do grupo e o número de homens;

		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double[] alturas = new double[n];
			string[] sexos = new string[n];

			string[] entrada;
			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				alturas[i] = double.Parse(entrada[0], CultureInfo.InvariantCulture);
				sexos[i] = entrada[1];
			}

			double menorAltura = 100.0;
			double maiorAltura = 0.0;
			double soma = 0.0;
			int quantidadeHomens = 0;
			int quantidadeMulheres = 0;
			
			// Determina qual maior e a menor alura
			for (int i = 0; i < n; i++)
			{
				if (alturas[i] < menorAltura)
				{
					menorAltura = alturas[i];
				}

				if (alturas[i] > maiorAltura)
				{
					maiorAltura = alturas[i];
				}
			}

			// Calcula o média de altura das mulheres
			for (int i = 0; i < n; i++)
			{
				if (sexos[i] == "M")
				{
					quantidadeHomens++;
				}
				else
				{
					soma += alturas[i];
					quantidadeMulheres++;
				}
			}

			double mediaAlturaMulheres = soma / quantidadeMulheres;

			// Exibe os resultados
			Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Media das alturas das mulheres = " + mediaAlturaMulheres.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Numero de homens = " + quantidadeHomens);

			Console.ReadLine();
		}
	}
}
