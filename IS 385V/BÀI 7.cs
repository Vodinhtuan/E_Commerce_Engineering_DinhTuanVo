using System;

namespace BÀI_7
{
    internal class Program
    {
        static void Main(string[] args)
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
            if (n == 0)
            {
                Console.WriteLine("n is equal to 0");
            }
            if (n < 0)
            {
                Console.WriteLine("n là số âm");
            }
            if (n > 0)
            {
                Console.WriteLine("n là số dương");
            }
        }
    }
}
