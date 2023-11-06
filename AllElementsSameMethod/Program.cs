/*
 * All Elements Same Method
 * Pawelski
 * 11/5/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Answer the following questions...
 * 1. How does the AllSameElement() method work?
 * 2. Why must we subtract 1 from the length inside
 *    the loop? (HINT: see what happens when you don't
 *    subtract 1)
 * 3. Why is it important for the AllSameElement() method
 *    to return false when two elements are not the same?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllElementsSameMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sample1 = { "a", "a", "b", "a" };
            string[] sample2 = { "a", "a", "a", "a" };
            if (AllSameElement(sample1))
            {
                Console.WriteLine("They are all " + sample1[0]);
            }
            else
            {
                Console.WriteLine("At least one element is different!");
            }

            if (!AllSameElement(sample2))
            {
                Console.WriteLine("At least one element is different!");
            }
            else
            {
                Console.WriteLine("They are all " + sample1[0]);
            }
        }

        /// <summary>
        /// Checks if all elements in the array are the same.
        /// </summary>
        /// <param name="arr">Array containing strings.</param>
        /// <returns>
        /// True if all elements are the same; otherwise, false.
        /// </returns>
        private static bool AllSameElement(string[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
