using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[10];
            Console.Write("Nhap so can doi: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("So sau khi chuyen= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
            Console.Write("Nhap vao so nhi phan can chuyen doi: ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            int base1 = 1;
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"So thap phan sau khi chuyen doi: {decimalValue} ");
            Console.ReadKey();
        }
    }
}