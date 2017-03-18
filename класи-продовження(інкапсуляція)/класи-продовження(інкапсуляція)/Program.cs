using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace класи_продовження_інкапсуляція_
{
    class Program
    {
        static void Main(string[] args)
        {
            SOmeClass.super = 124; //можна звернутись бо паблік поле

            Console.WriteLine(SOmeClass.super);

            Console.ReadLine();


            SomeClass_p_.important = 23; //не можна звернутись бо привейт поле
        }
    }
}
