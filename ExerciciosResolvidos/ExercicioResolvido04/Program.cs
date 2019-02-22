using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioResolvido04
{
	class Program
	{
		static void Main(string[] args)
		{

			string nome1, nome2;
			int idade1, idade2;
			float mediaIdade;
			string[] entrada;

			entrada = Console.ReadLine().Split(' ');
			nome1 = entrada[0];
			idade1 = int.Parse(entrada[1]);
				
			entrada = Console.ReadLine().Split(' ');
			nome2 = entrada[0];
			idade2 = int.Parse(entrada[1]);

			mediaIdade = (float) (idade1 + idade2) / 2f;

			Console.WriteLine($"A idade média de {nome1} e {nome2} é de {mediaIdade:N1} anos");
			Console.ReadLine();
		}
	}
}
