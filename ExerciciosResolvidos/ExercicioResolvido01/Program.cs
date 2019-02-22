using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioResolvido01
{
	class Program
	{
		static void Main(string[] args)
		{

			double largura;
			double comprimento;
			double valorMetro;
			double area;
			double valorTerreno;

			Console.WriteLine("Qual o alrgura do terreno?");
			largura = double.Parse(Console.ReadLine());
			Console.WriteLine("Qual o comprimento do terreno?");
			comprimento = double.Parse(Console.ReadLine());
			Console.WriteLine("Qual o valor do metro quadrado do terreno?");
			valorMetro = double.Parse(Console.ReadLine());

			area = largura * comprimento;
			valorTerreno = area * valorMetro;
			Console.WriteLine("------------------------------------------");
			Console.WriteLine($"ÁREA: {area:N2}m² ");
			Console.WriteLine($"PREÇO: {valorTerreno:N2}");
			Console.ReadLine();
		}
	}
}
