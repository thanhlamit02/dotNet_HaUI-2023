using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_20206501227_proj51
{
    class ThisinhA
    {
        public string idNumber { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double markMath { get; set; }
        public double markPhys { get; set; }
        public double markChemis { get; set; }
        public double markBonus { get; set; }
        public double total { get; set; }
        public double markTotal()
        {
            return markMath + markPhys + markChemis + markBonus;
        }

        public ThisinhA() { }

        public ThisinhA(string idNumber, string name, string address, double markMath, double markPhys, double markChemis, double markBonus, double markTotal, double total)
        {
            this.idNumber = idNumber;
            this.name = name;
            this.address = address;
            this.markMath = markMath;
            this.markPhys = markPhys;
            this.markChemis = markChemis;
            this.markBonus = markBonus;
            this.total = total;
        }

        //Nhập
        public void input()
        {
            Console.Write("Nhap so bao danh: ");
            idNumber = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine();

            Console.Write("Nhap diem Toan: ");
            markMath = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem Ly: ");
            markPhys = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem Hoa: ");
            markChemis = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem uu tien: ");
            markBonus = Convert.ToDouble(Console.ReadLine());
        }

        //Xuất
        public void output()
        {
            Console.WriteLine("{0, -5} {1, -15} {2, 10} {3, 15} {4, 15} {5, 15} {6, 15} {7, 15}",
                 "SBD", "Ho ten", "Dia chi", "Diem Toan", "Diem Ly", "Diem Hoa", "Diem uu tien", "Tong diem");
            Console.WriteLine("{0, -5} {1, -15} {2, 10} {3, 10} {4, 15} {5, 15} {6, 15} {7, 15}", idNumber, name, address, markMath, markPhys, markChemis, markBonus, markTotal());
        }
    }
}
