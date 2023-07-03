using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquationResolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");

            Console.Write("a: ");
            double a = float.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double x = -b / a;
                Console.Write("The solution is: {0}!", x);
            }
            else
            {
                if(b != 0)
                {
                    Console.Write("Nod solution!");
                }
                else
                {
                    Console.Write("The solution is all x!");
                }
            }
        }
    }
}
