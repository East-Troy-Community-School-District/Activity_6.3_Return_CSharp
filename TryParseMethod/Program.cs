/*
 * Try Parse Method
 * 2/7/2023
 * C#.NET I
 * 
 * Instructions:
 * Answer the following questions...
 * 1. What happens when you enter "a"? Why?
 * 2. What happens when you enter 6.5? Why?
 * 3. What does TryParse do?
 * 4. How does TryParse use an out parameter?
 * 5. Is the variable text used in any meaningful context?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, total;
            string text;

            // Get the first number
            Console.Write("Enter an integer >> ");
            text = Console.ReadLine();
            while(!int.TryParse(text, out number1))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter an integer >> ");
                text = Console.ReadLine();
            }

            // Get the second number
            Console.Write("Enter another integer >> ");
            text = Console.ReadLine();
            while (!int.TryParse(text, out number2))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter another integer >> ");
                text = Console.ReadLine();
            }

            total = number1 + number2;
            Console.WriteLine(number1 + " + " 
                + number2 + " = " + total);
        }
    }
}
