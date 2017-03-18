using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasliduvannia
{
    class Program
    {
        static void Main(string[] args)
        {
             class Dog : Animal //child class
        {
            private float speed;

            public Dog(float speed, string name) : base(name)
            {
                this.speed = speed;
                Console.WriteLine("Speed: " + speed);
            }

            static void Main(string[] args)
            {
                Dog Tom = new Dog(12.44f, "Tomm");
                Console.WriteLine("Name: " + Tom.Name);
            }
}
