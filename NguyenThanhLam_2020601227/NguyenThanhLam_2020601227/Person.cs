using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NguyenThanhLam_2020601227
{
    class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public void Input()
        {
            Console.Write("Nhap ID: ");
            id = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();

            do
            {
                Console.Write("Nhap tuoi: ");
                age = Convert.ToInt32(Console.ReadLine());
            } 
            while (age < 0);

            Console.Write("Nhap Email: ");
            email = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine();
        }

        public void Output()           
        {
            Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, 10} {4, 10}",
                  "ID", "Name", "Age", "Email", "Address");
            Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, 10} {4, 10}", id, name, age, email, address);
        }

        public void checkAge()
        {  
            if (age >= 18)
            {
                Console.WriteLine("Ban du tuoi bau cu");
            }
            else
            {
                Console.WriteLine("Ban con nho");
            }
        }
    }
}

