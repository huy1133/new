using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Thực_hành__Hệ_các_đối_tượng_hình_học
{
    internal class Program
    {
        class Shape
        {
            private string Color;
            private bool Filled;

            public Shape(string color = "green", bool filled = true)
            {
                this.Color = color;
                this.Filled = filled;
            }
            public string color
            {
                get { return this.Color; }
                set { this.Color = value; }
            }
            public bool filled
            {
                set { this.Filled = value; }
                get { return this.Filled; }
            }
            public override string ToString()
            {

                return "Shape with color of " + this.Color + " "
                        + (this.Filled ? "filled" : "not filled");

            }



        }
        class Cricle : Shape
        {
            private double Radius;
            public Cricle(double radius = 1.0, string color = "green", bool filled = true)
                : base(color, filled)
            {
                this.Radius = radius;
            }
            public double radius
            {
                get { return (double)this.Radius; }

                set { this.Radius = value; }
            }
            public double GetArea()
            {
                return Math.PI * Math.Pow(this.Radius, 2);
            }
            public double GetPerimeter()
            {
                return 2 * Math.PI * this.Radius;
            }
            public override string ToString()
            {
                return "A Circle with radius = " + this.Radius
                    + ", which is a subclass of " + base.ToString();

            }
        }
        class Rectangle : Shape
        {
            private double Width;
            private double Height;

            public Rectangle(double width = 1.0, double height = 1.0, string color = "green", bool falled = true)
                : base(color, falled)
            {
                Width = width;
                Height = height;
            }
            public double width
            {
                get { return (double)this.Width; }
                set { this.Width = value; }
            }
            public double height
            {
                get { return (double)this.Height; }
                set { this.Height = value; }
            }
            public double GetArea()
            {
                return (double)this.Width * this.Height;
            }
            public double GetPerimeter()
            {
                return 2 * (this.Width + this.Height);
            }
            public override string ToString()
            {
                return "A Rectangle with width = " + this.Width + " height = " + this.Height +
                    ", which is a subclass of " +
                    base.ToString();
            }

        }
        class Square : Rectangle
        {
            public Square(double size = 1.0, string color = "green", bool falled = true)
                : base(size, size, color, falled)
            {

            }
            public double Size
            {
                get { return width; }
                set
                {
                    width = value;
                    height = value;
                }
            }
            public override string ToString()
            {
                return "A Square with side = " + width +
                    ", which is a subclass of " +
                    base.ToString();
            }
        }
        static void Main(string[] args)
        {

            Square square = new Square();

            Console.WriteLine(square);

            square = new Square(2.3);

            Console.WriteLine(square);

            square = new Square(5.8,"yellow", true);

            Console.WriteLine(square);
        }
    }
}
