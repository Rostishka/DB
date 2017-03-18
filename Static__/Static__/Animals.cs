using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__
{
    class Animals
    {
        public static int counter = 0;

        public string name = "Spotty";
        public float happyness = 0.4f;
        public int age = 5;

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("How much is he happy " + happyness);
            Console.WriteLine("Age is : " + age);
        }
    }
}
