using System;
using System.Globalization;

namespace ExercicioProposto1009
{
	class Program
	{
		static void Main(string[] args)
		{

			string nome;
			double salario;
			double totalVendas;
			double salarioComBonus;

			nome = Console.ReadLine();
			salario = double.Parse(Console.ReadLine());
			totalVendas = double.Parse(Console.ReadLine());

			salarioComBonus = salario + (totalVendas * 0.15);

			Console.WriteLine("TOTAL = R$ " + salarioComBonus.ToString("F2", CultureInfo.InvariantCulture));
			Console.ReadLine();

		}
	}
}
