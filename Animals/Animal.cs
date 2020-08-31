using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    abstract class Animal
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public string Eat { get; set; }

        public virtual void Sleep()
        {
            Console.WriteLine("I sleep at night like the average human.");
        }

        public abstract string Sound { get; }

        public abstract string Home { get; }
    }
}
