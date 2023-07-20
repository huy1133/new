using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hinhchunhat
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double height, width;
            Console.Write("Enter Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width,height);
            rectangle.Display();
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
        }
    }
}
