using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_2020601227
{
    class Student
    {
        public string id { get; set; }  
        public string name { get; set; }    
        public double mark { get; set; }
        public double scholarship { get; set; }

        public Student(string id)
        {
            this.id = id;
        }

        public Student(string id, string name, double mark) 
        { 
            this.id = id;
            this.name = name;
            this.mark = mark;
        }
        public void input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap diem: ");
            mark = Convert.ToDouble(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("{0, 10} {1, 15} {2, 10}", "ID", "Name", "Mark");
            Console.WriteLine("{0, 10} {1, 15} {2, 10}", id, name, mark);
            if (mark > 8)
            {
                scholarship = 500;
                Console.WriteLine("Hoc bong nhan duoc la: {0}", scholarship);
            }
            else if (mark >= 7 && mark <= 8)
            {
                scholarship = 300;
                Console.WriteLine("Hoc bong nhan duoc la: {0}", scholarship);
            }
            else
            {
                Console.WriteLine("Khong nhan duoc hoc bong.");
            }
        }
    }
}
