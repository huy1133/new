using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GTLN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");
            } while (size > 20);
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            foreach(int j in array)
            {
                Console.WriteLine(j + "\t");
            }
            int max = 0;
            int index = -1;
            for (int j = 0; j < array.Length; j++)
            {
                if (max < array[j])
                {
                    max= array[j];
                    index = j;
                }
            }
            Console.WriteLine("The largest property value in the list is " + max + " ,at position " + index);
        }
    }
}
