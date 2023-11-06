/*
 * Generate Card
 * Pawelski
 * 11/5/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Answer the following questions...
 * 1. How many return statements can a method contain?
 * 2. How many values can a method return at a time?
 * 3. What happens when a method encounters a return statement?
 * 4. How does this program demonstrate the benefits
 *    of using methods?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is this your card?");
            Console.WriteLine(GenerateCard());
        }

        /// <summary>
        /// Generates a card with a rank and suit.
        /// </summary>
        /// <returns>Description for the card as a string.</returns>
        private static string GenerateCard()
        {
            return Rank() + " of " + Suit() + "s";
        }

        /// <summary>
        /// Selects a random suit from spade, clubs, hearts, 
        /// and diamonds.
        /// </summary>
        /// <returns>A card suit.</returns>
        private static string Suit()
        {
            int card;
            Random generator = new Random();
            card = generator.Next(0, 4);
            if (card == 0)
            {
                return "spade";
            }
            else if (card == 1)
            {
                return "heart";
            }
            else if (card == 2)
            {
                return "club";
            }
            return "diamond";
        }

        /// <summary>
        /// Selects a random rank from ace to king.
        /// </summary>
        /// <returns>A card rank.</returns>
        private static string Rank()
        {
            int card;
            Random generator = new Random();
            card = generator.Next(1, 14);
            if (card == 13)
            {
                return "king";
            }
            else if (card == 12)
            {
                return "queen";
            }
            else if (card == 11)
            {
                return "jack";
            }
            else if (card == 1)
            {
                return "ace";
            }
            else
            {
                return card.ToString();
            }
        }
    }
}
