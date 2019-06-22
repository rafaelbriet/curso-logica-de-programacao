using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
	class Program
	{
		// DESCRIÇÃO: Lê um conjunto de N nomes de alunos, assim como suas notas do primeiro e segundo semestre.
		// Calcula a média de cada aluno e exibe aqueles que tiveram nota maior de 6.0.

		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string[] nome = new string[n];
			double[] notaPrimeiroSemestre = new double[n];
			double[] notaSegundoSemetre = new double[n];

			string[] entrada;
			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				nome[i] = entrada[0];
				notaPrimeiroSemestre[i] = double.Parse(entrada[1], CultureInfo.InvariantCulture);
				notaSegundoSemetre[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);
			}

			Console.WriteLine("Alunos aprovados:");

			double media;
			for (int i = 0; i < n; i++)
			{
				media = (notaPrimeiroSemestre[i] + notaSegundoSemetre[i]) / 2;

				if (media >= 6.0)
				{
					Console.WriteLine(nome[i]);
				}
			}

			Console.ReadLine();
		}
	}
}
