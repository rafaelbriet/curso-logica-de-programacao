using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1050
{

	// DESCRIÇÃO: Lê um número de DDD e determina de qual cidade ele pertence.

	class Program
	{
		static void Main(string[] args)
		{
			int ddd;
			string cidade;

			ddd = int.Parse(Console.ReadLine());

			switch (ddd)
			{
				case 61:
					cidade = "Brasilia";
					break;
				case 71:
					cidade = "Salvador";
					break;
				case 11:
					cidade = "Sao Paulo";
					break;
				case 21:
					cidade = "Rio de Janeiro";
					break;
				case 32:
					cidade = "Juiz de Fora";
					break;
				case 19:
					cidade = "Campinas";
					break;
				case 27:
					cidade = "Vitoria";
					break;
				case 31:
					cidade = "Belo Horizonte";
					break;
				default:
					cidade = "DDD nao cadastrado";
					break;
			}

			Console.WriteLine(cidade);
			Console.ReadLine();
		}
	}
}
