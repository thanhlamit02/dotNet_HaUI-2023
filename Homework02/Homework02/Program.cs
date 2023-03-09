using System;

namespace Homework02
{
    class Program
    {
        static int UCLN(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap tu: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap mau: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = UCLN(a, b);
            a = a / c;
            b = b / c;

            Console.WriteLine("Phan so sau khi rut gon: {0}/{1}", a, b);
        }
    }
}