using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static int Main(string[] args)
        {
            // here i used prop
            Snake snake1 = new Snake("yellow");
            snake1.Length = 3.5;

            // here i use the overloaded MakeSound()
            Cat cat1 = new Cat("brown");
            cat1.MakeSound();
            cat1.MakeSound("Purr!");

            Console.WriteLine();

            IAnimal[] animals = new IAnimal[10];
            animals[0] = new Cat("brown");
            animals[1] = new Turtle("green");
            animals[2] = snake1;
            animals[3] = new Lion("blonde");
            animals[4] = new Cat("black");
            animals[5] = new Snake("green and black");
            animals[6] = new Lion("orange and brown");
            animals[7] = new Cat("gray");
            animals[8] = new Turtle("brown with green spots");
            animals[9] = new Turtle("orange");


            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].GetInfo();
                Console.WriteLine();
            }

            // Nu am mai lucrat cu .NET IEnumerable sau ICloneable si nu stiu ce sunt sau cum sa le implementez
            // Am cautat pe net dar nu am inteles foarte bine

            return 0;
        }
    }
}
