using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3_Interfaces_and_Abstract_Classes_Part2
{
    internal class Dog : IAnimal
    {

        private string Name;
        private string Colour;
        private string Height;
        private int Age;

        public string Name2 { get => this.Name; set => Name = value; }
        public string Colour2 { get => this.Colour; set => Colour = value; }
        public string Height2 { get => this.Height; set => Height = value; }
        public int Age2 { get => this.Age; set => Age = value; }
        string IAnimal.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IAnimal.Colour { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IAnimal.Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IAnimal.Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Dog(string Name2, string Colour2, string Height2, int Age2)
        {
            this.Name = Name2;
            this.Colour = Colour2;
            this.Height = Height2;
            this.Age = Age2;
        }

        public string List()
        {
            string Display = string.Format($"Dog Name: {Name2} \nDog Colour: {Colour2} \nDog Height: {Height2} \nDog Age: {Age2}\n");
            return Display;
        }
        
        public string Cry()
        {
            return "Woof!!";
        }

        public void Eat()
        {
            Console.WriteLine("Dogs EAT Meat.");
        }

    }
}
