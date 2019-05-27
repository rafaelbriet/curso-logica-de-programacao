using System;

namespace ExercicioProposto1061
{
	class Program
	{
		static void Main(string[] args)
		{
			int diaInicio, diaFim, horaInicio, horaFim, minutosInicio, minutosFim, segundosInicio, segundosFim, 
				diasDuracao, horasDuracao, minutosDuracao, segundoDuracao, resto, totalSegundosInicio, totalSegundosFim;
			string[] input;

			// INICIO DO EVENTO
			input = Console.ReadLine().Split(' ');
			diaInicio = int.Parse(input[1]);

			input = Console.ReadLine().Split(':');
			horaInicio = int.Parse(input[0]);
			minutosInicio = int.Parse(input[1]);
			segundosInicio = int.Parse(input[2]);

			// FIM DO EVENTO
			input = Console.ReadLine().Split(' ');
			diaFim = int.Parse(input[1]);

			input = Console.ReadLine().Split(':');
			horaFim = int.Parse(input[0]);
			minutosFim = int.Parse(input[1]);
			segundosFim = int.Parse(input[2]);

			totalSegundosInicio = (segundosInicio + minutosInicio * 60) + (horaInicio * 60 * 60) + (diaInicio * 24 * 60 * 60);
			totalSegundosFim = (segundosFim + minutosFim * 60) + (horaFim * 60 * 60) + (diaFim * 24 * 60 * 60);
			int duracao = totalSegundosFim - totalSegundosInicio;

			diasDuracao = duracao / 86400;
			resto = duracao % 86400;

			horasDuracao = resto / 3600;
			resto = resto % 3600;

			minutosDuracao = resto / 60;

			segundoDuracao = resto % 60;

			Console.WriteLine(diasDuracao + " dia(s)");
			Console.WriteLine(horasDuracao + " hora(s)");
			Console.WriteLine(minutosDuracao + " minuto(s)");
			Console.WriteLine(segundoDuracao + " segundo(s)");
			Console.ReadLine();
		}
	}
}
