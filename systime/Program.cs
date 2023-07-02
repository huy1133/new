using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace systime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = Encoding.UTF8;
            DateTime localdate = DateTime.Now;
            Console.WriteLine("DateTime now is: "+ localdate);
        }
    }
}
