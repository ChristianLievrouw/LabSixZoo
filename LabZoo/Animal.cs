using System;

namespace LabZoo
{
    public class Animal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }

        public abstract class Animals
        {
            public int Mass { get; set; }
            public int Legnth { get; set; }
            public bool Fur { get; }

            public abstract string Eat();
            public abstract bool Nocturnal();
            public abstract string Sounds();
        }
}

