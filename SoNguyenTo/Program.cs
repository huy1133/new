using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            check(number);
        }
        static int check(int n)
        {
            if (n < 2)
            {
                Console.WriteLine(n + " is not a prime");
                return 0;
            }
            for(int i=2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n + " is not a prime");
                    return 0;
                }
            }
            Console.WriteLine(n + " is a prime");
            return 0;
        }
    }
}
