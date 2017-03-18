using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перерахування_enum
{
    

    class Animal
    {
        public Breed breed;

        public Animal(Breed breed)
        {
            this.breed = breed;
        }

        public void Print()
        {
            Console.WriteLine("Breed is: " + breed);
        }
    }
}
