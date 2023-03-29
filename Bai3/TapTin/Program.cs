using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace TapTin
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E:\\Documents\\Giao trinh hoc online\\3rd year\\dotNet\\Project\\Bai3.txt", FileMode.Open); //Mở file
            StreamReader rd = new StreamReader(fs);

            String giaTri = rd.ReadToEnd();
            rd.Close();
            giaTri = giaTri.Trim();
            char[] vs = giaTri.ToCharArray();
            int c = 0;
            for(int i = 0; i < vs.Length; i++)
            {
                if(((i > 0) && vs[i] != ' ') && (vs[i - 1] == ' ') || ((vs[0] != ' ') && (i == 0))) {
                c++;
                }
            }

            giaTri = giaTri.ToUpper();
            FileStream cr = new FileStream("E:\\Documents\\Giao trinh hoc online\\3rd year\\dotNet\\Project\\input.txt", FileMode.Create);
            StreamReader sw = new StreamReader(cr);

            sw.WriteLine(giaTri);
            sw.Write(c);
            sw.Flush();
            cr.Close();
        }
    }
}