using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constuctor
{
    class Animals
    {
        public static int counter = 0;

        public string name;
        public float happyness;
        public int age;

        public Animals()
        {
        name = "Spotty";
        happyness = 0.4f;
        age = 5;

        counter++;

        Print();
        }

        public Animals(string _Name, float _Happyness)
        {
            name = _Name;
            happyness = _Happyness;
            age = 15; 
            counter++;

            Print();
        }

        public Animals(string _Name, float _Happyness, int _Age)
        {
            name = _Name;
            happyness = _Happyness;
            age = _Age;

            counter++;

            Print();
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("How much is he happy " + happyness);
            Console.WriteLine("Age is : " + age);
        }
    }
}
