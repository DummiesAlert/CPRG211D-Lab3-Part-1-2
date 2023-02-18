using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_Abstract_Classes_Part1
{
    internal class Dog : Animal
    {

        public Dog(string Name, string Colour, int Age):base(Name, Colour, Age) { }

        public override void Eat()

        {

            Console.WriteLine("Dog EAT Meat.\n");

        }

    }
}
