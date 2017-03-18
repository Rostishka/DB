using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naslid
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Tom = new Dog(12.44f, "Tomm");
            Console.WriteLine("Name: " + Tom.Name);

            Dog jim = new Dog(11.1f, "Jimmy");
            Console.WriteLine("Name: " + jim.Name);
            Console.WriteLine();
            jim.Print();
            Console.ReadKey();
        }
    }
}