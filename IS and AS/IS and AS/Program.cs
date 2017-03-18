using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_and_AS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(0.1f, "Vovan"));
            animals.Add(new Dog(124.1f, "Samara"));
            animals.Add(new Cat(4.221f, "Tomas"));

            foreach (Animal animal in animals)
            {
                if (animal is Animal)
                {
                    Console.WriteLine(animal.Name);
                }
                if (animal is Cat)
                    (animal as Cat).Print();
            }


            Console.ReadKey();
        }
    }
}
