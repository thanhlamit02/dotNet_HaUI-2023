using System;

namespace Bai2
{
    class Program
    {
        public static int Fibonacci (int n)
        { 
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
    }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so nguyen duong n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 0);

            Console.WriteLine("{0} so Fibonacci dau tien:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
        }
    }
}