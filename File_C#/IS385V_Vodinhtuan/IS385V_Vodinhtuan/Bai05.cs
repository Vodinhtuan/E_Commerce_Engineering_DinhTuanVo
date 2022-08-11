using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
    class Bai05
    {
        static void Main(string[] args)
        {
            Console.Write("Bac luong : ");
            double bacluong = double.Parse(Console.ReadLine());
            Console.Write("Ngay cong : ");
            double ngaycong = double.Parse(Console.ReadLine());
            Console.Write("Phu cap : ");
            double phucap = double.Parse(Console.ReadLine());
            Console.WriteLine("Tinh tien lanh");
            double tienlanh = double.Parse(Console.ReadLine());
            if (ngaycong < 25) tienlanh = bacluong * 650000 * (ngaycong - 25) * 2 + 25 + phucap;
            else tienlanh = bacluong * 650000 * (ngaycong - 25) * 2 + 25 + phucap;
            
        }

    }
}
