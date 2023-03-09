using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1
            Console.Write("Nhap so nguyen n: ");
            int numN = Convert.ToInt32(Console.ReadLine());

            // n là số chẵn hay số lẻ?
            string result = (numN % 2 == 0) ? "n la so chan" : "n la so le";
            Console.WriteLine(result);

            //n là số âm hay số không âm?
            string res = (numN < 0) ? "n la so am" : "n la so khong am";
            Console.WriteLine(res);


            //Bài 2
            Console.Write("Nhap chieu dai: ");
            double recLong = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double recHigh = Convert.ToDouble(Console.ReadLine());

            double recP = (recLong + recHigh) * 2; //Chu vi hình chữ nhật
            double recS = recLong * recHigh; //Diện tích hình chữ nhật

            Console.Write("Chu vi hinh chu nhat: " + recP + "\n");
            Console.Write("Dien tich hinh chu nhat: " + recS + "\n");

            //Bài 3
            //Giải phương trình bậc nhất: ax + b = 0

            //Khai báo biến a, b
            Console.WriteLine("Giai phuong trinh bac nhat ax + b = 0");
            Console.Write("Nhap gia tri cua a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap gia tri cua b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //Xét các trường hợp khi giải phương trình bậc nhất
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            
            else
            {
                double x = b / a;
                Console.Write("x = " + x + "\n");
            }


            //Giải phương trình bậc hai: ax2 + bx + c = 0
            //Khai báo biến a, b, c
            Console.Write("Nhap gia tri cua bien a: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap gia tri cua bien b: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap gia tri cua bien c: ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            double delta = b1 * b1 - 4 * a1 * c1;
            double x1, x2;

            //Kiểm tra các điều kiện
            if (a1 == 0)
            {
                if (b1 == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co mot nghiem: x = {0}", (-c1 / b1));
                }
                return;
            }

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            } 
            
            else if (delta == 0)
            {
                x1 = (-b1 / (2 * a1));
                Console.Write("Phuong trinh co nghiem kep x1 = x2 = " + x1);
            }

            else
            {
                x1 = (-b1 + Math.Sqrt(delta)) / (2 * a1);
                x2 = (-b1 - Math.Sqrt(delta)) / (2 * a1);
                Console.Write("Phuong trinh co nghiem x1 = " + x1 + "\n");
                Console.Write("Phuong trinh co nghiem x2 = " + x2 + "\n");

            }

            //Bài 4
            //Tinh tien thuc linh
            Console.Write("Nhap bac luong: ");
            int levelSalary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ngay cong: ");
            int dayWorking = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap phu cap: ");
            double spSalary = Convert.ToDouble(Console.ReadLine());

            int realDayWorking;
            double salary;

            if (dayWorking < 25)
            {
                Console.WriteLine("Ngay cong nho hon 25");
                realDayWorking = dayWorking;
                salary = levelSalary * 1490000 * realDayWorking + spSalary;
                Console.Write("Tien luong thuc linh: " + salary + "\n");
            }

            else
            {
                Console.WriteLine("Ngay cong lon hon 25");
                realDayWorking = 25 + (dayWorking - 25) * 2;
                salary = levelSalary * 1490000 * realDayWorking + spSalary;
                Console.Write("Tien luong thuc linh: " + salary + "\n");
            }

            //Bài 5
            Console.Write("Nhap so bat ki: ");
            int numIn = Convert.ToInt32(Console.ReadLine());

            switch (numIn)
            {
                case 1:
                    Console.WriteLine("Chu nhat");
                    break;
                case 2:
                    Console.WriteLine("Thu hai");
                    break;
                case 3:
                    Console.WriteLine("Thu ba");
                    break;
                case 4:
                    Console.WriteLine("Thu tu");
                    break;
                case 5:
                    Console.WriteLine("Thu nam");
                    break;
                case 6:
                    Console.WriteLine("Thu sau");
                    break;
                case 7:
                    Console.WriteLine("Thu bay");
                    break;
                default:
                    Console.WriteLine("So ban vua chon la: " + numIn);
                    break;
            }

            //Bài 6
            int n;
            do
            {
                Console.Write("Nhap so nguyen n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            //Bài 7
            int numPrime;
            do
            {
                Console.Write("Nhap so nguyen n > 0: ");
                numPrime = Convert.ToInt32(Console.ReadLine());
            }
            while (numPrime < 0);

            if (numPrime < 2)
            {
                Console.WriteLine("{0} khong la so nguyen to", numPrime);
            }

            bool isPrime = true;
            for (int i = 2; i < Math.Sqrt(numPrime); i++)
            {
                if (numPrime % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime) Console.WriteLine("{0} la so nguyen to", numPrime);


            else Console.WriteLine("{0} khong la so nguyen to", numPrime);

            //Bài 8
            int numberIn;
            do
            {
                Console.Write("Nhap so nguyen n: ");
                numberIn = Convert.ToInt32(Console.ReadLine());
            }
            while (numberIn < 0);

            for (int i = 1; i < numberIn; i++)
            {
                if (i % 5 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}