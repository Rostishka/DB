using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuatMethod
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)//Constructor
        {
            Name = name;
        }

        public virtual void Print()//Virtual Method
        {
            Console.WriteLine(Name);//Строчка кодy
            Console.WriteLine("rOMA dAUN");//Строчка коду
            Console.WriteLine("MARSHAL");//Строчка коду
            Console.WriteLine("ABRAL");//Строчка коду
        }
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
            base.Print();//Копіює всі строчки коду з базового методу "Virtual Method"
            Console.WriteLine("Dog's speed: " + speed);
        }
    }

    class Cat : Animal //child class
    {
        private float speed;

        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;

        }
        public override void Print()//Method
        {
            base.Print();//Копіює все що є в public virtual void Print()
            Console.WriteLine("Cat's speed: " + speed);
        }
    }
}
