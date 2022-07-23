using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal abstract class Reptile : IAnimal
    {
        public virtual void GetInfo()
        {
            MakeSound();
            Color();
            TypeOfBlood();
        }
        public abstract void Color();
        public abstract void MakeSound();
        public void TypeOfBlood()
        {
            Console.WriteLine("This animal has cold blood.");
        }
    }
}
