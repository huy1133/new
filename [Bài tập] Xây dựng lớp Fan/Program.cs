using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Bài_tập__Xây_dựng_lớp_Fan
{
    class Fan
    {
        private const int Slow = 1,
                          Medium =2, 
                          Fast =3;
        private int _speed;
        private bool _is;
        private double _radius;
        private string _color;
        public Fan(int speed=1, double radius=5, string color="blue", bool @is = false)
        {
            this._speed = speed;
            this._is = @is;
            this._radius = radius;
            this._color = color;
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public bool Is
        {
            get { return _is; }
            set { _is = value; }
        }
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public override string ToString()
        {
            string @on = "Speed = " + Speed + ", color = " + Color +
                ", radius = " + Radius + ", fan is on";
            string @off = "Color = " + Color +
                ", radius = " + Radius + ", fan is off";
            return Is ? @on : @off;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(3,10,"yellow",true);
            Fan fan2 = new Fan(2, 5, "blue", false);
            Console.WriteLine(fan1);
            Console.WriteLine(fan2);
        }
    }
}
