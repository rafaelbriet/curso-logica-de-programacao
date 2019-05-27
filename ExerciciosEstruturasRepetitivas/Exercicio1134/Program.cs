using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1134
{

	// DESCRIÇÃO: Recebe um código e determina que tipo de combustível vendido, ao final do programa, exibe o total de vendas para cada tipo de combustível.
	// CÓDIGOS: 1 = Álcool | 2 = Gasolina | 3 = Diesel | 4 = Fim

	class Program
	{
		static void Main(string[] args)
		{

			int alcool = 0, gasolina = 0, diesel = 0;

			int codigo = int.Parse(Console.ReadLine());

			while (codigo != 4)
			{
				switch (codigo)
				{
					case 1:
						alcool += 1;
						break;
					case 2:
						gasolina += 1;
						break;
					case 3:
						diesel += 1;
						break;
					default:
						break;
				}

				codigo = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("MUITO OBRIGADO");
			Console.WriteLine("Alcool: " + alcool.ToString());
			Console.WriteLine("Gasolina: " + gasolina.ToString());
			Console.WriteLine("Diesel: " + diesel.ToString());

			Console.ReadLine();
		}
	}
}
