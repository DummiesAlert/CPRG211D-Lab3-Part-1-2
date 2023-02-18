using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3_Interfaces_and_Abstract_Classes_Part1
{
    internal abstract class Animal
    {

        protected string Name1;
        protected string Colour1;
        private int Age1;

        public string Name

        {
            get { return this.Name1; }
            set { this.Name1 = value; }

        }

        public string Colour

        {

            get { return this.Colour1; }
            set { this.Colour1 = value; }

        }

        protected int Age

        {

            get { return this.Age1; }
            set { this.Age1 = value; }

        }

        public Animal(string Name, string Colour, int Age)
        {
            this.Name = Name;
            this.Colour = Colour;
            this.Age = Age;
        }

        public string FormListDog()

        {

            string Display = string.Format($"Dog Name: {Name} \nDog Colour: {Colour} \nDog Age: {Age} \n");

            return Display;

        }

        public string FormListCat()

        {

            string Display = string.Format($"Cat Name: {Name} \nCat Colour: {Colour} \nCat Age: {Age} \n");

            return Display;

        }

        public abstract void Eat();

    }
}
