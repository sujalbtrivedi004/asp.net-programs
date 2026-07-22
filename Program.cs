using System;
namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, digit;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                digit = number % 10; // Get the last digit
                sum = sum + digit; // Add the digit to sum
                number = number / 10; // Remove the last digit
            }
            Console.WriteLine("Sum of digits = " + sum);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
