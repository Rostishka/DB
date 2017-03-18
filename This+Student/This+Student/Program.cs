using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student I = new Student();

            I.Course = 7;
            I.Mark = 5.32f;
            I.Money = 11111;

            Student.counter++;

            Console.WriteLine(I.Course);
            Console.WriteLine(I.Mark);
            Console.WriteLine(I.Money);

            Student Daun = new Student("Roman Dilay", "KSM-31", 3 , false, 600 , 3.4f);
            
            Student.counter++;
            Console.WriteLine("Number of students: " + Student.counter);
            Daun.Money = 124;
            Console.WriteLine(Daun.Money);

            Console.ReadKey();
        }
    }
}
