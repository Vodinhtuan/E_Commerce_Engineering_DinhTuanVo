using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
    class Bai02B
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
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
