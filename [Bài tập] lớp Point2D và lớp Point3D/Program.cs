using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _Bài_tập__lớp_Point2D_và_lớp_Point3D
{
    class Point2D
    {
        private float _x; private float _y;
        public Point2D(float x = 0, float y = 0)
        {
            this._x = x;
            this._y = y;
        }
        public float X
        {
            get { return _x; }
            set { this._x = value; }
        }
        public float Y
        {
            get { return _y; }
            set { this._y = value; }
        }
        public float[] XY
        {
            get { return new float[] { _x, _y }; }
            set
            {
                this._x = value[0];
                this._y = value[1];
            }
        }
        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + ")";
        }
    }
    class Point3D : Point2D
    {
        private float _z;
        public Point3D(float x = 0, float y = 0, float z = 0)
            : base(x, y)
        {
            this._z = z;
        }
        public float Z
        {
            get { return _z; }
            set { this._z = value; }
        }
        public float[] XYZ
        {
            get { return new float[] { this.X, this.Y, this.Z }; }
            set
            {
                this.X = value[0];
                this.Y = value[1];
                this.Z = value[2];
            }
        }
        public override string ToString()
        {
            return "("+this.X+","+this.Y+","+this.Z+")";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D a = new Point3D(1, 3, 4);
            a.XY = new float[] { 3, 3 };
            Console.WriteLine(a);
        }
    }
}
