using System;

namespace Bai2
{
    class Program
    {
        public static int GiaiThua(int n)
        { 
            if(n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * GiaiThua(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int numIn;
            do
            {
                Console.Write("Nhap so nguyen duong n: ");
                numIn = Convert.ToInt32(Console.ReadLine());
            }
            while (numIn < 0);
            Console.WriteLine("Giai thua cua {0} la {1}", numIn, GiaiThua(numIn));
        }
    }
}