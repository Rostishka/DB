using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ISomeInterface
    {
        int property { get; set; }
        void Print();
    }

    interface IOtherInterface
    { 
        void Draw();
    }

    class Test_1 : ISomeInterface, IOtherInterface
    {
        public int property { get; set; }

        public void Print()
        {
            Console.WriteLine("Some interface text1");
        }

        public void Draw()
        {
            Console.WriteLine("I'm painting");
        }
    }

    class Test_2 : ISomeInterface, IOtherInterface
    {
        public int property { get; set; }

        public void Print()
        {
            Console.WriteLine("THIS IS TEXT 2");
        }

        public void Draw()
        {
            Console.WriteLine("I'm drawing");
        }
    }
}
