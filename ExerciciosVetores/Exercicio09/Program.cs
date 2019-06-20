using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
	class Program
	{
		// DESCRIÇÃO: Lê um conjunto de mercadorias, com nome, preço de compra e preço de venda.
		// Em seguida, calcula o porcentual de lucro conforme a tabela abaixo:
		// lucro < 10%
		// 10% <= lucro <= 20%
		// lucro > 20%
		// Por último, calcula a valor total de compra, venda e lucro.

		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string[] produto = new string[n];
			double[] valorCompra = new double[n];
			double[] valorVenda = new double[n];

			string[] entrada;
			for (int i = 0; i < n; i++)
			{
				entrada = Console.ReadLine().Split(' ');

				produto[i] = entrada[0];
				valorCompra[i] = double.Parse(entrada[1], CultureInfo.InvariantCulture);
				valorVenda[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);
			}

			int lucroBaixo = 0;
			int lucroMedio = 0;
			int lucroAlto = 0;

			double lucro;
			double totalCompra = 0.0;
			double totalVenda = 0.0;
			double totalLucro = 0.0;
			double porcentagemLucro;

			for (int i = 0; i < n; i++)
			{
				lucro = valorVenda[i] - valorCompra[i];
				totalCompra += valorCompra[i];
				totalVenda += valorVenda[i];
				totalLucro += lucro;

				porcentagemLucro = lucro / valorCompra[i] * 100;

				if (porcentagemLucro < 10)
				{
					lucroBaixo++;
				}
				else if (porcentagemLucro >= 10 && porcentagemLucro <= 20)
				{
					lucroMedio++;
				}
				else
				{
					lucroAlto++;
				}
			}

			Console.WriteLine("Lucro abaixo de 10%: " + lucroBaixo);
			Console.WriteLine("Lucro entre 10% e 20%: " + lucroMedio);
			Console.WriteLine("Lucro acima de 20%: " + lucroAlto);
			Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));

			Console.ReadLine();
		}
	}
}
