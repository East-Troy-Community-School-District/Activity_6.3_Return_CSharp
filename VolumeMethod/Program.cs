/*
 * Volume Method
 * Pawelski
 * 11/5/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * First, Answer the following questions...
 * 1. What does it mean when a parameter is passed
 *    by reference?
 * 2. How can reference parameters be used instead of
 *    a return?
 * 3. What is the advantage of using reference parameters
 *    instead of a return?
 *    
 * Second, we will modify the program so that it uses out
 * parameters in the Input() method.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0, width = 0, depth = 0;
            Input(ref length, ref width, ref depth);
            Console.WriteLine("Volume: " + Volume(length, width, depth));
        }

        /// <summary>
        /// Gets the input from the user for length, width, and depth.
        /// </summary>
        /// <param name="length">Stores the length entered by user.</param>
        /// <param name="width">Stores the width entered by user.</param>
        /// <param name="depth">Stores the depth entered by user.</param>
        private static void Input(ref int length, ref int width, 
            ref int depth)
        {
            Console.Write("Enter the length of the box >> ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of the box >> ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the depth of the box >> ");
            depth = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Calculates the volume of a rectangular prism.
        /// </summary>
        /// <param name="length">Length of the prism.</param>
        /// <param name="width">Width of the prism.</param>
        /// <param name="depth">Depth of the prism.</param>
        /// <returns>Volume of the prism.</returns>
        private static int Volume(int length, int width, int depth)
        {
            return length * width * depth;
        }
    }
}
