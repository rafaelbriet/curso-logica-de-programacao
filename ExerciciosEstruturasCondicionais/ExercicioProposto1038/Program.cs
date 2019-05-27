using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1038
{
	class Program
	{
		static void Main(string[] args)
		{
			int produto, quantidade;
			double total = 0;
			string[] input;

			input = Console.ReadLine().Split(' ');

			produto = int.Parse(input[0]);
			quantidade = int.Parse(input[1]);


			switch (produto)
			{
				case 1:
					total = quantidade * 4.00;
					break;
				case 2:
					total = quantidade * 4.50;
					break;
				case 3:
					total = quantidade * 5.00;
					break;
				case 4:
					total = quantidade * 2.00;
					break;
				case 5:
					total = quantidade * 1.50;
					break;
				default:
					break;
			}

			Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

			Console.ReadLine();
		}
	}
}
