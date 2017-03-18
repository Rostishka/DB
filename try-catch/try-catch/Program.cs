using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter positive number: ");
            int[] arr = { 1,3,4,5,6};
            try
            {
                arr[3] = 12;
                Console.WriteLine("number is - " + arr[8]);
            }
            catch (FormatException)   {
                Console.WriteLine("Input NUMBER pls");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Input NUMBER in range that we said pls");
            }
            finally
            {
                Console.WriteLine("Shodi nahuy naposledok huesos vonyuchiy");
            }

            Console.ReadLine();
        }
    }
}
