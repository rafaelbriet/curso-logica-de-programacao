﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1020
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, anos, meses, dias, resto;

			N = int.Parse(Console.ReadLine());

			anos = N / 365;
			resto = N % 365;

			meses = resto / 30;

			dias = resto % 30;

			Console.WriteLine(anos + " ano(s)");
			Console.WriteLine(meses + " mes(es)");
			Console.WriteLine(dias + " dia(s)");
			Console.ReadLine();
		}
	}
}
