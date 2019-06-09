using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1155
{
	class Program
	{
		static void Main(string[] args)
		{
			double s = 1.0;
			double dividendo = 3.0;
			double divisor = 2.0;

			for (int i = 1; i <= 18; i++)
			{
				s += dividendo / divisor;
				dividendo += 2.0;
				divisor *= 2.0;

				//Console.WriteLine(dividendo.ToString("F2", CultureInfo.InvariantCulture) + " : " + divisor.ToString("F2", CultureInfo.InvariantCulture));
			}

			Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}

