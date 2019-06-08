using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1151
{
	// DESRIÇÃO: Sequência Fibonacci

	/******
	* A fórmula de Binet pode ser utilizada para o cálculo do n-ésimo número da sequência de Fibonacci:
	* f(n) = Φ ^ n - (1 - Φ) ^ n / √5
	* 
	* Para calcular Φ, podemos usar:
	* Φ = 1 + √5 / 2
	* 
	* Visto que (1 - Φ)n tende a zero à medida que n aumenta, podemos simplificar a fórmula de Binet eliminando este termo:
	* f(n) = Φ ^ n / √5
	* 
	* FONTE: http://www.matematicadidatica.com.br/SequenciaFibonacci.aspx
	* 
	* f = Math.Pow(GoldenRatio, i) / Math.Sqrt(5);
	* f = Math.Round(f);
	* 
	* Problemas com o arredontamento...
	******/

	class Program
	{
		static void Main(string[] args)
		{
			int anterior, proximo, f;
			int n = int.Parse(Console.ReadLine());

			anterior = 0;
			proximo = 1;

			if (n == 1)
			{
				Console.Write(anterior);
			}
			else if (n == 2)
			{
				Console.Write(anterior + " " + proximo);
			}
			else
			{
				Console.Write(anterior + " " + proximo);

				for (int i = 3; i <= n; i++)
				{
					f = anterior + proximo;

					Console.Write(" " + f);

					anterior = proximo;
					proximo = f;
				}
			}

			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
