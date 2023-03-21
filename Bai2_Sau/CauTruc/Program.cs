// See https://aka.ms/new-console-template for more information
using System;
namespace CauTruc
{
    class Program
    {
        struct HocSinh
        {
            public string name;
            public int age;
            public string sex;
        }
        static void NhapThongTin(HocSinh[] hs, int n) {
           
             for(int i=0; i<n; i++)
            {
                Console.WriteLine("Nhap Thong tin hoc sinh {0} la", i+1);
                Console.Write("Nhap Ten: ");
                hs[i].name = Console.ReadLine();
                Console.Write("Nhap Tuoi: ");
                hs[i].age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Gioi Tinh: ");
                hs[i].sex = Console.ReadLine();

            }

            
        }
        static void InThongTin(HocSinh[] hs, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin hoc sinh {0} la", i+1);
                Console.WriteLine("Ten: " + hs[i].name);
                Console.WriteLine("Tuoi: " + hs[i].age);
                Console.WriteLine("Gioi Tinh: " + hs[i].sex);
            }
        }
        static void TongTuoi(HocSinh[] hs, int n)
        {
            int tuoi = 0;
            for (int i = 0; i < n; i++)
            {
                tuoi += hs[i].age;
            }
            Console.WriteLine("Tong so tuoi la: " + tuoi);
        }
        static void Main(string[] args)
        {
            int m;
            do
            {
                Console.Write("Nhap so hoc sinh: ");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 0);
            HocSinh[] hs = new HocSinh[m];
            NhapThongTin(hs, m);
            InThongTin(hs, m);
            TongTuoi(hs, m);
            Console.ReadKey();

        }
    }
}
