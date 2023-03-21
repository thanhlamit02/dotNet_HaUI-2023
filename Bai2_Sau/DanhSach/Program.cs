// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;
namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> ThanhPho = new List<string>() { "Ha Noi", "Quang Ninh", "Hai Phong", "Da Nang", "Thai Nguyen" };
            
          var sort = ThanhPho.OrderBy(x => x);
            foreach (var item in sort)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("list sau khi duoc xoa: ");
         ThanhPho.Remove("Ha Noi");
            foreach (var item in ThanhPho) {
                Console.WriteLine(item.ToString());
            }
            ThanhPho.AddRange(new string[] {"HCM","Nha Trang","Dong Nai","Binh Thuan","Hoa Binh"});
            Console.WriteLine("List sau khi duoc them la: ");
            foreach (var item in ThanhPho)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
