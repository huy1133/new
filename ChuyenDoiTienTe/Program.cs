using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDoiTienTe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tigia = 23000;
            Console.Write("Nhap So USD: ");
            int usd = int.Parse(Console.ReadLine());

            Console.WriteLine("Gia Tri VND: " + tigia * usd+ " VND");
        }
    }
}
