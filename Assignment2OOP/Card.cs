using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP
{
    class Card
    {
        public List<string> Suit { get; private set; }
        public List<string> Value { get; private set; }

        public Card()
        {
            Suit = new List<string> { "Spades", "Clubs", "Hearts", "Diamonds" };
            Value = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10",
                                       "Ace", "Queen", "Jack", "King"};
        }

        public List<string> GetSetOfCards()
        {
            List<string> cardsSet = new List<string>();
            foreach (var suit in Suit)
            {
                foreach (var value in Value)
                {
                    cardsSet.Add(value + " of " + suit);
                }
            }

            return cardsSet;
        }
    }
}
