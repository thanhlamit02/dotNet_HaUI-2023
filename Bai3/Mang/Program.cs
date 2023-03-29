using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mang n phan tu!");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Mang vua nhap: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if(a[i] % 2 != 0)
                {
                    sum += a[i];
                    Console.WriteLine("C {0}", a[i]);
                }
            }
            Console.WriteLine("Tong cac so le: {0}", sum);
        }
    }
}
