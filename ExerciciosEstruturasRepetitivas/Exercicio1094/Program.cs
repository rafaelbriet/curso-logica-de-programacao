using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1094
{
	// DESCRIÇÃO: Lê um número que indica a quantidade de dados que será inserido a seguir.
	// Cada linha de dado recebe uma quantidade (int) e um tipo de cobaia (R: Rato; S: Sapo; C: Coelho).
	// Ao final, é exibido o total de cobaias utilizadas, a quantidade por tipo e a porcentagem em relação ao total.

	class Program
	{
		static void Main(string[] args)
		{
			int n, quantidade, total = 0, ratos = 0, sapos = 0, coelhos = 0;
			double porcentagemRatos, porcentagemSapos, porcentagemCoelhos;
			string[] entrada;
			string tipo;

			// Determina a quantidade de dados que será inserida
			n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				// Entrada de dados
				entrada = Console.ReadLine().Split(' ');

				quantidade = int.Parse(entrada[0]);
				tipo = entrada[1];

				// Soma a quantidade inserida ao total de cobaias já utilizadas
				total += quantidade;

				// Dependendo do tipo de cobaia soma a quantidade de dados inserido ao total desse mesmo tipo
				switch (tipo)
				{
					case "R":
						ratos += quantidade;
						break;
					case "S":
						sapos += quantidade;
						break;
					case "C":
						coelhos += quantidade;
						break;
					default:
						break;
				}
			}

			// Calcula a porcentagem de cada cobaia utilizada em relação ao total
			porcentagemCoelhos = (double)coelhos / (double)total * 100.0;
			porcentagemRatos = (double)ratos / (double)total * 100.0;
			porcentagemSapos = (double)sapos / (double)total * 100.0;

			// Exibe o resultado
			Console.WriteLine("Total: " + total + " cobaias");
			Console.WriteLine("Total de coelhos: " + coelhos);
			Console.WriteLine("Total de ratos: " + ratos);
			Console.WriteLine("Total de sapos: " + sapos);
			Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
			Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
			Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");

			Console.ReadLine();
		}
	}
}
