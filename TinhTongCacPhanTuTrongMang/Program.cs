using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongCacPhanTuTrongMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            int total = 0;
            foreach(int i in numbers)
            {
                total += i;
            }
            Console.WriteLine(total);
        }
    }
}
