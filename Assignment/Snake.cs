using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Snake : Reptile
    {
        string color;
        public double Length { get; set; } = 1;     // default value

        public Snake(string color)
        {
            this.color = color;
        }

        public override void Color()
        {
            Console.WriteLine("This Animal is " + color + ".");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hiss!");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("This animal has a length of " + this.Length + ".");
        }
    }
}
