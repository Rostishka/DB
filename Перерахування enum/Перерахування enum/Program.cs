using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перерахування_enum
{
    enum Breed { Dog, Cat, Bird, Fox, Bear };

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal(Breed.Fox);
            dog.Print();

            Console.ReadLine();
        }
    }
}
