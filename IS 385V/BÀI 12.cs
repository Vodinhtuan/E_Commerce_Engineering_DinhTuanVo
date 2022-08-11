using System;

namespace BÀI_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int year;
            bool isLeap = false;

            Console.Write(" Nhap vao nam can kiem tra: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                
                {
                    if (year % 400 == 0)
                        isLeap = true;
                    else
                        isLeap = false;
                }
                else
                    isLeap = true;
            }
            else
            {
                isLeap = false;
            }

            if (isLeap == true)
                Console.WriteLine("\n " + year + " là năm nhuận.");
            else
                Console.WriteLine("\n " + year + " không phải là năm nhuận.");
        }
    }
}
