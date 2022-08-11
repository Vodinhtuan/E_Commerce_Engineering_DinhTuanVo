﻿using System;

namespace BÀI_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhap n:");
            n = int.Parse(Console.ReadLine());
            if (soNgto(n) == true) Console.WriteLine("La so nguyen to");
            else Console.WriteLine("Khong la so nguyen to");
        }
        static bool soNgto(int n)
        {
            if (n <= 1) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
