using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double longRec, highRec, perimeterRec, stretchRec;
            do
            {
                Console.Write("Nhap chieu dai hinh chu nhat: ");
                longRec = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap chieu rong hinh chu nhat: ");
                highRec = Convert.ToDouble(Console.ReadLine()); 
            }
            while (longRec <= 0 && highRec <= 0);
            perimeterRec = 2 * (highRec + longRec); //chu vi hcn
            stretchRec = highRec * longRec; //dien tich hcn
            Console.WriteLine("Chu vi hinh chu nhat: " + perimeterRec);
            Console.WriteLine("Dien tich hinh chu nhat: " + stretchRec);
        }
    }
}