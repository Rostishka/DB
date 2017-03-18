using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace класи
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals testAnimal1 = new Animals();

                testAnimal1.name = "Dog";
                testAnimal1.age = 7;

            Cats testCat1 = new Cats();

                testCat1.Color = "Red";
                testCat1.eyeColor = "Green";
                testCat1.age = 21;
                testCat1.poroda = "Vesloheared";

                testCat1.Sound();

            Dogs testDog1 = new Dogs();

            testDog1.age = 7;
            testDog1.Color = "Brown";
            testDog1.eyeColor = "Black";
            testDog1.mood = "Crazy";
            testDog1.NumOfTeeth = 27;
            testDog1.poroda = "Cocer Spaniel English";
            testDog1.name = "Bady";

            testDog1.SoundAggression();


            Console.WriteLine(testAnimal1.name + testAnimal1.age + "years old.");
            Console.ReadLine();
        }
    }
}
