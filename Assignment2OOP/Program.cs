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
            Deck newDeck = new Deck();

            newDeck.Shuffle();
            newDeck.DisplayDeck();

            Console.ReadKey();
        }
    }
}
