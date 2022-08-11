using System;

namespace BÀI_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Cac so nguyen duong tu 1 den n");
            Console.Write("Nhap n>0:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Cac so duong la:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0},", i);
            }
            Console.WriteLine("\b ");
            int s = 0, dem = 0;
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
