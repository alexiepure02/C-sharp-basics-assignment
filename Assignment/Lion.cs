using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Lion : Mammal
    {
        string color;

        public Lion(string color)
        {
            this.color = color;
        }

        public override void Color()
        {
            Console.WriteLine("This Animal is " + color + ".");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
