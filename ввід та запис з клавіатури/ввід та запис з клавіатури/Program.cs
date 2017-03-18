using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ввід_та_запис_з_клавіатури
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1, number_2;

            Console.WriteLine("Input number 1 for multyplying: ");
            number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input number 2 for multyplying: ");
            number_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result of operation is: " + (number_1 * number_2));
        }
    }
}
