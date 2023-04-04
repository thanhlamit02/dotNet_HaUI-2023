using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_20206501227_proj51
{
    class Program
    {
        static void Main(string[] args)
        {
            QLThisinhA qlts = new QLThisinhA();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("***************************MENU****************************");
                Console.WriteLine("**  1. Nhap thong tin 1 thi sinh.                        **");
                Console.WriteLine("**  2. Hien thi danh sach cac thi sinh                   **");
                Console.WriteLine("**  3. Hien thi danh sach cac thi sinh theo tong diem    **");
                Console.WriteLine("**  4. Hien thi danh sach cac thi sinh theo dia chi      **");
                Console.WriteLine("**  5. Tim kiem theo so bao danh                         **");
                Console.WriteLine("**  6. Ket thuc chuong trinh                             **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        qlts.input();
                        break;
                    case 2:
                        qlts.output();
                        break;
                    case 3:
                        qlts.markTotalSearch();
                        break;
                    case 4:
                        qlts.addressSearch();
                        break;
                    case 5:
                        qlts.inputIDNumber();
                        break;
                    case 6:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}