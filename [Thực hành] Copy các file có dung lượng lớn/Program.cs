using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Thực_hành__Copy_các_file_có_dung_lượng_lớn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter source file: ");
            string sourcePath = Console.ReadLine();
            Console.WriteLine("Enter destination file: ");
            string destinationPath = Console.ReadLine();

            FileInfo source = new FileInfo(sourcePath);
            FileInfo des = new FileInfo(destinationPath);
            try
            {
                CopyFileUsingStream(source, des);
                Console.WriteLine("Copy Completed");
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Copy");
                Console.Error.WriteLine(e.Message);
            }
        }

        private static void CopyFileUsingFileInfo(FileInfo source, FileInfo des)
        {
            source.CopyTo(des.FullName, true);
        }

        private static void CopyFileUsingStream(FileInfo source, FileInfo des)
        {
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(source.FullName);
                writer = new StreamWriter(des.FullName);
                Char[] buffer = new Char[1024];
                int length;
                while ((length = reader.Read(buffer,0,1024)) > 0)
                {
                    writer.Write(buffer, 0, length);
                }
            }
            finally
            {
                reader.Close();
                reader.Dispose();
                writer.Close();
                writer.Dispose();
            }
        }
    }
}

