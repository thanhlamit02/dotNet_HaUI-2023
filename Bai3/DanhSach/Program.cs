using System;
using System.Collections.Generic;
using System.Linq;

namespace DanhSach
{
    class Program
    {
        static void insertArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

        static void outputArr(int[] arr)
        {
            Console.Write("Danh sach cac so thuc vua nhap: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void removeNum(List<int> list)
        {
            for(int numValue = list.Count; numValue >= 0; numValue--)
            {
                    list.RemoveAll(numValue => numValue < 0); //sử dụng lamda trong C#
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu cua danh sach: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            insertArr(a);
            outputArr(a);


            List<int> firstList = new List<int>();
            firstList = a.ToList();//đổi array => list

            Console.Write("Nhap so luong phan tu them: ");
            int m = Convert.ToInt32(Console.ReadLine());   
            int[] b = new int[m];
            insertArr(b);

            List<int> secondList = new List<int>();
            secondList = b.ToList();
            firstList.AddRange(secondList);
            firstList.Sort();

            Console.Write("Danh sach sau khi sap xep: ");
            foreach (int i in firstList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Danh sach sau khi xoa so am: ");
            removeNum(firstList); //Hàm xóa phần tử âm khỏi List
            foreach(int num in firstList)
            {
                Console.Write(num + " ");
            }

        }
    }
}
