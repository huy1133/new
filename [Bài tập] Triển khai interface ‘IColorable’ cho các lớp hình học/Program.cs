using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Bài_tập__Triển_khai_interface__IColorable__cho_các_lớp_hình_học
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add(new Square(3));
            list.Add(new Square(4));
            list.Add(new Circle(5));
            list.Add(new Rectangle(7,6)) ;
            foreach(object o in list)
            {
                if(o is Square square )
                {
                    Console.Write("square area: " + square.getArea()+", ");
                    if (o is IColorable colorable)
                    {
                        colorable.HowToColor();
                    }
                }
                else if (o is Circle circle)
                {
                    Console.WriteLine("circle area: " + circle.getArea());
                }
                else if (o is Rectangle rectangle)
                {
                    Console.WriteLine("rectangle area: " + rectangle.getArea());
                }
            }
        }
    }
}
