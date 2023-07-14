using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackGame2
{
    internal class Program
    {
        static private int[] head = new int[2];
        static private List<int[]> body = new List<int[]>();
        static private int[] food = new int[2];
        static private int[] newpoint = new int[2];
        static private int[] oldpoint = new int[2];
        static private int score = 0;
        static private bool game = true;
        static private int huong = 1;
        static private int speed = 150;
        static private int height = 15;
        static private int width = 15;
        static void Main(string[] args)
        {
            Console.WriteLine("SnackGame");
           
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            break;
                        case ConsoleKey.DownArrow:
                            break;
                        case ConsoleKey.LeftArrow:
                            break;
                        case ConsoleKey.RightArrow:
                            break;
                    }
                }
            }
        }
        static private void showbanner()
        {

        }
        static private void setup()
        {

        }
    }
}
