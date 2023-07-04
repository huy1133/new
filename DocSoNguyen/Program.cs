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

            string num = "";
            int temp, a;
            temp = n;
            a = temp / 100;
            temp %= 100;
            
            if (a > 0)
                num += number1[a - 1] + " " + Hundred + " ";

            if (temp < 10 && temp>0)
            {
                num += number1[temp - 1];
            }
            else if (temp < 20 && temp > 0)
            {
                num += number2[temp - 10];
            }
            else
            {
                a = temp / 10;
                temp %= 10;
                if (a > 0)
                {
                    num += number3[a - 2];
                    if (temp> 0)
                        num += "-";
                }
                if (temp > 0)
                    num += number1[temp - 1];
            }

           
            Console.WriteLine(num);

           
            
        }
    }
}
