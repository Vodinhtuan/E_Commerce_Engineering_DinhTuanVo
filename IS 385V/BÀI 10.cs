using System;

namespace BÀI_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;         
            Console.WriteLine("Nhập n: ");
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n>=0) 
                break;
            }
        }
    }
}
