using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
    class Bai10
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int x;
            char y, n, a;
            bool kt = false;
            do
            {
                kt = false;
                Console.Write("Nhập vào 1 số nguyên: ");
                kt = Int32.TryParse(Console.ReadLine(), out x);
                //Hàm tryParse trả về true nếu ép kiểu thành công, false nếu ép kiểu thất bại
                if (x <= 0)
                { kt = false; }
                if (kt == false)
                {
                    Console.Write("Không phải số nguyên dương, nhập lại\n");
                    //Console.Clear();
                }
                else
                {
                    if ((x % 2) == 0)
                        Console.WriteLine("Day la so chan.");
                    else
                        Console.WriteLine("Day la so le.");
                    Console.ReadKey();
                }
            } while (kt == false);
        }
    }
}
