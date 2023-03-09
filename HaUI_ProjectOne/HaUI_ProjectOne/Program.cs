using System;
using System.Collections.Generic;
using System.Text;
 
namespace HauiProjectOne
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Please enter your fullname: ");
            string fullName = Console.ReadLine ();
            Console.WriteLine ("Your fullname is " + fullName);  
            switch(fullName) 
            {
                case "Lam":
                    Console.WriteLine("So handsome");
                    break;
                default: 
                    Console.WriteLine("Very handsome");
                    break;

            }
            //Vòng lặp While
            Console.WriteLine("Enter the value of i: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while ( i < n)
            {
                    Console.WriteLine(i);
                    i++;
            }
        }
    }
}