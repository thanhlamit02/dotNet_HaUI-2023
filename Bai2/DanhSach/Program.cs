using System;
using System.Collections;

namespace Bai2
{
    class Program
    {
        public static Boolean isPrime(int n)
        {
            if(n < 2)
            {
                return false;
            }
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int numIn;
            do
            {
                Console.Write("Nhap vao so nguyen n: ");
                numIn = Convert.ToInt32(Console.ReadLine());
            }
            while (numIn < 0);

            //Khai báo mảng n số nguyên
            int[] arrInt = new int[numIn];
            for(int i = 0; i < numIn; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arrInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            ArrayList arrEven = new ArrayList();
            ArrayList arrOdd = new ArrayList();
            ArrayList arrPrime = new ArrayList();

            Console.Write("Day so chan: ");
            for (int i = 0; i < numIn; i++)
            {
                if (arrInt[i] % 2 == 0)
                {
                    arrEven.Add(arrInt[i]);
                }
            }
            foreach (int numE in arrEven)
            {
                Console.Write("{0} ", numE);
            }
            Console.WriteLine();

            Console.Write("Day so le: ");
            for (int i = 0; i < numIn; i++)
            {
                if (arrInt[i] % 2 != 0)
                {
                    arrOdd.Add(arrInt[i]);
                }
            }
            foreach (int numE in arrOdd)
            {
                Console.Write("{0} ", numE);
            }
            Console.WriteLine();

            Console.Write("Day so nguyen to: ");
            for (int i = 0; i < numIn; i++)
            {
                if (isPrime(arrInt[i]))
                {
                    arrPrime.Add(arrInt[i]);
                }
            }
            foreach(int numP in arrPrime)
            {
                Console.Write("{0} ", numP);
            }
            Console.WriteLine();
        }
    }
}