using System;

namespace TachDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Mang vua nhap:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("");

            int[] b = new int[255];
            int[] c = new int[255];
            int j = 0, k = 0;

            for(int i = 0; i < n; i++)
            {
                if(a[i] % 2 == 0)
                {
                    b[j] = a[i];
                    j++;
                }
                else
                {
                    c[k] = a[i];
                    k++;
                }
            }

            Console.Write("Day so chan: ");
            for(int i = 0; i < j; i++)
            {
                Console.Write("{0} ", b[i]);
            }
            Console.WriteLine("");
            Console.Write("Day so le: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", c[i]);
            }
            Console.WriteLine("");
        }
    }
}
