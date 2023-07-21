using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Thực_hành__lớp_Animal_và_interface_Edible
{
    abstract class Animal
    {
        public abstract string MakeSound();
    }
    interface Edible
    {
        string HowToEat();
    }
    class Tiger: Animal
    {
        public override string MakeSound()
        {
            return "Grmmmmmm";
        }
    }
    class Chicken:Animal, Edible
    {
        public override string MakeSound()
        {
            return "cuc cuc tac";
        }

        public string HowToEat()
        {
            return "could be friend ";
            //throw new NotImplementedException();
        }
    }
    abstract class Fruit: Edible
    {
        public abstract string HowToEat();
    }
    class orange: Fruit
    {
        public override string HowToEat()
        {
            return "orange can be slider";
            //throw new NotImplementedException();
        }
        
    }
    class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple can be slider";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Console.WriteLine(apple.HowToEat());
        }
    }
}
