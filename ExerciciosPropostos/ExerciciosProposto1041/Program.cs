using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProposto1041
{
	class Program
	{
		static void Main(string[] args)
		{
			float coordenadaX, coordenadaY;
			string[] entrada;

			entrada = Console.ReadLine().Split(' ');
			coordenadaX = float.Parse(entrada[0], CultureInfo.InvariantCulture);
			coordenadaY = float.Parse(entrada[1], CultureInfo.InvariantCulture);

			if (coordenadaX > 0f && coordenadaY > 0f)
			{
				Console.WriteLine("Q1");
			}
			else if (coordenadaX < 0f && coordenadaY > 0f)
			{
				Console.WriteLine("Q2");
			}
			else if (coordenadaX < 0f && coordenadaY < 0f)
			{
				Console.WriteLine("Q3");
			}
			else if (coordenadaX > 0f && coordenadaY < 0f)
			{
				Console.WriteLine("Q4");
			}
			else if (coordenadaX == 0f && (coordenadaY < 0 || coordenadaY > 0))
			{
				Console.WriteLine("Eixo Y");
			}
			else if ((coordenadaX < 0 || coordenadaX > 0) && coordenadaY == 0f)
			{
				Console.WriteLine("Eixo X");
			}
			else
			{
				Console.WriteLine("Origem");
			}

			Console.ReadLine();
		}
	}
}
