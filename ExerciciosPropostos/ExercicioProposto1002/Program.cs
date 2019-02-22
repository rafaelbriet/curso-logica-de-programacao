using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos1002
{
	class Program
	{
		static void Main(string[] args)
		{

			double raio;
			double area;
			double n = 3.14159;

			raio = double.Parse(Console.ReadLine());

			area = n * Math.Pow(raio, 2.0);

			//Console.WriteLine($"A={area:N4}");
			Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}
