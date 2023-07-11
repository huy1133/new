using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDoiC_F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C;
            double F;
            int choice;
            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter fahrenheit: ");
                        F = double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(F));
                        break;
                    case 2:
                        Console.Write("Enter Celsius: ");
                        C = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(C));
                        break;
                }
                
            }while (choice != 0);
        }
        static double CelsiusToFahrenheit(double C)
        {
            double F = C*(9.0/5)+32;
            return F;
        }
        static double FahrenheitToCelsius(double F)
        {
            double C = (5.0 / 9)*(F-32);
            return C;
        }
    }
}
