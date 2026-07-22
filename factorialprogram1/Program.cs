using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialprogram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            long factorial = 1;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("Factorial of {0} = {1}", number, factorial);
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
