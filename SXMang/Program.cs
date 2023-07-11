using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            InputData(arr);
            Console.Write("Mang Ban Dau: ");
            OutputData(arr);

            Console.Write("Mang Tang: ");
            SortUp(arr);
            OutputData(arr);

            Console.Write("Mang Giam: ");
            SortDown(arr);
            OutputData(arr);
        }
        static void InputData(int[] arr)
        {
            Random rnd = new Random();
            for (int i=0;i<arr.Length; i++)
            {
                arr[i] = rnd.Next(1,20);
            }
        }
        static void OutputData(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void Swap(ref int a, ref int b)
        {
            int t = a; a = b; b = t;
        }
        static void SortUp(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for(int j=i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                        Swap(ref arr[i],ref arr[j]);
                }
            }
        }
        static void SortDown(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                        Swap(ref arr[i], ref arr[j]);
                }
            }
        }
    }
}
