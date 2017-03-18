using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)//Constructor
        {
            Name = name;
        }

        public abstract void Print();//Virtual Method
    }

    class Dog : Animal //child class
    {
 
        private float speed;

        public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;

        }

        public override void Print()//Method
        {
            Console.WriteLine("Dog's speed: " + speed);
        }
    }

    class Cat : Animal //child class
    {
        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private float speed;

        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;

        }
        public override void Print()//Method
        {
            Console.WriteLine("Cat's speed: " + speed);
        }
    }
}
