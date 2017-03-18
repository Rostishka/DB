using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naslid
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)//Constructor
        {
            Name = name;
        }

        public void Print()//Method
        {
            Console.WriteLine(Name);
        }
    }

    class Dog : Animal //child class
    {
        private float speed;

        public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;
            Console.WriteLine("Speed: " + speed);
        }
    }
}