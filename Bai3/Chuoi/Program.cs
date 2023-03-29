using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            String str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            int doDai = str.Length;

            if(doDai < 2)
            {
                Console.WriteLine("Chuoi khong doi xung");
            }
            else
            {
                for(int i = 0; i < doDai / 2; i++)
                {
                    if(arr[i] != arr[doDai - 1 - i])
                    {
                        Console.WriteLine("Day khong la chuoi doi xung");
                        return;
                    }
                }
                Console.WriteLine("Day la chuoi doi xung");

            }
        }
    }
}
