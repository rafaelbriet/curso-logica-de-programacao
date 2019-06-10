using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1150
{

	// DESCRIÇÃO: Lê um valor para X e um valor para Z, que deve ser relido caso seja menor ou igual a X.
	// Em seguida exiber quantos X é necessário somar para que ele seja maior que Z.
	class Program
	{
		static void Main(string[] args)
		{
			int x, z, quantidade = 0;

			x = int.Parse(Console.ReadLine());

			do
			{
				z = int.Parse(Console.ReadLine());
			}
			while (z <= x);

			for (int i = x, temp = 0; temp < z; i++)
			{
				temp += i;
				quantidade++;
			}
			Console.WriteLine(quantidade.ToString());

			Console.ReadLine();
		}
	}
}
