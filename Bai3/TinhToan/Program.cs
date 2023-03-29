using System;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 2 so thuc.");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chon + - * / : ");
            String str = Console.ReadLine();
            switch (str)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;
                case "/":
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Hay chon lai.");
                    break;
            }
            
        }
    }
}
