using System;

namespace NhapLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("nhap vao so nguyen tu 1 den 100: ");
            x = int.Parse(Console.ReadLine());
            /*while ((x <= 0) || (x > 100))
             {
                 Console.WriteLine("xin loi {0} khong nam trong khoang tu 1 den 100", x);
                 Console.Write("moi ban nhap lai: ");
                 x = int.Parse(Console.ReadLine());
             }
            */
            do
            {
                Console.WriteLine("xin loi {0} khong nam trong khoang tu 1 den 100", x);
                Console.Write("Moi ban nhap lai: ");
                x = int.Parse(Console.ReadLine());
            }
            while ((x <= 0) || (x > 100));
            Console.WriteLine("so ban vua nhap la: " + x);
        }
    }
}
