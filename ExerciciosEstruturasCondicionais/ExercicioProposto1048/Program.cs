using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1048
{

	// DESCRIÇÃO: Recebe um valor e calcula o aumento porcentual.

	class Program
	{
		static void Main(string[] args)
		{
			double salario, valorAumento, novoSalario, porcentual;

			salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			if (salario <= 400.0)
			{
				porcentual = 15.0;
				valorAumento = porcentual / 100 * salario;
				novoSalario = salario + valorAumento;
			}
			else if (salario > 400.0 && salario <= 800.0)
			{
				porcentual = 12.0;
				valorAumento = porcentual / 100 * salario;
				novoSalario = salario + valorAumento;
			}
			else if (salario > 800.0 && salario <= 1200.0)
			{
				porcentual = 10.0;
				valorAumento = porcentual / 100 * salario;
				novoSalario = salario + valorAumento;
			}
			else if (salario > 1200.0 && salario <= 2000.0)
			{
				porcentual = 7.0;
				valorAumento = porcentual / 100 * salario;
				novoSalario = salario + valorAumento;
			}
			else
			{
				porcentual = 4.0;
				valorAumento = porcentual / 100 * salario;
				novoSalario = salario + valorAumento;
			}

			Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Reajuste ganho: " + valorAumento.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Em percentual: " + porcentual.ToString("F0", CultureInfo.InvariantCulture) + " %");

			Console.ReadLine();
		}
	}
}
