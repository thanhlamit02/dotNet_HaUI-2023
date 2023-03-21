using System;
internal class Program
{
    static void Main(string[] args)
    {
        double kqua;
        string str = " ";
        Console.Write("Nhap ten hoc sinh : ");
        str = Console.ReadLine();
        str = str.ToUpper();
        Console.Write("nhap diem hoc sinh: ");
        kqua = double.Parse(str);
        Console.Write("Ten Hoc Sinh : {0}", str);
        if (kqua < 5)
        {
            Console.WriteLine("\n Hoc sinh yeu");
        }
        else if (kqua >= 5 & kqua < 6.5)
        {
            Console.WriteLine("\n hoc sinh trung binh ");
        }
        else if (kqua >= 6.5 & kqua < 8)
        {
            Console.WriteLine("\n hoc sinh kha");
        }
        else
        {
            Console.WriteLine("\n hoc sinh gioi");
        }
    }
}