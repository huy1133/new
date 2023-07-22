using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Thực_hành__triển_khai_interface__IComparer__để_so_sánh_cách_lớp_hình_học
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
        interface IComparer
        {
            int Compare(Cricle o1, Cricle o2);
        }
        class CircleComparator : IComparer<Cricle>
        {
            public int Compare(Cricle o1, Cricle o2)
            {
                if (o1.radius > o2.radius) return 1;
                else if(o1.radius < o2.radius)return -1;
                else return 0;
            }

            public int CompareTo(Cricle other)
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            Cricle[] C = new Cricle[] {new Cricle(),
            new Cricle(3.8),
            new Cricle(2),
            new Cricle(10.2),
            };
            foreach(Cricle o in C)
            {
                Console.WriteLine(o);
            }
            CircleComparator circleComparator = new CircleComparator();
            Array.Sort(C,circleComparator);
            Console.WriteLine("??");
            foreach (Cricle o in C)
            {
                Console.WriteLine(o);
            }
        }
    }
}
