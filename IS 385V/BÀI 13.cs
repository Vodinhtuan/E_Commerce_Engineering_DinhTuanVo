using System;

namespace BÀI_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0, n;
            Console.WriteLine("Tinh tong:1+2+3...+n");
            Console.Write("Nhap n>0:");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s += i;
            }
            Console.WriteLine("Tong la: {0}", s);
            
            Console.WriteLine("Tinh tong:1/2+1/3+1/4...+1/n");
            Console.Write("Nhap n>0:");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s = s + 1.0 / i;
            }
            Console.WriteLine("Tong la: {0}", s);
            Console.ReadLine();
        }
    }    
}
