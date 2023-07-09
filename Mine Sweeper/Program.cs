using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_Sweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 10;
            int height = 10;
            int boom = 10;
            string[,] map = new string[height, width];
            create_map(map,boom);
            output_map(map);

            string[,] mapReport = new string[height,width];
            create_mapReport(mapReport, map);
            output_map(mapReport);
        }
        static void create_mapReport(string[,] mapReport, string[,] map)
        {
            for(int i=0; i<map.GetLength(0); i++)
            {
                for(int j=0; j<map.GetLength(1); j++)
                {
                    if (map[i, j] == "*")
                        mapReport[i,j] = "*";
                    else
                    {
                        int minesAround = 0;
                        for (int l = i-1; l<= i+1; l++)
                        {
                            for(int k = j-1; k<= j+1; k++)
                            {
                                if ((l >= 0 && l < map.GetLength(0) && (k >= 0 && k < map.GetLength(1))))
                                {
                                    if (map[l, k] == "*")
                                        minesAround++;
                                }
                            }
                        }
                        mapReport[i, j] = minesAround.ToString();
                    }
                }
            }
        }
        static void output_map(string[,] map)
        {
            for(int i=0; i<map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void create_map(string[,] a, int n)
        {
            Random random = new Random();
            for(int i=0; i<n; i++)
            {
                int x = random.Next(0,a.GetLength(0));
                int y = random.Next(0, a.GetLength(1));
                if (a[x, y] != "*")
                    a[x, y] = "*";
                else
                    i--;

            }
            for (int i= 0; i<a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != "*")
                        a[i, j] = ".";
                }
            }
        }
    }
}
