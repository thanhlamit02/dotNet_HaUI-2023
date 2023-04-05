using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_2020601227_proj52
{
    class GiaiPhuongTrinhBac2
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public GiaiPhuongTrinhBac2() { }
        public GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void inputValue()
        {
            Console.WriteLine("===GIAI PHUONG TRINH BAC 2: ax^2 + bx + c = 0");
            Console.Write("Nhap a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap c: ");
            c = Convert.ToDouble(Console.ReadLine());
        }

        public void outputValue()
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;
            if(a == 0)
            {
                if(b == 0)
                {
                    if(c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem x = " + (-c / b));
                }
            }

            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem.");
                }
                //nếu delta = 0 thì phương trình có hai nghiệm kép
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("\n Phuong trinh co nghiem kep x1 = x2 = {0}", x1);
                }
                //nếu delta > 0 thì phuong trình có hai nghiệm phân biệt
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("\n Phuong trinh co hai nghiem phan biet:\n X1 = {0}\n X2 = {1}", x1, x2);
                }
            }
        }
    }
}
