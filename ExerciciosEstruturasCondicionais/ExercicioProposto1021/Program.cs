	using System;
	using System.Globalization;

	namespace ExercicioProposto1021
	{
		class Program
		{
			static void Main(string[] args)
			{
				// *** RESPOSTA DO INSTRUTOR DA UDEMY *** //
				// O problema ao lidar com centavos, está no arredondamento de divisão. Isso é um problema que pode acontecer sempre 
				// que lidamos com valores financeiros e moedas físicas, não apenas os valores em um sistema.
				// Minha sugestão para você é a seguinte, trabalhar com valores inteiros e não com números decimais e para isso, multiplicar 
				// todos os valores por 100, assim você ao invés de dividir por 0,01, irá dividir o valor por 1, assim a possibilidade de 
				// dar erro no arredondamento da divisão, some.
				// Multiplique o valor lido e os valores que você irá dividir por 100, e faça o cast para int, como no exemplo abaixo, 
				// assim você pega apenas o valor inteiro da divisão:
				// N = 100 * double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				// n100 = (int)N / 10000;
				// r100 = N % 10000;

				double N;
				int notaCem, notaCinquenta, notaVinte, notaDez, notaCinco, notaDois, moedaCem, moedaCinquenta, moedaVinteCinco, moedaDez, moedaCinco, moedaUm, resto;

				N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				resto = (int)(N * 100.0);

				// NOTAS
				notaCem = resto / 10000;
				resto = resto % 10000;
			
				notaCinquenta = resto / 5000;
				resto = resto % 5000;

				notaVinte = resto / 2000;
				resto = resto % 2000;

				notaDez = resto / 1000;
				resto = resto % 1000;

				notaCinco = resto / 500;
				resto = resto % 500;

				notaDois = resto / 200;
				resto = resto % 200;

				//MOEDAS
				moedaCem = resto / 100;
				resto = resto % 100;

				moedaCinquenta = resto / 50;
				resto = resto % 50;

				moedaVinteCinco = resto / 25;
				resto = resto % 25;

				moedaDez = resto / 10;
				resto = resto % 10;

				moedaCinco = resto / 5;

				moedaUm = resto % 5;

				Console.WriteLine("NOTAS:");
				Console.WriteLine(notaCem + " nota(s) de R$ 100.00");
				Console.WriteLine(notaCinquenta + " nota(s) de R$ 50.00");
				Console.WriteLine(notaVinte + " nota(s) de R$ 20.00");
				Console.WriteLine(notaDez + " nota(s) de R$ 10.00");
				Console.WriteLine(notaCinco + " nota(s) de R$ 5.00");
				Console.WriteLine(notaDois + " nota(s) de R$ 2.00");

				Console.WriteLine("MOEDAS:");
				Console.WriteLine(moedaCem + " moeda(s) de R$ 1.00");
				Console.WriteLine(moedaCinquenta + " moeda(s) de R$ 0.50");
				Console.WriteLine(moedaVinteCinco + " moeda(s) de R$ 0.25");
				Console.WriteLine(moedaDez + " moeda(s) de R$ 0.10");
				Console.WriteLine(moedaCinco + " moeda(s) de R$ 0.05");
				Console.WriteLine(moedaUm + " moeda(s) de R$ 0.01");

				Console.ReadLine();
			}
		}
	}
