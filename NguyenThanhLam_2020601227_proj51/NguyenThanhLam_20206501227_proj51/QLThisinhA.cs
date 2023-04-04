using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NguyenThanhLam_20206501227_proj51
{
    public class QLThisinhA
    {
        private List<ThisinhA> listTS = new List<ThisinhA>();

        //1. Nhập thông tin thí sinh
        public void input()
        {
            do
            {
                ThisinhA ts = new ThisinhA();
                ts.input();

                listTS.Add(ts);

                Console.Write("Ban co muon them thi sinh hay khong? (Co hoac khong): ");
                string answer = Console.ReadLine();

                if(answer.Equals("Khong", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
            while (true);
        }
     
        //2. Xuất thông tin thí sinh
        public void output()
        {
            foreach(var item in  listTS)
            {
                item.output();
            }
        }


        //3. Tìm theo tổng điểm
        public void markTotalSearch()
        {
            Console.Write("Nhap tong diem cua thi sinh ban muon tim: ");
            double totalMarkInput = Convert.ToDouble(Console.ReadLine());
            
            foreach (var item in listTS)
            {
                double total = item.markTotal();
                if (totalMarkInput <= total)
                {
                    Console.WriteLine("\t\tThong tin thi sinh co tong diem >= {0}:", totalMarkInput);
                    item.output();
                }
                else
                {
                    Console.WriteLine("Khong co thi sinh nao co tong diem >= {0}", totalMarkInput);
                }
            }
            
        }

        //4. Tìm theo địa chỉ
        public void addressSearch()
        {
            Console.Write("Nhap dia chi cua thi sinh ban muon tim: ");
            string addressStr = Console.ReadLine();

            foreach(var item in listTS)
            {
                if(item.address.Equals(addressStr, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\t\tThong tin thi sinh co dia chi o {0}", addressStr);
                    item.output();
                }
                else
                {
                    Console.WriteLine("Khong co thi sinh nao co dia chi o {0}", addressStr);
                }
            }
        }

        //5. Nhập SBD => Hiển thị thông tin
        public void inputIDNumber()
        {
            Console.Write("Nhap so bao danh cua thi sinh ban muon tim: ");
            string inputIDStr = Console.ReadLine();

            foreach(var item in listTS)
            {
                if(item.idNumber.Equals(inputIDStr, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\t\tThong tin thi sinh co so bao danh {0}", inputIDStr);
                    item.output();
                }

                else
                {
                    Console.WriteLine("Khong co thi sinh co so bao danh {0}", inputIDStr);
                }
            }
        }

    }
}
