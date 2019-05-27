using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1154
{

	// DESCRIÇÃO: Recebe a idade de um série de pessoas e calcula a média de idade entre elas.

	class Program
	{
		static void Main(string[] args)
		{
			double entrada, idade = 0, media, quantidade = 0;

			entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			while (entrada >= 0)
			{
				idade += entrada;
				quantidade++;
				entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}

			media = idade / quantidade;

			Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

			Console.ReadLine();
		}
	}
}
