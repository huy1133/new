using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=2; i<=10; i++)
            {
                Console.WriteLine("Bang Cuu Chung {0}:",i);
                for(int j=1; j<=10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
            }
        }
    }
}
