using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioResolvido03
{
	class Program
	{
		static void Main(string[] args)
		{

			double comprimento, altura, area, perimentro, diagonal;

			comprimento = double.Parse(Console.ReadLine());
			altura = double.Parse(Console.ReadLine());

			area = comprimento * altura;
			perimentro = 2 * comprimento + 2 * altura;
			diagonal = Math.Sqrt(comprimento * comprimento + altura * altura);

			Console.WriteLine("AREA = " + area.ToString("F4"));
			Console.WriteLine("PERIMETRO = " + perimentro.ToString("F4"));
			Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"));
			Console.ReadLine();
		}
	}
}
