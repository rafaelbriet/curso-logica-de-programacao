using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1051
{

	// DESCRIÇÃO: Lê o salário de uma pessoa e calcula a valor que deve ser pago de Imposto de Renda.

	class Program
	{
		static void Main(string[] args)
		{
			double salario, valorDevido;

			salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			// Tabela de porcentagem do Imposto d Renda:
			// Até R$ 2000,00                = isento
			// Entre R$ 2001,00 e R$ 3000,00 = 8%
			// Entre R$ 3001,00 e R$ 4500,00 = 18%
			// Acima de R$ 4500,00           = 28%

			// Uma mesma pessoa pode ter que pagar mais de uma faixa de imposto,
			// uma vez que o imposto é calculado sobre o valor que ultrapassa o limite da faixa.
			// Por exemplo: o imposto de uma pessoa que ganha R$ 4550,00, deverá ser calculado da
			// seguinte maneira:
			// R$ 2000,00 = isento
			// R$ 1000,00 = 8%
			// R$ 1500,00 = 18%
			// R$ 50,00   = 28%

			if (salario <= 2000.00)
			{
				Console.WriteLine("Isento");
			}
			else
			{
				// Eu estava tentando calcular a diferença de valor entre cada faixa do imposto,
				// mas após olhar o código no GitHub percebi que se o salário for maior que o limite de uma faixa
				// basta subtrair o limite do salário para pode calcular o imposto para essa faixa e para a faixa anterior,
				// basta calcular o imposto sobre o valor que corresponderia a faixar anterior completa.
				if (salario <= 3000.0)
				{
					valorDevido = 0.08 * (salario - 2000);
				}
				else if (salario <= 4500.00)
				{
					valorDevido = 0.18 * (salario - 3000) + 0.08 * 1000;
				} else
				{
					valorDevido = 0.28 * (salario - 4500) + 0.08 * 1000 + 0.18 * 1500;
				}

				Console.WriteLine("R$ " + valorDevido.ToString("F2", CultureInfo.InvariantCulture));
			}



			Console.ReadLine();
		}
	}
}
