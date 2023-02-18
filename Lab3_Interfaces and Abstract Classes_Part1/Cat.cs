using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_Abstract_Classes_Part1
{
    internal class Cat : Animal
    {

        public Cat(string Name, string Colour, int Age):base(Name, Colour, Age) { }

        public override void Eat()

        {

            Console.WriteLine("Cat EAT Mice.");

        }

    }
}
