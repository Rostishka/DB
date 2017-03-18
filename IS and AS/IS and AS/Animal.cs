using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_and_AS
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)//Constructor
        {
            Name = name;
        }

        public void Print()
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

        }

    }

    class Cat : Animal //child class
    {
        private float speed;

        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;

        }
    }
}
