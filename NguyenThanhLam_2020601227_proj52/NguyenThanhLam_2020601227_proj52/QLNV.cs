using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NguyenThanhLam_2020601227_proj52
{
    class QLNV
    {
        private List<Employee> listEm = new List<Employee>();

        //1. Nhập thông tin thí sinh
        public void input()
        {
            do
            {
                Employee em = new Employee();
                em.input();

                listEm.Add(em);

                Console.Write("Ban co muon them nhan vien hay khong? (Co hoac khong): ");
                string answer = Console.ReadLine();

                if (answer.Equals("Khong", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
            while (true);
        }

        //2. Xuất thông tin thí sinh
        public void output()
        {
            foreach (var item in listEm)
            {
                item.output();
            }
        }
    }
}
