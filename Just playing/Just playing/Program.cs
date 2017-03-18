using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_playing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{1} {0}" , byte.MinValue, byte.MaxValue);// 1 в фігурних дужках - це індекс елементів які йдуть після "something" 
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            float f = 3.89f;//Conferting from float to int
            int i = (int)f;//яким би великим не було число після крапки в інтеджері воно вседно буде записуватись ща цілою частиною
            Console.WriteLine(i);


            string str = "12";
            int cam = Convert.ToInt32(str);
            int bor = int.Parse(str);
            Console.WriteLine(cam);
            Console.WriteLine(bor);

            try
            {
                var number = "1234";//С-шарп може сам визначати тип змінної якшо оголошено зманну var
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)//якщо те що в тру не спрацьовує(видає помилку, не компілюється)виконуються команди в блоці кетч
            {
                Console.WriteLine("Sorry but converting from string to byte was unsuccessful :(");
            }

            try
            {
                var number = "true";//С-шарп може сам визначати тип змінної якшо оголошено зманну var
                bool bol = Convert.ToBoolean(number);
                Console.WriteLine(bol);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry but converting from string to byte was unsuccessful :(");
            }

            Console.ReadKey();
        }
    }
}
