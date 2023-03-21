using System;
namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            Console.Write("Nhap chuoi : ");
            str = Console.ReadLine();
            Console.WriteLine("Chuoi la "+str);

            str =   str.Replace(" ", string.Empty);
            //sử dụng vòng lặp while và for để lặp và đếm số lần xuất hiện của ký tự
            while (str.Length > 0)
            {
                Console.Write(str[0] + " : ");
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
    }
}
