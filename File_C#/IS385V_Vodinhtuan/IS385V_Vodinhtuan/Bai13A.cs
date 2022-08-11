using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
    class Bai13A
    {
        static void Main()
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhập số tự nhiên n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int sum = default;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine("S1= 1 + 2 + ... + n = " + sum);
            }
            else
            {
                Console.WriteLine("Nhập n > 0");
            }
        }
    }
}
