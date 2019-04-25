using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1047
{
	class Program
	{

		// DESCRIÇÃO: Recebe a hora e minutos inicial e final de um jogo e calcula o tempo de duração.

		static void Main(string[] args)
		{

			string[] entrada;
			int horaInicio, minutoInicio, horaFim, minutoFim, horaDuracao, minutosDuracao, inicio, fim, duracao = 0;

			entrada = Console.ReadLine().Split(' ');

			horaInicio = int.Parse(entrada[0]);
			minutoInicio = int.Parse(entrada[1]);
			horaFim = int.Parse(entrada[2]);
			minutoFim = int.Parse(entrada[3]);

			// Primeiro é necessário converter todo o tempo para minutos.
			inicio = 60 * horaInicio + minutoInicio;
			fim = 60 * horaFim + minutoFim;

			// Então faz as validações necessárias para calcular a duração do jogo.
			// Se o inicio e fim do jogo forem iguais isso significa que o jogo durou 24h.
			if (inicio == fim)
			{
				Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
			}
			else
			{
				// Se o inicio é maior que o fim significa que jogo começou num dia e passou para o outro,
				// para saber a duração do jogo nesse caso é necessário subtrair o total de minutos do dia da hora inicial do jogo,
				// pois assim descobrimos quanto tempo resta no dia, e então somar com o tempo passado no próximo dia, desta forma
				// obtemos a duração total do jogo.
				if (inicio > fim)
				{
					duracao = 24 * 60 - inicio + fim;
				}
				// Por último, se o inicio for menor que o fim significa que o jogo acabou no mesmo dia,
				// nesse caso é preciso subtrair o fim do inicio para saber a diferença de tempo entre os dois
				// e assim obtermos a duração.
				else
				{
					duracao = fim - inicio;
				}

				// Já que estamos trabalhando com minutos, para converter esse valor para horas basta dividir a duração por 60
				// (já que uma hora possuí 60 minutos), o resultado dessa divisão é a duração em horas do jogo, e o que sobrar são os minutos.
				horaDuracao = duracao / 60;
				minutosDuracao = duracao % 60;

				Console.WriteLine("O JOGO DUROU " + horaDuracao.ToString() + " HORA(S) E " + minutosDuracao.ToString() + " MINUTO(S)");
			}

			Console.ReadLine();
		}
	}
}