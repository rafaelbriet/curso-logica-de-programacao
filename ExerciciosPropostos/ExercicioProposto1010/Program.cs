using System;
using System.Globalization;

namespace ExercicioProposto1008
{
	class Program
	{
		static void Main(string[] args)
		{
			int produtoUmCod, produtoUmQnt, produtoDoisCod, produtoDoisQnt;
			double produtoUmPreco, produtoDoisPreco, totalAPagar;
			string[] vet;

			vet = Console.ReadLine().Split(' ');
			produtoUmCod = int.Parse(vet[0]);
			produtoUmQnt = int.Parse(vet[1]);
			produtoUmPreco = double.Parse(vet[2]);

			vet = Console.ReadLine().Split(' ');
			produtoDoisCod = int.Parse(vet[0]);
			produtoDoisQnt = int.Parse(vet[1]);
			produtoDoisPreco = double.Parse(vet[2]);

			totalAPagar = produtoUmQnt * produtoUmPreco + produtoDoisQnt * produtoDoisPreco;

			Console.WriteLine("VALOR A PAGAR: R$ " + totalAPagar.ToString("F2", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}
