// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace PhuongThuc
{
    class Program
    {
        public static Boolean isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(String[] args)
        {
            int numIn;
            do
            {
                Console.Write("Nhap n: ");
                numIn = Convert.ToInt32(Console.ReadLine());
            }
            while (numIn < 0);

            int[] arrInt = new int[numIn];
            for (int i = 0; i < numIn; i++)
            {
                Console.Write("array[{0}] = ", i);
                arrInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            ArrayList arrPrime = new ArrayList();
            Console.Write(" Day nguyen to : ");
            for (int i = 0; i < numIn; i++)
            {
                if (isPrime(arrInt[i]))
                {
                    arrPrime.Add(arrInt[i]);
                }
            }
            foreach (int numE in arrPrime)
            {
                Console.Write("{0} ", numE);
            }
            Console.WriteLine();
        }
    }
}