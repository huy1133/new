using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_Abstract
{
    abstract class Shap
    {
        public const double pi = Math.PI;
        public double _x, _y;
        public Shap(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
        public abstract double circle_area();
    }
    class Circle: Shap
    {
        public Circle(double radius)
            :base(radius,0)
        {
            
        }
        public override double circle_area()
        {
            return pi*_x*_x;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
