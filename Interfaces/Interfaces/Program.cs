using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_1 qwerty = new Test_1();
            Test_2 ytrewq = new Test_2();

            qwerty.property = 124;
            qwerty.Print();
            Console.WriteLine("Property is: " + qwerty.property);
            qwerty.Draw();

            ytrewq.property = 11;
            ytrewq.Print();
            Console.WriteLine("Property is: " + ytrewq.property);
            ytrewq.Draw();

            Console.ReadKey();
        }
    }
}
