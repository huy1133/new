using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Bài_tập__Lớp_Circle_và_lớp_Cylinder
{
    class Circle
    {
        private double _radius;
        private string _color;
        public Circle(double radius=1.0, string color = "green")
        {
            this._radius = radius;
            this._color = color;
        }
        public double Radius
        {
            get { return this._radius; }
            set { this._radius = value; }
        }
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(this._radius, 2);
        }
        public override string ToString()
        {
            return "A Circle with color of " + this.Color
                + " and radious = "+this.Radius;
        }
    }
    class Cylinder : Circle
    {
        private double _height;
        public Cylinder(double height=1.0, double radius = 1.0, string color = "green")
            :base(radius,color)
        {
            this._height = height;
        }
        public double Height
        {
            get { return this._height; }
            set { this._height = value; }
        }
        public double Volume()
        {
            return this._height*this.GetArea();
        }
        public override string ToString()
        {
            return "A Cylinder with height = "+this.Height+
                ", which is a subclass of "+
                base.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder s1 = new Cylinder(5,2);
            Console.WriteLine(s1);
        }
    }
}
