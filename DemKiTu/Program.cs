using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemKiTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "sfgs9108310742sdgifgweiuhrbcbn";
            Console.WriteLine(a+"\nNhap ki Tu ban muon dem trong chuoi: ");
            char b = char.Parse(Console.ReadLine());
            if (dem(a, b) == 0)
                Console.WriteLine("Khong co tu {0} trong chuoi ", b);
            else
                Console.WriteLine("Tu {0} xuat hien {1} lan",b,dem(a, b));
        }
        public static int dem(string a, char b)
        {
            int count = 0;
            foreach(char s in a)
            {
                if(s==b)
                    count++;
            }
            return count;
        }
    }
}
