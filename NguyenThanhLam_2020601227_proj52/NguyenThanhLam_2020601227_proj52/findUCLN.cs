using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_2020601227_proj52
{
    class findUCLN
    {
        public int firstNum { get; set; }
        public int secondNum { get; set; }

        public findUCLN() { }

        public findUCLN(int firstNum, int secondNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
        }

        public int ucln(int firstNum, int secondNum)
        {
            if(secondNum == 0) return firstNum;
            return ucln(secondNum, firstNum % secondNum);
        }
    }
}
