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

			for (int i = 2; i <= 100; i++)
			{
				s += 1.0 / i;
			}

			Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}
