using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IS385V_Vodinhtuan
{
	class Bai01A
	{
		static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.WriteLine("Nhap so nguyen n: ");
			int n = Convert.ToInt32(Console.ReadLine());
			if (n % 2 == 0)
			{
				Console.WriteLine($"{ n} là số chẵn.");
			}
			else
			{
				Console.WriteLine($"{ n} là  số lẻ.");
			}
		}
	}
}
