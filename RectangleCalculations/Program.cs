/*
 * Rectangle Calculations
 * Pawelski
 * 11/5/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Answer the following questions...
 * 1. Based on this program, what is the benefit
 *    of returning a value instead of immediately
 *    printing the value in the function?
 * 2. How does the XML comment change with return values?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int length1, width1, length2, width2, totalArea;
            Console.Write("What is the length of the rectangle? >> ");
            length1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the width of the rectangle? >> ");
            width1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area: " + RectangleArea(length1, width1));
            Console.WriteLine("Perimeter: " 
                + RectanglePerimeter(length1, width1));
            Console.WriteLine();
            Console.WriteLine(ConvertToDots(length1, width1));

            Console.Write("What is the length of another rectangle? >> ");
            length2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the width of another rectangle? >> ");
            width2 = Convert.ToInt32(Console.ReadLine());
            totalArea = RectangleArea(length1, width1) 
                + RectangleArea(length2, width2);
            Console.WriteLine("Total area: " + totalArea);
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        /// <param name="length">Length of the rectangle.</param>
        /// <param name="width">Width of the rectangle.</param>
        /// <returns>Area of the rectangle.</returns>
        private static int RectangleArea(int length, int width)
        {
            return length * width;
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle.
        /// </summary>
        /// <param name="length">Length of the rectangle.</param>
        /// <param name="width">Width of the rectangle.</param>
        /// <returns>Perimeter of the rectangle.</returns>
        private static int RectanglePerimeter(int length, int width)
        {
            int perimeter = 2 * length + 2 * width;
            return perimeter;
        }

        /// <summary>
        /// Returns a string containing the rectangle drawn using
        /// dots.
        /// </summary>
        /// <param name="length">
        /// Length of the rectangle. Number of rows.
        /// </param>
        /// <param name="width">
        /// Width of the rectangle. Number of columns.
        /// </param>
        /// <returns>
        /// String containing a rectangle drawn using dots.
        /// </returns>
        private static string ConvertToDots(int length, int width)
        {
            string rectangle = "";
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    rectangle += "* ";
                }
                rectangle += "\n";
            }
            return rectangle;
        }
    }
}
