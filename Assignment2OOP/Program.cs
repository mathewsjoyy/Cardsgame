using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call methd to start the program
            Deck newDeck = new Deck();
            DrawCards(newDeck);

            Console.ReadKey();
        }

        // Short prgrram which deals one card from deck at a time and also shfles the deck
        private static void DrawCards(Deck Deck)
        {
            Console.WriteLine("Would you like to shuffle your deck of cards? (type yes or no)");

            while (true)
            {
                string option = Console.ReadLine();
                if (option.ToLower() == "yes")
                {
                    Deck.Shuffle();
                    Console.WriteLine("Deck has been randomly shuffled."); break;
                }
                else if (option.ToLower() == "no")
                {
                    Console.WriteLine("Your deck is not shuffled."); break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option!");
                }
            }

            Console.Clear();
            
            while (true)
            {
                Console.WriteLine("Would you like to draw a card?" +
                                  "\n> Press ENTER for yes\n> Type 'anything else' for no");
                string answer = Console.ReadLine();

                if (Deck.IsEmpty())
                {
                    Console.WriteLine("No more cards left in your deck!"); break;
                }
                else if (answer.ToLower() == "")
                {
                    Console.Clear();
                    Console.WriteLine($"> {Deck.Deal()}\n");
                }
                else
                {
                    Console.WriteLine("No more cards will be drawn.."); break;
                }
            }
        }
    }
}