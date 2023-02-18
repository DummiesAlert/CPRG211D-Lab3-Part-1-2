using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_Abstract_Classes_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Dog Object Name: ");
            string DogObject = Console.ReadLine();
            Console.WriteLine("Enter Dog Color: ");
            string DogColor = Console.ReadLine();
            Console.WriteLine("Enter Dog Age: ");
            string DogAgeString = Console.ReadLine();
            Console.WriteLine();
            int DogAge = Convert.ToInt32(DogAgeString);

            Animal Dog = new Dog(DogObject, DogColor, DogAge);

            Console.WriteLine(Dog.FormListDog());

            Dog.Eat();

            Console.WriteLine("Enter Cat Object Name: ");
            string CatObject = Console.ReadLine();
            Console.WriteLine("Enter Cat Color: ");
            string CatColor = Console.ReadLine();
            Console.WriteLine("Enter Cat Age: ");
            string CatAgeString = Console.ReadLine();
            Console.WriteLine();
            int CatAge = Convert.ToInt32(CatAgeString);

            Animal Cat = new Cat(CatObject, CatColor, CatAge);

            Console.WriteLine(Cat.FormListCat());

            Cat.Eat();

        }
    }
}
