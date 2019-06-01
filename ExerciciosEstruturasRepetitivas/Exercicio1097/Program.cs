using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1097
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 7;

			for (int i = 0; i < 10; i++)
			{
				if (i % 2 != 0)
				{
					for (int j = x; j > x - 3; j--)
					{
						Console.WriteLine("I=" + i + " J=" + j);
					}

					x += 2;
				}
			}

			Console.ReadLine();
		}
	}
}
