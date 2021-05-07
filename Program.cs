using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert numbers:");

            int userInput = int.Parse(Console.ReadLine());

            int sum = 0;
            int? maxValue = null;
            while (userInput != 0)
            {
                if (maxValue == null || userInput > maxValue)
                {
                    maxValue = userInput;
                }
                sum += userInput;
                userInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum of numbers = {sum}");
            Console.WriteLine($"Max value is {maxValue}");

            Console.ReadKey();            
        }
    }
}
