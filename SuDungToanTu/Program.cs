using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungToanTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float width, hight;
            Console.Write("Enter Width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter Hight: ");
            hight = float.Parse(Console.ReadLine());

            Console.WriteLine("Area is: " + width * hight);
        }
    }
}
