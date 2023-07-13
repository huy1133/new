using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnackGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            choilai:
            Console.Clear();
            //ve_khung();
            Random rnd = new Random();
            int score = -1;
            int moix=0, moiy=0;
            List<int[]> snack = new List<int[]>();
            for(int i=0;i<4; i++)
            {
                snack.Add(new int[] {(5+i)*2,15});
            }
            ve_khung();
            int huong = 3;
            int newx = -1, newy = 0;
            int oldx=0, oldy=0;
            int sp=150;
            bool gameovel=false;
            bool moi = false;
            while (!gameovel)
            {
                gameovel = checkgame(snack);
                ve_ran(snack, oldx, oldy);
                if (!moi)
                {
                    TaoMoi(ref moix, ref moiy, snack);
                    score++;
                    snack.Add(new int[] {oldx,oldy });
                    moi = true;
                }
                else
                {
                    Console.SetCursorPosition(moix, moiy);
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.Write("o");
                }
                moi = checkanmoi(snack, moix, moiy);
                Thread.Sleep(sp);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        if (huong != 2)
                        {
                            //Console.WriteLine("len");
                            huong = 1;
                            newx = 0;
                            newy = -1;
                        }
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        if (huong != 1)
                        {
                            //Console.WriteLine("xuong");
                            huong = 2;
                            newx = 0;
                            newy = 1;
                        }
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        if (huong != 4)
                        {
                            //Console.WriteLine("trai");
                            huong = 3;
                            newx = -1;
                            newy = 0;
                        }
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        if (huong != 3)
                        {
                            //Console.WriteLine("phai");
                            huong = 4;
                            newx = 1;
                            newy = 0;
                        }
                    }
                }
                update_ran(newx, newy, snack,ref oldx,ref oldy);
                Console.SetCursorPosition(20, 1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("score: {0}", score);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(47, 10);
            Console.WriteLine("game over");
            Console.SetCursorPosition(47, 11);
            Console.WriteLine("1.choi lai");
            Console.SetCursorPosition(47, 12);
            Console.WriteLine("2.exit");
            Console.SetCursorPosition(47, 13);
            if (int.Parse(Console.ReadLine()) == 1)
                goto choilai;
        }
        public static bool checkanmoi(List<int[]> ran,int x, int y)
        {
            foreach (int[] i in ran)
            {
                if (i[0] == x && i[1] == y)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(' ');
                    return false;
                }
            }
            return true;
        }
        public static void TaoMoi(ref int x, ref int y, List<int[]> ran)
        {
            Random random = new Random();
            bool check = true;
            while (check)
            {
                y = random.Next(2, 20);
                do
                {
                    x = random.Next(4, 40);
                } while (x % 2 != 0);
                check = false;
                foreach(int[] i in ran)
                {
                    if (x == i[0] && y == i[1]) {
                        check = true;
                    }
                }
            }
        }
        public static bool checkgame(List<int[]> ran)
        {
            int[] temp = ran[0];
            for(int i=1; i<ran.Count; i++)
            {
                if (ran[0][0] == ran[i][0]&& ran[0][1] == ran[i][1])
                {
                    return true;
                }
            }
            if (temp[0] <= 2 || temp[0] >= 44) return true;
            else if (temp[1] <= 1 || temp[1] >= 21) return true;
            else return false;
        }
        public static void update_ran(int x, int y, List<int[]> ran,ref int oldx,ref int oldy)
        {
            int[] temp = ran[0];
            for(int i = 0; i < ran.Count; i++)
            {
                if(i==ran.Count-1)
                {
                    oldx= ran[i][0];
                    oldy = ran[i][1];
                }
                int[] tp = temp;
                temp = ran[i];
                ran[i] = tp;
                
            }
            ran[0] = new int[] { ran[0][0] + x*2, ran[0][1] + y };

        }
        public static void ve_ran(List<int[]> arr, int x, int y)
        {
            for(int i=0; i<arr.Count; i++) 
            {
                int[] v = arr[i];
                if (i == 0) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(v[0], v[1]);
                    Console.Write("0");
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(v[0], v[1]);
                Console.Write("0");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(x,y);
            Console.Write(" ");
            Console.SetCursorPosition(0, 0);
            Console.Write(arr[0][0] + " " + arr[0][1]);
        }
        
        public static void ve_khung()
        {
            for(int i=1; i<22; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(i*2, 1);
                Console.Write(".");
                Console.SetCursorPosition(i * 2, 21);
                Console.Write(".");
                Console.SetCursorPosition(2, i);
                Console.Write(".");
                Console.SetCursorPosition(44, i);
                Console.Write(".");

            }
        }
    }
}
