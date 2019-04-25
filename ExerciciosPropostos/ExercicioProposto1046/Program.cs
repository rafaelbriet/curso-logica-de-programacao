using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1046
{
	class Program
	{

		//DESCRIÇÃO: Recebe a hora inicial e final de um jogo e calcula o tempo de duração.

		static void Main(string[] args)
		{
			string[] entrada;
			int inicio, fim, duracao;

			entrada = Console.ReadLine().Split(' ');

			inicio = int.Parse(entrada[0]);
			fim = int.Parse(entrada[1]);

			if (inicio == fim)
			{
				Console.WriteLine("O JOGO DUROU 24 HORA(S)");
			}
			else if (inicio > fim)
			{
				duracao = (24 - inicio) + fim;
				Console.WriteLine("O JOGO DUROU " + duracao.ToString() + " HORA(S)");
			}
			else if (inicio < fim)
			{
				duracao = fim - inicio;
				Console.WriteLine("O JOGO DUROU " + duracao.ToString() + " HORA(S)");
			}

			Console.ReadLine();
		}
	}
}
