using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS385V_Vodinhtuan
{
    class Bai09
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            float a, b, c;
            Console.Write("Nhập a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhập b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhập c = ");
            c = float.Parse(Console.ReadLine());
            giaiPTBac2(a, b, c);

            Console.WriteLine();
            Console.ReadKey();
        }

        static void giaiPTBac2(float a, float b, float c)
        {
            // kiem tra cac he so
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }
                else
                {
                    Console.WriteLine("Phương trình có một nghiệm: x = {0}", (-c / b));
                }
                return;
            }

            float delta = b * b - 4 * a * c;
            float x1;
            float x2;

            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Phương trình có 2 nghiệm là: x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm!");
            }
        }
    }
}
