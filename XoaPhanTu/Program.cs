using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            Create(arr);
            xuarMang(arr);
            Console.WriteLine("Nhap x ban muon xoa: ");
            int x = int.Parse(Console.ReadLine());
            if (findX(arr, x) == -1)
                Console.WriteLine("Khong Tim Thay x");
            else
                Console.WriteLine("So {0} O Vi Tri {1}", arr[findX(arr,x)], findX(arr,x));
            deleteX(arr, findX(arr, x));
            xuarMang(arr);
        }
        public static void xuarMang(int[] arr)
        {
            foreach(int  x in arr)
            {
                Console.Write  (x+" ");
            }
            Console.WriteLine();
        }
        public static void deleteX(int[] arr, int x)
        {
            int i;
            for(i = x; i<arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            arr[i] = 0;
        }
        public static void Create(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }
            
        }
        public static int findX(int[] arr, int x)
        {
            int index = 0;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i;
                    found = true;
                }
            }
            if (!found) return -1;
            return index;
        }
    }
}
