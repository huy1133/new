using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnackGame2
{
    internal class Program
    {
        static private int[] head;
        static private List<int[]> body = new List<int[]>();
        static private int[] food;
        static private int[] newpoint;
        static private int[] oldpoint;
        static private int score;
        static private bool game;
        static private int huong;
        static private int speed;
        static private int height=20;
        static private int width=20;
        static private bool gamebegin=true;
        static private bool gameover=false;
        static private int highestscore=0;
        static private bool checkfood;
        static private int[] bigfood;
        static private bool checkbigfood;
        static private int timebigfood;
        static private bool eatbigfood;

        static private void setup()
        {
            head = new int[] { 20, 10 };
            List<int[]> bodyt = new List<int[]>();
            bodyt.Add(new int[] { 18, 10 });
            bodyt.Add(new int[] { 16, 10 });
            bodyt.Add(new int[] { 14, 10 });
            
            body = bodyt;
            newpoint = new int[] { 2, 0 };
            oldpoint = new int[] { 10, 10 };
            score = 0;
            speed = 150;
            huong = 2;
            game = true;
            checkfood = false;
            checkbigfood = true;
            timebigfood = -1;
            eatbigfood = true;
            bigfood = new int[] { 50, 10 };
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (true) {
                if (gamebegin)
                    game_begin();
                if (gameover)
                    over_draw();
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.R)
                    {
                        gamebegin=false;
                        gameover=false;
                        start_game();
                    }
                    
                }
            }
        }
        
        static private void count_score()
        {
            if (head[0] == food[0] && head[1] == food[1])
            {
                score++;
                checkfood = false;
                body.Add(new int[] { oldpoint[0], oldpoint[1] });
            }
            Console.SetCursorPosition(width - 6, height);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("score: " + score);
            if (head[0] == bigfood[0] && head[1] == bigfood[1])
            {
                score+=5;
                eatbigfood = false;
            }
        }
        static private void draw_food()
        {
            Random random = new Random();
            if(!checkfood)
            {
                bool t = true;
                while (t)
                {
                    
                    int a = random.Next(2, 2 * width - 1), 
                        b = random.Next(1, height - 1);
                    foreach (int[] i in body)
                    {
                        if (i[0] != a && i[1]!=b)
                            t=false; break;
                    }
                    if (head[0]!=a && head[1]!=b)
                        t = false;
                    food = new int[] { a, b };
                    if (a % 2 != 0)
                        t = true;
                }
                checkfood = true;

            }
            else
            {
                Console.SetCursorPosition(food[0], food[1]);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("■");
            }
        }
        static private void game_begin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("======Snack Game=====");
            Console.WriteLine("      wellcome");
            Console.WriteLine("     R. bat dau");
            
        }
        static private void start_game()
        {
            batdaulai:
            Console.Clear();
            setup();
            frame_draw();
            menu_draw();
            while (game)
            {
                if (timebigfood > -2)
                {
                    timebigfood-=1;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        if (huong != 3)
                        {
                            newpoint = new int[] { 0, -1 };
                            huong = 1;
                        }
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        if (huong != 1)
                        {
                            newpoint = new int[] { 0, 1 };
                            huong = 3;
                        }
                    }
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        if (huong != 2)
                        {
                            newpoint = new int[] { -2, 0 };
                            huong = 4;
                        }
                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        if (huong != 4)
                        {
                            newpoint = new int[] { 2, 0 };
                            huong = 2;
                        }
                    }
                    if(key.Key == ConsoleKey.P)
                    {
                        Console.Clear();
                        frame_draw();
                        snack_draw();
                        menu_draw();
                        while (Console.ReadKey().Key!=ConsoleKey.P) {
                        }
                        Console.Clear();
                        frame_draw();
                        snack_draw();
                        menu_draw();
                    }
                    if(key.Key == ConsoleKey.R)
                    {

                        goto batdaulai;
                    }
                    if((key.Key == ConsoleKey.Q))
                    {
                        Environment.Exit(0);
                    }
                }
                
                update_snack();
                snack_draw();
                check_gameover();
                draw_food();
                count_score();
                draw_big_food();
                draw_big_food();
                Thread.Sleep(speed);
            }

        }
        static private void draw_big_food()
        {
           
            Random rnd = new Random();
            if (score > 0 && score % 5 == 0&& checkbigfood)
            {
                bool t = true;
                while (t)
                {

                    int a = rnd.Next(2, 2 * width - 1),
                        b = rnd.Next(1, height - 1);
                    foreach (int[] i in body)
                    {
                        if (i[0] != a && i[1] != b)
                            t = false; break;
                    }
                    if (head[0] != a && head[1] != b)
                        t = false;
                    bigfood = new int[] { a, b };
                    if (a % 2 != 0)
                        t = true;
                }
                checkbigfood = false;
                timebigfood = 30;
                eatbigfood = true;
            }
            if (timebigfood > 0 && eatbigfood)
            {
                Console.SetCursorPosition(bigfood[0], bigfood[1]);
                Console.Write("0");
            }
            else
            {
                Console.SetCursorPosition(bigfood[0], bigfood[1]);
                Console.Write(" ");
                if (score % 5 != 0)
                {
                    checkbigfood = true;
                }
                bigfood = new int[] { 50, 10 };
                
            }
        }
        static private void over_draw()
        {
            Console.SetCursorPosition(15, 8);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  you lose");
            Console.SetCursorPosition(15, 9);
            Console.Write("your score: " + score);
            if(score>highestscore)
                highestscore = score;
            if (score % 10 == 0&& score>0&&speed>51)
                speed -= 50;
        }
        static private void check_gameover()
        {
            foreach (int[] i in body)
            {
                if (head[0] == i[0]&& head[1] == i[1])
                {
                    game = false; 
                    gameover = true;
                    break;
                }
            } 
        }
        static private void update_snack()
        {
            int[] temp = head;
            if(!check_wall())
                head = new int[] { head[0] + newpoint[0], head[1] + newpoint[1]};
            oldpoint = body[body.Count-1];
            for(int i=0; i<body.Count; i++)
            {
                int[] tp = body[i];
                body[i] = temp;
                temp = tp;
            }
        }
        static private bool check_wall()
        {
            if (head[0] == width*2-2 && huong == 2)
            {
                head = new int[] { 2, head[1] + newpoint[1] };
                return true;
            }
            else if (head[0] == 2&& huong==4)
            {
                head = new int[] { width*2-2, head[1] + newpoint[1] };
                return true;
            }
            else if( head[1] ==1 && huong == 1){
                head = new int[] { head[0] + newpoint[0], height-2 };
                return true;
            }
            else if (head[1] == height-2 && huong == 3)
            {
                head = new int[] { head[0] + newpoint[0], 1 };
                return true;
            }
            return false;
        }
        static private void snack_draw()
        {
            Console.SetCursorPosition(head[0], head[1]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("■");
            foreach (int[] i in body)
            {
                Console.SetCursorPosition(i[0], i[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("■");
            }
            Console.SetCursorPosition(oldpoint[0], oldpoint[1]);
            Console.Write(" ");
        }
        static private void frame_draw()
        {
            for (int i = 0; i < width; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(i * 2, 0);
                Console.Write(".");
                Console.SetCursorPosition(i * 2, height - 1);
                Console.Write(".");
            }
            for (int i = 0; i < height; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, i);
                Console.Write(".");
                Console.SetCursorPosition(width * 2, i);
                Console.Write(".");
            }
        }
        static void menu_draw()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.SetCursorPosition(width * 2 + 2, 1);
            Console.Write("=====Snack Game=====");
           
            Console.SetCursorPosition(width * 2 + 2, 2);
            Console.Write("p. tam dung");
            Console.SetCursorPosition(width * 2 + 2, 3);
            Console.Write("R. bat dau lai");
            Console.SetCursorPosition(width * 2 + 2, 4);
            Console.Write("Q. thoat game");
            Console.SetCursorPosition(width * 2 + 2, 5);
            Console.Write("highest score: " + highestscore);
        }

    }
}
