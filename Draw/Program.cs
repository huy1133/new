using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose=1;
            while(choose!=0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choose = int.Parse(Console.ReadLine());
                Draw(choose);
            }
        }
        static void Draw(int n)
        {
            switch (n)
            {
                case 1:
                    for(int i=0;i<6; i++)
                    {
                        for (int j = i; j < 6; j++){
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
