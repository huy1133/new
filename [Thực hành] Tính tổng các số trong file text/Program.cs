using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Thực_hành__Tính_tổng_các_số_trong_file_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "number.txt";
            string line = "";
            int sum = 0;
            if(File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                while ((line = streamReader.ReadLine()) != null)
                {
                    sum += Int32.Parse(line);
                    
                }
                streamReader.Close();
            }
            else
            {
                Console.WriteLine("file null");
            }
            Console.WriteLine("sum: " + sum);
        }
    }
}
