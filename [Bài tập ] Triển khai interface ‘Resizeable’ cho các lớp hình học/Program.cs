using System;

namespace Shape
{
  class Program
  {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.4);
            Console.WriteLine(circle);
            circle.Resize(50);
            Console.WriteLine(circle);
            Square square = new Square(4);
            Console.WriteLine(square);
            square.Resize(50);
            Console.WriteLine(square);
        }
  }
}
