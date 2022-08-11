using System;

namespace BÀI_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten : ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Diem Toan : ");
            double toan = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem Ly : ");
            double ly = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem Hoa : ");
            double hoa = double.Parse(Console.ReadLine());
            double dtb = (toan + ly + hoa) / 3;
            Console.WriteLine("Ho ten IN HOA : " + hoTen.ToUpper());
            Console.WriteLine("DTB = " + dtb);
        }
    }
}
