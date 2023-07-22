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
        interface IComparable
        {
            int CompareTo(Cricle o);
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
        class ComperableCircl: Cricle, IComparable<ComperableCircl>
        {
            public ComperableCircl(double radius = 1.0, string color = "green", bool filled = true)
                : base(radius, color, filled)
            {
            }
            public int CompareTo(ComperableCircl o)
            {
                if(this.radius>o.radius) return 1;
                else if(this.radius<o.radius)return -1;
                return 1;
            }
        }
        static void Main(string[] args)
        {
            ComperableCircl[] C = new ComperableCircl[5];
            C[0] = new ComperableCircl(3.6);
            C[1] = new ComperableCircl();
            C[2] = new ComperableCircl(10.0);
            C[3] = new ComperableCircl(4.2);
            C[4] = new ComperableCircl(2.2);
            foreach(ComperableCircl c in C)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("//");
            Array.Sort(C);
            foreach (ComperableCircl c in C)
            {
                Console.WriteLine(c);
            }

        }
    }
}