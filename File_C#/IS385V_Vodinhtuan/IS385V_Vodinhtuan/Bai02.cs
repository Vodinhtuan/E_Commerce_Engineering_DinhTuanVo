using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
    class Bai02
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập chiều dài hình chữ nhật:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng hình chữ nhật:");
            float b = float.Parse(Console.ReadLine());
            float P = (a + b) * 2;
            Console.Write($"Chu vi hình chữ nhật là: {P}\n");
            float S = a * b;
            Console.Write($"Diện tích hình chữ nhật là: {S}");
            Console.ReadKey();
        }
    }
}
