using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
	class Bai04
	{
		static void Main(string[] args)
		{

			string HoTen;
			Console.WriteLine("Nhap ho ten: ");
			HoTen = Console.ReadLine();
			char[] HoTen_1;
			int l = 0;
			char ch;
			l = HoTen.Length;
			HoTen_1 = HoTen.ToCharArray(0, l);
			Console.WriteLine("Nhap diem mon hoc: ");
			Console.Write("Toan: ");
			int Toan = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ly: ");
			int Ly = Convert.ToInt32(Console.ReadLine());
			Console.Write("Hoa:");
			int Hoa = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < l; i++)
			{
				ch = HoTen_1[i];
				Console.Write(Char.ToUpper(ch));
			}
			Console.Write("\n");
			double DTB = (Toan + Ly + Hoa) / 3;
			Console.WriteLine("Diem trung binh: " + DTB);
		}
	}
}
