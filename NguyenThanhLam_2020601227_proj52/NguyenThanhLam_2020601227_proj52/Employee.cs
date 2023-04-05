using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_2020601227_proj52
{

    class Employee
    {
        public string id {get;set;}
        public string name { get;set;}
        public int age { get;set;}
        public int workingdays { get;set;}

        const int Price = 50;

        public double salary() { return workingdays * Price; }

        public Employee() { }

        public Employee(string id, string name, int age, int workingdays)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.workingdays = workingdays;
        }

        public void input()
        {
            Console.Write("Nhap ma nhan vien: ");
            id = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so ngay cong: ");
            workingdays = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("{0, -5} {1, -15} {2, 10} {3, 15} {4, 15}",
                 "MaNV", "Ho ten", "Tuoi", "So ngay cong", "Luong");
            Console.WriteLine("{0, -5} {1, -15} {2, 10} {3, 10} {4, 20}", id, name, age, workingdays, salary());
        }
    }
}
