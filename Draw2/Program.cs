using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose=1;
            while (choose != 0)
            {
                Console.WriteLine("1.Print the rectangle: ");
                Console.WriteLine("2.Print the square triangle top-left ");
                Console.WriteLine("3.Print the square triangle top-right ");
                Console.WriteLine("4.Print the square triangle botton-left ");
                Console.WriteLine("5.Print the square triangle botton-right ");
                Console.WriteLine("6.Print isosceles triangle");
                Console.WriteLine("0.Exit");
                Console.Write("enter your choose: ");
                choose = int.Parse(Console.ReadLine());
                Draw(choose);
            }
        }
        static void Draw(int n)
        {
            switch (n)
            {
                case 1:
                    for(int i = 0; i < 3; i++)
                    {
                        for(int j = 0; j < 7; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for(int i = 0; i < 7; i++)
                    {
                        for(int j=i; j < 7; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("  ");
                        }
                        for (int j = 7; j > i; j--)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = i; j < 7; j++)
                        {
                            Console.Write("  ");
                        }
                        for (int j = 0; j <=i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 6:
                    for(int i=0; i < 7; i++)
                    {
                        for(int j=i; j < 7; j++)
                        {
                            Console.Write(" ");
                        }
                        for(int j=0; j<=i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
