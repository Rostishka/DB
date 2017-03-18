using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constuctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals();
            Console.WriteLine();
            Animals dog = new Animals("Bady" , 100.112f , 7);
            Console.WriteLine();
            Animals frog = new Animals("Lina", 10.121f);

            Console.WriteLine("Number of animals: " + Animals.counter);
            Console.ReadKey();

        }
    }
}
