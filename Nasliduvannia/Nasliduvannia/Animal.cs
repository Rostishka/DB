using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasliduvannia
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
}
}
