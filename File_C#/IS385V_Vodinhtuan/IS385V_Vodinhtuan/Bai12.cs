using System;
using System.Collections.Generic;
using System.Text;

namespace IS385V_Vodinhtuan
{
    class Bai12
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int year;
            bool isLeap = false;

            Console.Write(" Nhap vao nam can kiem tra: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)//chia hết cho 4 là năm nhuận
            {
                if (year % 100 == 0)
                //nếu vừa chia hết cho 4 mà vừa chia hết cho 100 thì không phải năm nhuận
                {
                    if (year % 400 == 0)//chia hết cho 400 là năm nhuận
                        isLeap = true;
                    else
                        isLeap = false;//không chia hết cho 400 thì không phải năm nhuận
                }
                else//chia hết cho 4 nhưng không chia hết cho 100 là năm nhuận
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
