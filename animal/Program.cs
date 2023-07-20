using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    public abstract class animal
    {
        protected string weight { get; set; }
        protected string height { get; set; }

        public animal(string weight = "", string height = "")
        {
            this.weight = weight;
            this.height = height;
        }
        public abstract void PrintInfo();

    }
    class cat : animal
    {
        private string name { get; set; }
        public cat(string weight = "", string height = "", string name = "")
            : base(weight, height)
        {
            this.name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Weight : {0}" + '\n' + 
                "Height: {1}" + '\n' + "Name: {2}"
                , this.weight, this.height, this.name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cat lulu = new cat("20kg", "1.5", "lulu");
            lulu.PrintInfo();
        }
    }
}
