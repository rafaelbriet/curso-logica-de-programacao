using System;
using System.Globalization;

namespace ExercicioProposto1008
{
	class Program
	{
		static void Main(string[] args)
		{

			int trabalhador, horasTrabalhadas;
			float salarioPorHora, salario;

			trabalhador = int.Parse(Console.ReadLine());
			horasTrabalhadas = int.Parse(Console.ReadLine());
			salarioPorHora = float.Parse(Console.ReadLine());

			salario = horasTrabalhadas * salarioPorHora;

			Console.WriteLine("NUMBER = " + trabalhador);
			Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}
