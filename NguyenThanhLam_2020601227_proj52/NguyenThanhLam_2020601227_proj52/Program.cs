using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_2020601227_proj52
{
    class Program
    {
        static void Main(string[] args) 
        {
            while (true)
            {
                Console.WriteLine("***************************MENU****************************");
                Console.WriteLine("**  1. Quan ly nhan vien                                 **");
                Console.WriteLine("**  2. Giai phuong trinh bac 2                           **");
                Console.WriteLine("**  3. Tim USC lon nhat                                  **");
                Console.WriteLine("**  4. Ket thuc chuong trinh                             **");
                Console.WriteLine("***********************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        QLNV qlnv = new QLNV();
                        qlnv.input();
                        qlnv.output();
                        break;
                    case 2:
                        GiaiPhuongTrinhBac2 ptb2 = new GiaiPhuongTrinhBac2();
                        ptb2.inputValue();
                        ptb2.outputValue();
                        break;
                    case 3:
                        findUCLN findValue = new findUCLN();
                        Console.Write("Nhap so thu nhat: ");
                        findValue.firstNum = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nhap so thu hai: ");
                        findValue.secondNum = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("ULCN cua 2 so {0} va {1} la {2}", findValue.firstNum, findValue.secondNum, findValue.ucln(findValue.firstNum, findValue.secondNum));
                        break;
                    case 4:
                        Console.WriteLine("Ban da chon thoat chuong trinh.");
                        return;
                    default:
                        Console.WriteLine("Moi chon lai!");
                        break;
                }
            }
        }
    }
}