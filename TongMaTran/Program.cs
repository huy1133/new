using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongMaTran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;
            Console.WriteLine("kich thuoc ma tran: ");
            Console.Write("Height: "); height = Convert.ToInt32(Console.ReadLine());
            width = height;
            int[,] matran = new int[height, width];
            ThemDULieuMaTran(matran);
            HienThiMaTran(matran);
            int sum=0;
            for(int i = 0; i < height; i++)
            {
                sum+= matran[i,i];
            }
            Console.WriteLine("Tong duong cheo chinh la: " + sum);
        }
        static void ThemDULieuMaTran(int[,] matran)
        {
            Random rnd = new Random();
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    matran[i, j] = rnd.Next(1, 9);
                }
            }
        }
        static void HienThiMaTran(int[,] matran)
        {
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    Console.Write(matran[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
