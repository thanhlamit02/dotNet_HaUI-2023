using System;
namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInt;
            do
            {
                Console.Write("Nhap so phan tu mang: ");
                numInt = Convert.ToInt32(Console.ReadLine());
            }
            while (numInt < 0);

            int[] array = new int[numInt];
            for(int i=0; i<numInt; i++)
            {
                Console.Write("[{0}] =", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<numInt; i++)
            {
                Console.Write("\t" + array[i]);
            }
            Console.WriteLine();    
            int Max = array.Max();
            int Min = array.Min();
            int sum = 0;
            Console.WriteLine("So lon nhat trong mang la :" + Max + "\n");
            Console.WriteLine("So nho nhat trong mang la: " + Min + "\n");
            for (int i = 0; i < numInt; i++)
            {
                sum += array[i];
            }

            Console.Write("Tong cac phan tu trong mang la: {0}\n\n", sum);

            Console.ReadKey();
        }
    }
}
