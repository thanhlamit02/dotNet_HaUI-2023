using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 3 so nguyen a, b, c!");
            double a, b, c;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Xin loi dieu kien nhap khong thoa man!");
                Console.Write("Moi ban nhap lai: ");
                Console.Write("a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                c = Convert.ToDouble(Console.ReadLine());

                
                if (a < b + c && b < a + c && c < a + b)
                {
                    double halfP = (a + b + c) / 2;
                    double dt = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
                    double cv = a + b + c;
                    Console.WriteLine("Chu vi = {0}", cv);
                    Console.WriteLine("Dien tich = {0}", dt);
                }
            }
            while (a < 0 || b < 0 || c < 0);
        }
    }
}
