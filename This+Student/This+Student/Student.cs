using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Student
{
    class Student
    {
        public static int counter = 0;

        private string name;
        private string group;
        private int course;
        private bool scholarship;
        private int money;
        private float mark;

        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                if (value < 1)
                    course = 1;
                else if (value > 5)
                    course = 5;
                else
                    course = value;
            }
        }

        public float Mark { get; private set; }

        public int Money { get; set; }

        public void Pass()
        {
            Console.WriteLine("Please pass me exam =)");
        }

        public void Stypendia()
        {
                Console.WriteLine("YAHHOOO easy scholarship XD");
                Console.WriteLine("Please pass me scholarship :)");
        }

        public void PrintAll()
        {
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("Group is:" + group);
            Console.WriteLine("Course is:" + course);
            Console.WriteLine("Scholarship is:" + scholarship);
            Console.WriteLine("Money is:" + money);
            Console.WriteLine("Avarage mark is:" + mark);
        }
        public Student()
        {
            name = "Diakiv Rostyslav";
            group = "KNIT-11";
            course = 1;
            scholarship = true;
            money = 1100;
            mark = 4.7f;

            Pass();
            Stypendia();
            PrintAll();
        }
     
        public Student(string name, string group, int course, bool scholarship, int money, float mark)
        {
            this.name = name;
            this.group = group;
            this.course = course;
            this.scholarship = scholarship;
            this.money = money;
            this.mark = mark;

            Pass();
            PrintAll();
        }

    }
}
