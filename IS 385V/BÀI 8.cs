using System;

namespace BÀI_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhap ten hoc sinh:");
            string ten = (Console.ReadLine());
            Console.Write("Nhap diem thi cuoi ky: ");
            double diem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ho ten IN HOA : " + ten.ToUpper());
            if (diem >= 8) Console.WriteLine("Hoc sinh Gioi");
            else if (diem>=6.5) Console.WriteLine("Hoc sinh Kha");
            else if (diem >= 5) Console.WriteLine("Hoc sinh Trung Binh");
            else Console.WriteLine("Hoc sinh Yeu");
        }
    }
}
