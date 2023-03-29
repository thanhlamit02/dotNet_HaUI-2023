using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_2020601227
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Menu Options===");
            Console.WriteLine("1.Person \t 2.Circle \t 3.Student");
            Console.Write("Moi ban chon: ");
            int keyValue = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (keyValue)
                {
                    case 1:
                        Person p = new Person();
                        p.Input();
                        p.Output();
                        p.checkAge();
                        break;
                    case 2:
                        Circle cr = new Circle();
                        cr.output();
                        break;
                    case 3:
                        Student s = new Student();
                        s.input();
                        s.output();
                        break;
                    default:
                        Console.WriteLine("Moi ban chon lai.");
                        break;
                }
            }
            while (keyValue <= 0);
        }   
    }
}