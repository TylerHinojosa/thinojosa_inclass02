using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinojosa_inclass02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* in-class 02
             * By: Tyler Hinojosa
             */

            int firstNumber = 5;
            int secondNumber = firstNumber++;
            int thirdNumber = ++firstNumber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);

            Console.WriteLine();

            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine(thirdNumber - secondNumber);
            Console.WriteLine(thirdNumber * firstNumber);
            Console.WriteLine(thirdNumber / secondNumber);
            Console.WriteLine(thirdNumber % secondNumber);


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
