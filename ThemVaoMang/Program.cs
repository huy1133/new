using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemVaoMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {0, 1, 2, 3 , 4, 5, 6, 7, 8, 9, 0, 0, 0};
            Console.Write("Nhap value: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Nhap index: ");
            int index = int.Parse(Console.ReadLine());
            if (index <= 1 && index >= arr.Length - 1)
                Console.WriteLine("khong the chen !");
            else
            {
                int temp = arr[index];
                arr[index] = value;
                for(int i = index +1; i<arr.Length-1; i++)
                {
                    int tp = temp;
                    temp = arr[i];
                    arr[i]= tp;
                   
                }
            }
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
