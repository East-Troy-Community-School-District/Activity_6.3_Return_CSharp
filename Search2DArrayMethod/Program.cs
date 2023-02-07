/*
 * Search 2D Array Method
 * 2/7/2023
 * C#.NET I
 * 
 * Instructions:
 * Answer the following questions...
 * 1. How is a 2D array passed to a parameter?
 * 2. How is this program similar to the previous? Different?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search2DArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sample = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(SearchArray(sample, 2));
            Console.WriteLine(SearchArray(sample, 9));
        }

        /// <summary>
        /// Searchs the 2D array for the target.
        /// </summary>
        /// <param name="arr">The array to search through.</param>
        /// <param name="target">The element to search for.</param>
        /// <returns>True if contains element; false otherwise.</returns>
        private static bool SearchArray(int[,] arr, int target)
        {
            bool foundElement = false;
            foreach(int element in arr)
            {
                if(element == target)
                {
                    foundElement = true;
                }
            }
            return foundElement;
        }
    }
}
