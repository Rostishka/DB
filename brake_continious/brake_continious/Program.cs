using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brake_continious
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int car = 20; car > 3; car -= 2)
            {
                if (car == 12 || car == 6)
                    continue;
                Console.WriteLine(car + "\n");
            }

            for (int bus = 20; bus > 3; bus -= 2)
            {
                if (bus == 10)
                    break;
                Console.WriteLine(bus + "\n");
            }

            Console.ReadKey();
        }
    }
}
