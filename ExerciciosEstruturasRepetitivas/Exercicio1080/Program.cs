using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1080
{
	// DESCRIÇÃO: Lê 100 números e exibe qual o maior valor digitado e a posição em que foi digitado;

	class Program
	{
		static void Main(string[] args)
		{
			int n, maior = 0, posicao = 0;

			for (int i = 0; i < 100; i++)
			{
				n = int.Parse(Console.ReadLine());

				if (n > maior)
				{
					maior = n;
					posicao = i + 1;
				}
			}

			Console.WriteLine(maior);
			Console.WriteLine(posicao);

			Console.ReadLine();
		}
	}
}
