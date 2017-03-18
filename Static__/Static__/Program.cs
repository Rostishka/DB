using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals();
            cat.age = 123;
            cat.name = "Pussy";
            cat.Print();
            Animals.counter++;

            Animals dog = new Animals();
            dog.name = "Doggy";
            dog.happyness = 0.999f;
            dog.Print();
            Animals.counter++;

            Console.WriteLine("Number of animals: " + Animals.counter);
            Console.ReadKey();
        }
    }
}
