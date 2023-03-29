using System;

namespace CuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In ra bang cuu chuong.");
            int firstNum, multiNum;
            firstNum = 2;
            do
            {
                multiNum = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}", firstNum, multiNum, firstNum * multiNum);
                    multiNum++;
                }
                while (multiNum <= 10);
                Console.WriteLine("");
                firstNum++;
            }
            while (firstNum <= 9);
        }
    }
}
