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
            int n=10;
            int[] arr = new int[n];
            Create(arr);
            Console.WriteLine("So Nho Nhat La {0} O Vi Tri {1}", arr[findmin(arr)], findmin(arr));
        }
        public static void Create(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,20);
            }
           
        }
        public static int findmin(int[] arr)
        {
            int index = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] < arr[index])
                    index = i;
            }
            return index;
        }
    }
}
