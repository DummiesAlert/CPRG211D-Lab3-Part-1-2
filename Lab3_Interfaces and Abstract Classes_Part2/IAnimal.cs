using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_Abstract_Classes_Part2
{
    internal interface IAnimal
    {

        string Name { get; set; }
        string Colour { get; set; }
        string Height { get; set; }
        int Age { get; set; }

        void Eat();
        string Cry();
        string List();

    }
}
