using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP
{
    class Deck
    {
        // Fields
        public List<Card> Cards { get; private set; }

        // Constructor 
        public Deck()
        {
            Cards = new List<Card>();
            CreateStandardDeck();
        }

        // Fill up the deck when a new object is instansiated
        private void CreateStandardDeck()
        {
            List<string> Suits = new List<string> { "Spades", "Hearts", "Diamonds", "Clubs", };
            List<string> Values = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            foreach(string suit in Suits)
            {
                foreach(string value in Values)
                {
                    Cards.Add(new Card(suit, value));
                }
            };
        }

        public void Shuffle()
        {
            // Use Guid to shuffle the list
            //cards = cards.OrderBy(x => Guid.NewGuid()).ToList();

            // Or use more common way to shuffle
            Random rnd = new Random();
            int count = Cards.Count;

            while (count > 1)
            {
                count--;
                int rng = rnd.Next(count);
                var value = Cards[rng];
                Cards[rng] = Cards[count];
                Cards[count] = value;
            }
        }

        // Keep an index of the top card of the deck
        private int topCardIndex = 51;
        public Card Deal()
        {
            // Mark sure the deck isnt empty
            if (topCardIndex > 0)
            {
                // Get card at top and return it and decrease topCardIndex
                Card topCard = Cards[topCardIndex];
                topCardIndex--;
                return topCard;
            }
            return Cards[0];
            
        }

        // Method which shows user all cards in current deck
        public void DisplayDeck()
        {
            foreach (var card in Cards) Console.WriteLine(card);
        }
    }
}