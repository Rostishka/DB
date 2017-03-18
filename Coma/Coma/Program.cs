using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 5, 56, 6, 7, 8, 98 };
            Console.Write(mas[0]);
            for(int i = 1; i < mas.Length; i++)
            {
                Console.Write(", " + mas[i]);
            }

            Console.ReadKey();
        }
    }
}
