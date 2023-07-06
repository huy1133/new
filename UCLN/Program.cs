using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(UCLN(a,b));
        }
        static int UCLN(int n, int m)
        {
            if (n == m) return n;
            return n > m ? UCLN(n - m, m) : UCLN(n, m - n);
        }
    }
}
