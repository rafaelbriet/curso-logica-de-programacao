using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
	class Program
	{
		// DESCRIÇÃO: Cria dois vetores com n elementos em seguida gera um terceiro vetor com o resultado da soma de cada elemento do dois primeiro vetores.

		static void Main(string[] args)
		{
			// Gera os vetores
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			int[] b = new int[n];
			int[] c = new int[n];

			// Preenche o primeiro vetor
			string[] entrada = Console.ReadLine().Split(' ');
			for (int i = 0; i < n; i++)
			{
				a[i] = int.Parse(entrada[i]);
			}

			// Preenche o segundo vetor
			entrada = Console.ReadLine().Split(' ');
			for (int i = 0; i < n; i++)
			{
				b[i] = int.Parse(entrada[i]);
			}

			// Preenche o terceiro vetor com a soma de cada elemento do primeiro e segundo vetor
			for (int i = 0; i < n; i++)
			{
				c[i] = a[i] + b[i];
			}

			foreach (var indice in c)
			{
				Console.Write(indice + " ");
			}

			Console.ReadLine();
		}
	}
}
