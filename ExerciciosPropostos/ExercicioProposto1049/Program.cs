using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1049
{

	// DESCRIÇÃO: Lê 3 palavras que definem o tipo de animal.
	class Program
	{
		static void Main(string[] args)
		{
			string a, b, c, animal;

			a = Console.ReadLine();
			b = Console.ReadLine();
			c = Console.ReadLine();

			if (a == "vertebrado")
			{
				if (b == "ave")
				{
					if (c == "carnivoro")
					{
						animal = "aguia";
					} else
					{
						animal = "pomba";
					}
				} else
				{
					if (c == "onivoro")
					{
						animal = "homem";
					}
					else
					{
						animal = "vaca";
					}
				}
			}
			else {
				if (b == "inseto")
				{
					if (c == "hematofago")
					{
						animal = "pulga";
					}
					else
					{
						animal = "lagarta";
					}
				}
				else
				{
					if (c == "hematofago")
					{
						animal = "sanguessuga";
					}
					else
					{
						animal = "minhoca";
					}
				}
			}

			Console.WriteLine(animal);

			Console.ReadLine();
		}
	}
}
