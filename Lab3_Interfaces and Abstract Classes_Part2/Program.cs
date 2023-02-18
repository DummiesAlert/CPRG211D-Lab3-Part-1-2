using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_Abstract_Classes_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Dog Name: ");
            string DogObject = Console.ReadLine();

            Console.WriteLine("Enter Dog Colour: ");
            string DogColour = Console.ReadLine();

            Console.WriteLine("Enter Dog Height: ");
            string DogHeight = Console.ReadLine();

            Console.WriteLine("Enter Dog Age: ");
            string DogAgeRead = Console.ReadLine();
            int DogAge = Convert.ToInt32(DogAgeRead);

            Dog DOG = new Dog(DogObject, DogColour, DogHeight, DogAge);

            Console.WriteLine(DOG.List());
            Console.WriteLine(DOG.Cry());
            DOG.Eat();

            Console.WriteLine("Enter Cat Name: ");
            string CatObject = Console.ReadLine();

            Console.WriteLine("Enter Cat Colour: ");
            string CatColour = Console.ReadLine();

            Console.WriteLine("Enter Cat Height: ");
            string CatHeight = Console.ReadLine();

            Console.WriteLine("Enter Cat Age: ");
            string CatAgeRead = Console.ReadLine();
            int CatAge = Convert.ToInt32(CatAgeRead);

            Cat CAT = new Cat(CatObject, CatColour, CatHeight, CatAge);

            Console.WriteLine(CAT.List());
            Console.WriteLine(CAT.Cry());
            CAT.Eat();

            List<IAnimal> Pets = new List<IAnimal>();

            Pets.Add(DOG);
            Pets.Add(CAT);

            foreach (IAnimal Pet in Pets)
            {
                Console.WriteLine(Pet.Name);
            }

        }

    }
}