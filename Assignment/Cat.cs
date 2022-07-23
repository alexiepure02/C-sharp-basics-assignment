using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Cat : Mammal
    {
        string color;

        public Cat(string color)
        {
            this.color = color;
        }

        public override void Color()
        {
            Console.WriteLine("This Animal is " + color + ".");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void MakeSound(string customSound)
        {
            Console.WriteLine(customSound);
        }
    }
}
