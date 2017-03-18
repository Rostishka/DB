using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конструкторы__static
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals ();
            cat.Print();
            Animals.counter++;

            Animals dog = new Animals();
            dog.Print();
            Animals.counter++;

            Console.WriteLine("Number of animals: " + Animals.counter);
            Console.ReadKey();
        }
    }
}
