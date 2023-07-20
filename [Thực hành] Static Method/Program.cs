using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Thực_hành__Static_Method
{
    class student
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";

        public student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public static void Change()
        {
            college = "CODEGYM";
        }

        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(111,"huy");
            student.Change();
            student s2 = new student(222, "nhat");
            s1.Display();
            s2.Display();
        }
    }
}
