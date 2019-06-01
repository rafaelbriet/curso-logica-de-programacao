using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1096
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				if (i % 2 != 0)
				{
					for (int j = 7; j > 4; j--)
					{
						Console.WriteLine("I=" + i + " " + "J=" + j);
					}					
				}
			}

			Console.ReadLine();
		}
	}
}
