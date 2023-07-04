using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_mass_index_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height, weight;
            Console.WriteLine("Please enter a height");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            weight = float.Parse(Console.ReadLine());

            double BMI = weight / Math.Round(height,2);

            if (BMI < 18.5)
                Console.WriteLine("Underweight");
            else if (BMI < 25)
                Console.WriteLine("Normal");
            else if (BMI < 30)
                Console.WriteLine("Overweight");
            else Console.WriteLine("Obese");
        }
    }
}
