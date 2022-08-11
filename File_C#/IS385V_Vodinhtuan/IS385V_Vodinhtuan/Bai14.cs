using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
    class Bai14A
    {
        static void Main(string[] args)
        {
            
                int s = 0, n, dem = 0;
                Console.WriteLine("Tinh tong va trung binh cong n so nguyen duong");
                Console.Write("Nhap n>0:");
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    s += i;
                    dem++;
                }
                double tbc = s / dem;
                Console.WriteLine("Tong la: {0}", s);
                Console.WriteLine("Trung binh cong:{0}", tbc);
                Console.ReadLine();
            
        }
    }
}
