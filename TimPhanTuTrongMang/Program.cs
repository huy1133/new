using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimPhanTuTrongMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter Student Name: ");
            string inputname = Console.ReadLine();
            bool check = false;
            foreach (string student in students)
            {
                if (student.Contains(inputname))
                {
                    Console.WriteLine("Position of the students in the list " + inputname + " is: " + student);
                    check = true;
                    break;
                }
            }
            if(!check)
                Console.WriteLine("Not found" + inputname + " in the list.");
        }
    }
}
