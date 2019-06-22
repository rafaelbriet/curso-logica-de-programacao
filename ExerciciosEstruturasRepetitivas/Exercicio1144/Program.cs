using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1144
{
	class Program
	{
		static void Main(string[] args)
		{
			int quadrado, cubo;
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				quadrado = (int)Math.Pow((double)i, 2.0);
				cubo = (int)Math.Pow((double)i, 3.0);

				Console.WriteLine(i + " " + quadrado + " " + cubo);
				Console.WriteLine(i + " " + (quadrado + 1) + " " + (cubo + 1));
			}

			Console.ReadLine();
		}
	}
}
