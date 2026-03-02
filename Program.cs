using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat02
{
	internal class Program
	{
		static void jatek()
		{
			int[,] bingoTabla = new int[10, 5];

			for (int i = 0; i < bingoTabla.GetLength(0); i++)
			{
				Console.WriteLine($"Kérem a(z) {i+1} játékos adjon meg 5 számot!");
				for (int j = 0; j < bingoTabla.GetLength(1); j++)
				{
					bingoTabla[i, j] = Convert.ToInt32(Console.ReadLine());
					while (bingoTabla[i, j] < 1 || bingoTabla[i, j] > 75)
					{
						Console.WriteLine("Hibás szám! Kérem adjon meg egy új számot!");
						bingoTabla[i, j] = Convert.ToInt32(Console.ReadLine());
					}
				}
			}
			//for (int i = 0; i < bingoTabla.GetLength(0); i++)
			//{
			//	for (int j = 0; j < bingoTabla.GetLength(1); j++)
			//	{
			//		Console.WriteLine(bingoTabla[i, j]);
			//	}
			//}
		}
		static void Main(string[] args)
		{
			jatek();
		}
	}
}
