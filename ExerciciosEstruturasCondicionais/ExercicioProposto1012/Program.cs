using System;
using System.Globalization;

namespace ExercicioProposto1012
{
	class Program
	{
		static void Main(string[] args)
		{

			double A, B, C;
			double PI = 3.14159;
			double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
			string[] input;

			input = Console.ReadLine().Split(' ');

			A = double.Parse(input[0]);
			B = double.Parse(input[1]);
			C = double.Parse(input[2]);

			areaTriangulo = A * C / 2;
			areaCirculo = Math.Pow(C, 2) * PI;
			areaTrapezio = (A + B) * C / 2;
			areaQuadrado = B * B;
			areaRetangulo = A * B;

			Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}
