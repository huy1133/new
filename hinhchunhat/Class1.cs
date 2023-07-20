using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hinhchunhat
{
    internal class Rectangle
    {
        private double width, height;
        public Rectangle(double weight = 0, double height = 0)
        {
            this.width = weight;
            this.height = height;
        }
        public double GetArea()
        {
            return this.height*this.width;
        }
        public double GetPerimeter()
        {
            return (this.height+this.width)*2;
        }
        public void Display()
        {
            Console.WriteLine("{0}:{1}", this.width, this.height);
        }
    }
}
