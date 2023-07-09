using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoLonNhatTrongmatran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;
            Console.WriteLine("kich thuoc ma tran: ");
            Console.Write("Height: "); height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Weight: "); width = Convert.ToInt32(Console.ReadLine());
            int[,] matran = new int[height, width];
            ThemDULieuMaTran(matran);
            HienThiMaTran(matran);
            TimMaxMaTran(matran);
        }
        static void ThemDULieuMaTran(int[,] matran)
        {
            Random rnd = new Random();
            for(int i=0; i<matran.GetLength(0); i++)
            {
                for(int j=0;  j<matran.GetLength(1); j++)
                {
                    matran[i, j] = rnd.Next(1,9);
                }
            }
        }
        static void HienThiMaTran(int[,] matran)
        {
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    Console.Write(matran[i, j]+" ");
                }Console.WriteLine();
            }
        }
        static void TimMaxMaTran(int[,] matran)
        {
            int max = 0;
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    if (matran[i, j] > max) 
                        max = matran[i, j];
                }
            }
            Console.WriteLine("Gia tri lon nhat la: "+max);
            Console.WriteLine("O vi tri: ");
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    if (matran[i, j] == max)
                        Console.Write("({0},{1}); ", i, j);
                }
            }
        }
    }
}
