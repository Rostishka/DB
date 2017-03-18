using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand_numb = new Random();

            int Number;

            Number = rand_numb.Next(1, 14);

            switch (Number)
            {
                case 1:
                    Console.WriteLine("Количок");
                    break;
                case 2:
                    Console.WriteLine("Лебідик");
                    break;
                case 7:
                    Console.WriteLine("Lucky man =)");
                    break;
                case 13:
                    Console.WriteLine("Unfortunately you are looser :(");
                    break;
                default:
                    Console.WriteLine("Number is'nt different ()(((");
                    break;
            }
            Console.ReadKey();
        }
    }
}
