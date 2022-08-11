using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
    class Bai03
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập một cạnh của hình vuông:");
            float a = float.Parse(Console.ReadLine());
            float S = a * a;
            Console.Write($"Diện tích của hình vuông là: {S}\n");
            float P = a * 4;
            Console.Write($"Chu vi của hình vuông là: {P}");
            Console.ReadKey();
        }
    }
}
