using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSoNguyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] number1 = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", " Eight", "Nine" };
            string[] number2 = { "Ten", "Eleven", "Twelve", "Thirtenn", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
            string[] number3 = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string Hundred = "Hundred";

            Console.Write("Enter Number ");
            int n = int.Parse(Console.ReadLine());

            if (n < 10)
            {
                Console.WriteLine(number1[n - 1]);
            }
            else if(n < 20)
            {
                Console.WriteLine(number2[n - 10]);
            }
            else 
            {
                string num = "";
                int temp, a, b, c;
                temp = n;
                a = temp % 10;
                temp/= 10;
                b = temp % 10;
                temp /= 10;
                c = temp % 10;
                if (c > 0)
                    num += number1[c - 1] +" "+ Hundred+" ";
                if (b > 0) {
                    num += number3[b - 2];
                    if (a > 0)
                        num += "-";
                 }
                if (a > 0)
                    num += number1[a - 1];
                Console.WriteLine(num);
            }
            
        }
    }
}
