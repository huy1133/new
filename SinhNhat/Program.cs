using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime sn, now, snnow;
            Console.WriteLine("Nhap(dd/MM/yyyy): ");
            string date = Console.ReadLine();
            sn = DateTime.ParseExact(date, "dd/MM/yyyy", null);
            now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            snnow = new DateTime(now.Year, sn.Month, sn.Day);

            if (snnow == now)
                Console.WriteLine("Hom Nay la Sinh Nhat!!");
            else if (snnow < now)
            {
                Console.WriteLine("Da qua Sinh Nhat");
                snnow = snnow.AddYears(1);
                Console.WriteLine("Sinh Nhat ban Con " + (snnow - now).TotalDays +" day");
            }
            else
            {
                Console.WriteLine("Sinh Nhat ban Con " + (snnow - now).TotalDays + "day");
            }
        } 
    }
}
